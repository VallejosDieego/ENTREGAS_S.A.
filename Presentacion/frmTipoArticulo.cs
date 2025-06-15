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
 * Fecha: 11/10/2025
 */

namespace Presentacion
{
    public partial class frmTipoArticulo : Form
    {
        public frmTipoArticulo()
        {
            InitializeComponent();
            ActualizarDataGridView();
        }

        private void TipoArticulo_Load(object sender, EventArgs e)
        {
            ActualizarDataGridView();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si ya existe un tipo con ese ID
                if (int.TryParse(txtID.Text, out int id) && LogicaTipoArticulo.ExisteTipoArticulo(id))
                {
                    MessageBox.Show("Ya existe un tipo de artículo con ese ID.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LogicaTipoArticulo.GuardarTipoArticulo(
                    txtID.Text,
                    txtNombre.Text,
                    txtDescripcion.Text
                );

                MessageBox.Show("Tipo de artículo guardado correctamente.", "Éxito",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                ActualizarDataGridView();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error de validación",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarDataGridView()
        {
            try
            {
                dgvTipoArticulo.DataSource = LogicaTipoArticulo.ObtenerTiposArticulo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la grilla: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        //Limpieza de campos después de guardar
        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtID.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
        }

        private void label7_Click(object sender, EventArgs e)
        {

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
