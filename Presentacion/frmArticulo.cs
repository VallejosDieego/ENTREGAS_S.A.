using EntregasSA.AccesoDatos;
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
    public partial class frmArticulo : Form
    {




        // Constructor del formulario
        public frmArticulo()
        {

            InitializeComponent();
            ActualizarDataGridView();
            CargarComboTipo();
            CargarComboActivo();
        }

        // Boton de guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que haya un tipo seleccionado
                if (cmbTipo.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un tipo de artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar que haya un estado activo seleccionado
                if (cmbActivo.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar si el artículo está activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar si ya existe el ID antes de procesar
                if (int.TryParse(txtID.Text, out int id) && LogicaArticulo.ExisteArticulo(id))
                {
                    MessageBox.Show("Ya existe un artículo con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Guardar el artículo utilizando la lógica de negocio
                LogicaArticulo.GuardarArticulo(
                    txtID.Text,
                    txtNombre.Text,
                    (TipoArticulo)cmbTipo.SelectedItem!,
                    txtValor.Text,
                    txtInventario.Text,
                    cmbActivo.SelectedItem.ToString() == "Sí"
                );

                // Mostrar mensaje en caso éxito
                MessageBox.Show("Artículo guardado correctamente.", "Éxito",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                ActualizarDataGridView();
            }
            // Captura de excepciones específicas para validación
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Captura de excepciones generales
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CargarComboTipo()
        {
            var tipos = DatosTipoArticulo.ObtenerTiposArticulo();

            // Valida si no hay tipos de artículo registrados
            if (tipos == null || tipos.Length == 0)
            {
                MessageBox.Show("No hay tipos de artículo registrados. Por favor, agregue tipos primero.",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Configuración del ComboBox
            cmbTipo.DataSource = null;
            cmbTipo.Items.Clear();
            cmbTipo.DisplayMember = "Nombre";
            cmbTipo.ValueMember = "Id";
            cmbTipo.DataSource = tipos;
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.SelectedIndex = 0;
        }

        private void CargarComboActivo()
        {

            cmbActivo.Items.Clear();
            cmbActivo.Items.AddRange(new object[] { "Sí", "No" });
            cmbActivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActivo.SelectedIndex = 0;

        }

        private void ActualizarDataGridView()
        {
            dgvArticulo.Rows.Clear();
            // Obtener los artículos desde la capa de acceso a datos
            var articulos = DatosArticulo.ObtenerArticulos();



            // Agregar todos los artículos al DataGridView
            foreach (var art in articulos)
            {
                dgvArticulo.Rows.Add(
                    art.Id,
                    art.Nombre,
                    art.TipoArticulo.Nombre,
                    art.Valor,
                    art.Inventario,
                    art.Activo ? "Sí" : "No"
                );
            }
        }




        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            cmbTipo.SelectedIndex = -1;
            txtValor.Clear();
            txtInventario.Clear();
            cmbActivo.SelectedIndex = -1;
            txtID.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArticulo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un artículo para eliminar.");
                return;
            }

            int idSeleccionado = Convert.ToInt32(dgvArticulo.SelectedRows[0].Cells["Id"].Value);

            var confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar este artículo?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    DatosArticulo.EliminarArticulo(idSeleccionado);
                    MessageBox.Show("Artículo eliminado correctamente.");
                    ActualizarDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
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
