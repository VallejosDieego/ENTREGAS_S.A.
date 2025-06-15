using EntregasSA.Entidades;
using EntregasSA.LogicaNegocio;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

/**
 * UNED III Cuatrimestre 
 * Proyecto I
 * Estudiante: Diego Vallejos
 * Fecha: 11/6/2025
 */


namespace Presentacion
{
    public partial class frmClientes : Form
    {


        public frmClientes()
        {
            InitializeComponent();
            ActualizarDataGridView();
            CargarComboActivo();
        }



        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtID.Text, out int id))
                {
                    MessageBox.Show("El ID debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar si ya existe un cliente con ese ID
                if (LogicaCliente.ExisteCliente(id))
                {
                    MessageBox.Show("Ya existe un cliente con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LogicaCliente.GuardarCliente(
                    id,
                    txtNombre.Text,
                    txtPrimerApellido.Text,
                    txtSegundoApellido.Text,
                    dtpFechaNacimiento.Value,
                    cmbActivo.SelectedItem.ToString() == "Sí"
                );

                MessageBox.Show("Cliente guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                ActualizarDataGridView();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Carga el combo de activo con las opciones "Sí" y "No"
        private void CargarComboActivo()
        {
            cmbActivo.Items.Clear();
            cmbActivo.Items.AddRange(new object[] { "Sí", "No" });
            cmbActivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActivo.SelectedIndex = 0;
        }



        private void ActualizarDataGridView()
        {
            try
            {
                dgvClientes.Rows.Clear();
                var clientes = LogicaCliente.ObtenerClientes();

                foreach (var cliente in clientes)
                {
                    dgvClientes.Rows.Add(
                        cliente.Id,
                        cliente.Nombre,
                        cliente.PrimerApellido,
                        cliente.SegundoApellido,
                        cliente.FechaNacimiento.ToShortDateString(),
                        cliente.Activo ? "Sí" : "No"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la grilla: {ex.Message}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
            cmbActivo.SelectedIndex = 0;
            txtID.Focus();
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente para eliminar.",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idSeleccionado = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["Id"].Value);

            var confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar este cliente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    LogicaCliente.EliminarCliente(idSeleccionado);
                    MessageBox.Show("Cliente eliminado correctamente.");
                    ActualizarDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el cliente: {ex.Message}",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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