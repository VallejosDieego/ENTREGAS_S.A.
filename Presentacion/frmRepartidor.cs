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
 * Fecha: 12/6/2025
 */

namespace Presentacion
{
    public partial class frmRepartidor : Form
    {
        public frmRepartidor()
        {
            InitializeComponent();
            ActualizarDataGridView();
            CargarComboActivo();
        }

        private void frmRepartidor_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtID.Text, out int id))
                {
                    MessageBox.Show("El ID debe ser un número válido.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (LogicaRepartidor.ExisteRepartidor(id))
                {
                    MessageBox.Show("Ya existe un repartidor con ese ID.",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LogicaRepartidor.GuardarRepartidor(
                    id,
                    txtNombre.Text,
                    txtPrimerApellido.Text,
                    txtSegundoApellido.Text,
                    dtpFechaNacimiento.Value,
                    dtpFechaContratacion.Value,
                    cmbActivo.SelectedItem.ToString() == "Sí"
                );

                MessageBox.Show("Repartidor guardado correctamente.",
                              "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                dgvRepartidores.Rows.Clear();
                var repartidores = LogicaRepartidor.ObtenerRepartidores();

                foreach (var repartidor in repartidores)
                {
                    dgvRepartidores.Rows.Add(
                        repartidor.Id,
                        repartidor.Nombre,
                        repartidor.PrimerApellido,
                        repartidor.SegundoApellido,
                        repartidor.FechaNacimiento.ToString("dd/MM/yyyy"),
                        repartidor.FechaContratacion.ToString("dd/MM/yyyy"),
                        repartidor.Activo ? "Sí" : "No"
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
            dtpFechaContratacion.Value = DateTime.Today;
            cmbActivo.SelectedIndex = 0;
            txtID.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRepartidores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un repartidor para eliminar.",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idSeleccionado = Convert.ToInt32(dgvRepartidores.SelectedRows[0].Cells["Id"].Value);

            var confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar este repartidor?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    LogicaRepartidor.EliminarRepartidor(idSeleccionado);
                    MessageBox.Show("Repartidor eliminado correctamente.");
                    ActualizarDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el repartidor: {ex.Message}",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
