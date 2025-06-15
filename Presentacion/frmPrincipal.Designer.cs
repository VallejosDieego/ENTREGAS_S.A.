namespace Presentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            BarraTitulo = new Panel();
            btnMinimizar = new PictureBox();
            btnExit = new PictureBox();
            MenuVertical = new Panel();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            btnPedido = new Button();
            label1 = new Label();
            panel4 = new Panel();
            btnRepartidor = new Button();
            panel3 = new Panel();
            btnCliente = new Button();
            panel2 = new Panel();
            btnArticulo = new Button();
            panel1 = new Panel();
            btnTipoArticulo = new Button();
            panelContenedor = new Panel();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnExit);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(497, 35);
            BarraTitulo.TabIndex = 0;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(430, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(28, 29);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click_1;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Image = Properties.Resources.cerrar;
            btnExit.Location = new Point(464, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(28, 29);
            btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            btnExit.TabIndex = 0;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(26, 32, 40);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Controls.Add(panel6);
            MenuVertical.Controls.Add(btnPedido);
            MenuVertical.Controls.Add(label1);
            MenuVertical.Controls.Add(panel4);
            MenuVertical.Controls.Add(btnRepartidor);
            MenuVertical.Controls.Add(panel3);
            MenuVertical.Controls.Add(btnCliente);
            MenuVertical.Controls.Add(panel2);
            MenuVertical.Controls.Add(btnArticulo);
            MenuVertical.Controls.Add(panel1);
            MenuVertical.Controls.Add(btnTipoArticulo);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 35);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(220, 615);
            MenuVertical.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._0ea7e28e_ca75_4def_b2cc_15cf0356b9dd;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 80, 200);
            panel6.Location = new Point(0, 383);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 35);
            panel6.TabIndex = 8;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.FromArgb(26, 32, 40);
            btnPedido.FlatAppearance.BorderSize = 0;
            btnPedido.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnPedido.FlatStyle = FlatStyle.Flat;
            btnPedido.Font = new Font("Arial Narrow", 14.25F);
            btnPedido.ForeColor = SystemColors.ButtonHighlight;
            btnPedido.Location = new Point(0, 383);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(220, 35);
            btnPedido.TabIndex = 9;
            btnPedido.Text = "Pedidos";
            btnPedido.UseVisualStyleBackColor = false;
            btnPedido.Click += btnPedido_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 80, 200);
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(3, 124);
            label1.Name = "label1";
            label1.Size = new Size(208, 31);
            label1.TabIndex = 0;
            label1.Text = "Registro Y Consulta";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 80, 200);
            panel4.Location = new Point(0, 331);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 35);
            panel4.TabIndex = 6;
            // 
            // btnRepartidor
            // 
            btnRepartidor.BackColor = Color.FromArgb(26, 32, 40);
            btnRepartidor.FlatAppearance.BorderSize = 0;
            btnRepartidor.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnRepartidor.FlatStyle = FlatStyle.Flat;
            btnRepartidor.Font = new Font("Arial Narrow", 14.25F);
            btnRepartidor.ForeColor = SystemColors.ButtonHighlight;
            btnRepartidor.Location = new Point(0, 331);
            btnRepartidor.Name = "btnRepartidor";
            btnRepartidor.Size = new Size(220, 35);
            btnRepartidor.TabIndex = 7;
            btnRepartidor.Text = "Repartidores";
            btnRepartidor.UseVisualStyleBackColor = false;
            btnRepartidor.Click += btnRepartidor_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(0, 276);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 35);
            panel3.TabIndex = 4;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.FromArgb(26, 32, 40);
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Font = new Font("Arial Narrow", 14.25F);
            btnCliente.ForeColor = SystemColors.ButtonHighlight;
            btnCliente.Location = new Point(0, 276);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(220, 35);
            btnCliente.TabIndex = 5;
            btnCliente.Text = "Clientes";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 80, 200);
            panel2.Location = new Point(0, 224);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 35);
            panel2.TabIndex = 2;
            // 
            // btnArticulo
            // 
            btnArticulo.BackColor = Color.FromArgb(26, 32, 40);
            btnArticulo.FlatAppearance.BorderSize = 0;
            btnArticulo.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnArticulo.FlatStyle = FlatStyle.Flat;
            btnArticulo.Font = new Font("Arial Narrow", 14.25F);
            btnArticulo.ForeColor = SystemColors.ButtonHighlight;
            btnArticulo.Location = new Point(0, 224);
            btnArticulo.Name = "btnArticulo";
            btnArticulo.Size = new Size(220, 35);
            btnArticulo.TabIndex = 3;
            btnArticulo.Text = "Artículos";
            btnArticulo.UseVisualStyleBackColor = false;
            btnArticulo.Click += btnArticulo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(0, 171);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 35);
            panel1.TabIndex = 0;
            // 
            // btnTipoArticulo
            // 
            btnTipoArticulo.BackColor = Color.FromArgb(26, 32, 40);
            btnTipoArticulo.FlatAppearance.BorderSize = 0;
            btnTipoArticulo.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnTipoArticulo.FlatStyle = FlatStyle.Flat;
            btnTipoArticulo.Font = new Font("Arial Narrow", 14.25F);
            btnTipoArticulo.ForeColor = SystemColors.ButtonHighlight;
            btnTipoArticulo.Location = new Point(0, 171);
            btnTipoArticulo.Name = "btnTipoArticulo";
            btnTipoArticulo.Size = new Size(220, 35);
            btnTipoArticulo.TabIndex = 0;
            btnTipoArticulo.Text = "Tipos de Artículos";
            btnTipoArticulo.UseVisualStyleBackColor = false;
            btnTipoArticulo.Click += btnTipoArticulo_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(46, 66, 82);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(220, 35);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(277, 615);
            panelContenedor.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 650);
            Controls.Add(panelContenedor);
            Controls.Add(MenuVertical);
            Controls.Add(BarraTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPrincipal";
            Text = "Form1";
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            MenuVertical.ResumeLayout(false);
            MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BarraTitulo;
        private Panel MenuVertical;
        private Panel panelContenedor;
        private Button btnTipoArticulo;
        private Panel panel1;
        private Panel panel2;
        private Button btnArticulo;
        private Panel panel4;
        private Button btnRepartidor;
        private Panel panel3;
        private Button btnCliente;
        private Label label1;
        private Panel panel6;
        private Button btnPedido;
        private PictureBox btnExit;
        private PictureBox btnMinimizar;
        private PictureBox pictureBox1;
    }
}
