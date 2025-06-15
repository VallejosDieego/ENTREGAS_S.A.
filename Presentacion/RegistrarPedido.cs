using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using EntregasSA.Entidades;
using EntregasSA.LogicaNegocio;
using System.Runtime.InteropServices;


/**
 * UNED III Cuatrimestre 
 * Proyecto I
 * Estudiante: Diego Vallejos
 * Fecha: 11/6/2025
 */

namespace Presentacion
{
    public partial class RegistrarPedido : Form
    {
        private List<DetallePedido> detallesTemp = new List<DetallePedido>();

        public RegistrarPedido()
        {
            InitializeComponent();
            ConfigurarControles();
            CargarCombos();
            ActualizarGridPedidos();
        }

        private void ConfigurarControles()
        {


            // Configurar ComboBox
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRepartidor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArticulo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarCombos()
        {
            CargarComboClientes();
            CargarComboRepartidores();
            CargarComboArticulos();
        }

        private void CargarComboClientes()
        {
            var clientes = LogicaPedido.ObtenerClientesActivos();
            if (clientes.Length == 0)
            {
                MessageBox.Show("No hay clientes activos disponibles.",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Id";
            cmbCliente.DataSource = clientes;
        }

        private void CargarComboRepartidores()
        {
            var repartidores = LogicaPedido.ObtenerRepartidoresActivos();
            if (repartidores.Length == 0)
            {
                MessageBox.Show("No hay repartidores activos disponibles.",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cmbRepartidor.DisplayMember = "Nombre";
            cmbRepartidor.ValueMember = "Id";
            cmbRepartidor.DataSource = repartidores;
        }

        private void CargarComboArticulos()
        {
            var articulos = LogicaPedido.ObtenerArticulosDisponibles();
            if (articulos.Length == 0)
            {
                MessageBox.Show("No hay artículos disponibles.",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cmbArticulo.DisplayMember = "Nombre";
            cmbArticulo.ValueMember = "Id";
            cmbArticulo.DataSource = articulos;
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNumeroPedido.Text))
                {
                    MessageBox.Show("El número de pedido es obligatorio.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDireccion.Text))
                {
                    MessageBox.Show("La dirección es obligatoria.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (detallesTemp.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un artículo al pedido.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LogicaPedido.GuardarPedido(
                    txtNumeroPedido.Text,
                    dtpFechaPedido.Value,
                    (Cliente)cmbCliente.SelectedItem!,
                    (Repartidor)cmbRepartidor.SelectedItem!,
                    txtDireccion.Text
                );

                foreach (var detalle in detallesTemp)
                {
                    LogicaPedido.AgregarDetallePedido(
                        int.Parse(txtNumeroPedido.Text),
                        detalle.Articulo,
                        detalle.Cantidad
                    );
                }

                MessageBox.Show("Pedido registrado correctamente.",
                              "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTodo();
                ActualizarGridPedidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarGridDetalles()
        {
            dgvDetalles.Rows.Clear();
            foreach (var detalle in detallesTemp)
            {
                dgvDetalles.Rows.Add(
                    detalle.Articulo.Id,
                    detalle.Articulo.Nombre,
                    detalle.Articulo.TipoArticulo.Nombre,
                    detalle.Cantidad,
                    detalle.Monto.ToString("C2")
                );
            }
        }

        private void ActualizarGridPedidos()
        {
            try
            {
                dgvPedidos.Rows.Clear();
                var pedidos = LogicaPedido.ObtenerPedidos();

                foreach (var pedido in pedidos)
                {
                    string nombreCliente = $"{pedido.cliente.Nombre} {pedido.cliente.PrimerApellido} {pedido.cliente.SegundoApellido}";
                    string nombreRepartidor = $"{pedido.repartidor.Nombre} {pedido.repartidor.PrimerApellido} {pedido.repartidor.SegundoApellido}";

                    dgvPedidos.Rows.Add(
                        pedido.NumeroPedido,
                        pedido.FechaPedido.ToString("dd/MM/yyyy"),
                        nombreCliente,
                        nombreRepartidor
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la grilla de pedidos: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCamposDetalle()
        {
            txtCantidad.Clear();
            if (cmbArticulo.Items.Count > 0)
                cmbArticulo.SelectedIndex = 0;
            txtCantidad.Focus();
        }

        private void LimpiarTodo()
        {
            txtNumeroPedido.Clear();
            txtDireccion.Clear();
            dtpFechaPedido.Value = DateTime.Today;
            if (cmbCliente.Items.Count > 0) cmbCliente.SelectedIndex = 0;
            if (cmbRepartidor.Items.Count > 0) cmbRepartidor.SelectedIndex = 0;
            detallesTemp.Clear();
            ActualizarGridDetalles();
            LimpiarCamposDetalle();
            txtNumeroPedido.Focus();
        }





        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetalles.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un artículo para eliminar.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idArticulo = Convert.ToInt32(dgvDetalles.SelectedRows[0].Cells[0].Value);

                var confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este artículo del pedido?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    // Encontrar y eliminar el detalle de la lista temporal
                    var detalleAEliminar = detallesTemp.First(d => d.Articulo.Id == idArticulo);
                    detallesTemp.Remove(detalleAEliminar);

                    // Actualizar el DataGridView
                    ActualizarGridDetalles();

                    MessageBox.Show("Artículo eliminado del pedido correctamente.",
                                  "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el artículo: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarArticulo_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtCantidad.Text, out int cantidad))
                {
                    MessageBox.Show("La cantidad debe ser un número válido.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var articulo = (Articulo)cmbArticulo.SelectedItem;
                if (articulo == null)
                {
                    MessageBox.Show("Debe seleccionar un artículo.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor que cero.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cantidad > articulo.Inventario)
                {
                    MessageBox.Show($"No hay suficiente inventario. Disponible: {articulo.Inventario}",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (detallesTemp.Exists(d => d.Articulo.Id == articulo.Id))
                {
                    MessageBox.Show("Este artículo ya está en el pedido.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var detalle = new DetallePedido
                {
                    Articulo = articulo,
                    Cantidad = cantidad,
                    Monto = LogicaPedido.CalcularMontoConEnvio(articulo.Valor, cantidad)
                };

                detallesTemp.Add(detalle);
                ActualizarGridDetalles();
                LimpiarCamposDetalle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
