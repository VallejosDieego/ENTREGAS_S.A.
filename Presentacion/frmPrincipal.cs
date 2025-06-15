using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

/**
 * UNED III Cuatrimestre 
 * Proyecto I
 * Estudiante: Diego Vallejos
 * Fecha: 9/6/2025
 */

namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }





        // Método para mover la ventana al hacer clic y arrastrar en la barra de título
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //  Abrir el formulario de TipoArticulo al hacer clic en el botón
        private void btnTipoArticulo_Click(object sender, EventArgs e)
        {
            frmTipoArticulo tipoForm = new frmTipoArticulo();
            tipoForm.ShowDialog();// Cambiar 'tipoForm' por 'formulario'
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            frmArticulo artForm = new frmArticulo();
            artForm.ShowDialog();// Bloquea el menú hasta cerrar el formulario
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmClientes artForm = new frmClientes();
            artForm.ShowDialog();
        }

        private void btnRepartidor_Click(object sender, EventArgs e)
        {
            frmRepartidor artFrom = new frmRepartidor();
            artFrom.ShowDialog();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            RegistrarPedido artForm = new RegistrarPedido();
            artForm.ShowDialog();
        }
    }
}
