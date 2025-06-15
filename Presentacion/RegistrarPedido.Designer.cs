namespace Presentacion
{
    partial class RegistrarPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPedido));
            panelContenedor = new Panel();
            label11 = new Label();
            dgvPedidos = new DataGridView();
            NumeroPedido = new DataGridViewTextBoxColumn();
            FechaPedido = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Repartidor = new DataGridViewTextBoxColumn();
            label10 = new Label();
            panel2 = new Panel();
            btnAgregarArticulo = new Button();
            panel1 = new Panel();
            btnEliminar = new Button();
            panel4 = new Panel();
            btnLimpiar = new Button();
            panel3 = new Panel();
            btnGuardar = new Button();
            dgvDetalles = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            TipoArticulo = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            MenuVertical = new Panel();
            txtCantidad = new TextBox();
            label6 = new Label();
            cmbArticulo = new ComboBox();
            label8 = new Label();
            txtDireccion = new TextBox();
            label5 = new Label();
            cmbRepartidor = new ComboBox();
            label1 = new Label();
            cmbCliente = new ComboBox();
            label9 = new Label();
            dtpFechaPedido = new DateTimePicker();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtNumeroPedido = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            BarraTitulo = new Panel();
            btnMinimizar = new PictureBox();
            btnExit = new PictureBox();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(46, 66, 82);
            panelContenedor.Controls.Add(label11);
            panelContenedor.Controls.Add(dgvPedidos);
            panelContenedor.Controls.Add(label10);
            panelContenedor.Controls.Add(panel2);
            panelContenedor.Controls.Add(btnAgregarArticulo);
            panelContenedor.Controls.Add(panel1);
            panelContenedor.Controls.Add(btnEliminar);
            panelContenedor.Controls.Add(panel4);
            panelContenedor.Controls.Add(btnLimpiar);
            panelContenedor.Controls.Add(panel3);
            panelContenedor.Controls.Add(btnGuardar);
            panelContenedor.Controls.Add(dgvDetalles);
            panelContenedor.Controls.Add(MenuVertical);
            panelContenedor.Controls.Add(BarraTitulo);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1030, 667);
            panelContenedor.TabIndex = 6;
            panelContenedor.Paint += panelContenedor_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(0, 80, 200);
            label11.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(725, 405);
            label11.Name = "label11";
            label11.Size = new Size(93, 31);
            label11.TabIndex = 25;
            label11.Text = "Pedidos";
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToDeleteRows = false;
            dgvPedidos.BackgroundColor = Color.FromArgb(46, 66, 82);
            dgvPedidos.BorderStyle = BorderStyle.None;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { NumeroPedido, FechaPedido, Cliente, Repartidor });
            dgvPedidos.GridColor = SystemColors.InfoText;
            dgvPedidos.Location = new Point(551, 442);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.Size = new Size(443, 222);
            dgvPedidos.TabIndex = 24;
            // 
            // NumeroPedido
            // 
            NumeroPedido.HeaderText = "Numero de pedido";
            NumeroPedido.Name = "NumeroPedido";
            NumeroPedido.ReadOnly = true;
            // 
            // FechaPedido
            // 
            FechaPedido.HeaderText = "Fecha del pedido";
            FechaPedido.Name = "FechaPedido";
            FechaPedido.ReadOnly = true;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            // 
            // Repartidor
            // 
            Repartidor.HeaderText = "Repartidor";
            Repartidor.Name = "Repartidor";
            Repartidor.ReadOnly = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(0, 80, 200);
            label10.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(667, 170);
            label10.Name = "label10";
            label10.Size = new Size(197, 31);
            label10.TabIndex = 23;
            label10.Text = "Calculo de Artículo";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 80, 200);
            panel2.Location = new Point(479, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 35);
            panel2.TabIndex = 21;
            // 
            // btnAgregarArticulo
            // 
            btnAgregarArticulo.BackColor = Color.FromArgb(26, 32, 40);
            btnAgregarArticulo.FlatAppearance.BorderSize = 0;
            btnAgregarArticulo.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnAgregarArticulo.FlatStyle = FlatStyle.Flat;
            btnAgregarArticulo.Font = new Font("Arial Narrow", 14.25F);
            btnAgregarArticulo.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarArticulo.Location = new Point(486, 132);
            btnAgregarArticulo.Name = "btnAgregarArticulo";
            btnAgregarArticulo.Size = new Size(193, 35);
            btnAgregarArticulo.TabIndex = 22;
            btnAgregarArticulo.Text = "Agregar Artículo";
            btnAgregarArticulo.UseVisualStyleBackColor = false;
            btnAgregarArticulo.Click += btnAgregarArticulo_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(479, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 35);
            panel1.TabIndex = 19;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(26, 32, 40);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Arial Narrow", 14.25F);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Location = new Point(486, 67);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(193, 35);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 80, 200);
            panel4.Location = new Point(479, 97);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 35);
            panel4.TabIndex = 12;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(26, 32, 40);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Arial Narrow", 14.25F);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(486, 97);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(193, 35);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(479, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 35);
            panel3.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(26, 32, 40);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Arial Narrow", 14.25F);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Location = new Point(486, 35);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(193, 35);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvDetalles
            // 
            dgvDetalles.AllowUserToDeleteRows = false;
            dgvDetalles.BackgroundColor = Color.FromArgb(46, 66, 82);
            dgvDetalles.BorderStyle = BorderStyle.None;
            dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, TipoArticulo, Cantidad, Monto });
            dgvDetalles.GridColor = SystemColors.InfoText;
            dgvDetalles.Location = new Point(484, 211);
            dgvDetalles.Name = "dgvDetalles";
            dgvDetalles.ReadOnly = true;
            dgvDetalles.Size = new Size(543, 177);
            dgvDetalles.TabIndex = 16;
            // 
            // Id
            // 
            Id.HeaderText = "ID Artículo";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre Artículo";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // TipoArticulo
            // 
            TipoArticulo.HeaderText = "Tipo de Artículo";
            TipoArticulo.Name = "TipoArticulo";
            TipoArticulo.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto Total";
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(26, 32, 40);
            MenuVertical.Controls.Add(txtCantidad);
            MenuVertical.Controls.Add(label6);
            MenuVertical.Controls.Add(cmbArticulo);
            MenuVertical.Controls.Add(label8);
            MenuVertical.Controls.Add(txtDireccion);
            MenuVertical.Controls.Add(label5);
            MenuVertical.Controls.Add(cmbRepartidor);
            MenuVertical.Controls.Add(label1);
            MenuVertical.Controls.Add(cmbCliente);
            MenuVertical.Controls.Add(label9);
            MenuVertical.Controls.Add(dtpFechaPedido);
            MenuVertical.Controls.Add(label7);
            MenuVertical.Controls.Add(label4);
            MenuVertical.Controls.Add(label3);
            MenuVertical.Controls.Add(txtNumeroPedido);
            MenuVertical.Controls.Add(label2);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 35);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(480, 632);
            MenuVertical.TabIndex = 2;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.FromArgb(26, 32, 40);
            txtCantidad.ForeColor = SystemColors.HighlightText;
            txtCantidad.Location = new Point(293, 287);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(154, 23);
            txtCantidad.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(284, 264);
            label6.Name = "label6";
            label6.Size = new Size(180, 20);
            label6.TabIndex = 30;
            label6.Text = "Digite la cantidad que desea";
            // 
            // cmbArticulo
            // 
            cmbArticulo.BackColor = Color.FromArgb(26, 32, 40);
            cmbArticulo.ForeColor = SystemColors.HighlightText;
            cmbArticulo.Location = new Point(293, 227);
            cmbArticulo.Name = "cmbArticulo";
            cmbArticulo.Size = new Size(154, 23);
            cmbArticulo.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(284, 201);
            label8.Name = "label8";
            label8.Size = new Size(138, 20);
            label8.TabIndex = 28;
            label8.Text = "Seleccione el artículo";
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(26, 32, 40);
            txtDireccion.ForeColor = SystemColors.HighlightText;
            txtDireccion.Location = new Point(21, 454);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(154, 23);
            txtDireccion.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(12, 431);
            label5.Name = "label5";
            label5.Size = new Size(179, 20);
            label5.TabIndex = 24;
            label5.Text = "Digite la direcció del pedido";
            // 
            // cmbRepartidor
            // 
            cmbRepartidor.BackColor = Color.FromArgb(26, 32, 40);
            cmbRepartidor.ForeColor = SystemColors.HighlightText;
            cmbRepartidor.Location = new Point(21, 393);
            cmbRepartidor.Name = "cmbRepartidor";
            cmbRepartidor.Size = new Size(154, 23);
            cmbRepartidor.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 370);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 22;
            label1.Text = "Seleccione el repartidor";
            // 
            // cmbCliente
            // 
            cmbCliente.BackColor = Color.FromArgb(26, 32, 40);
            cmbCliente.ForeColor = SystemColors.HighlightText;
            cmbCliente.Location = new Point(21, 330);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(154, 23);
            cmbCliente.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(0, 80, 200);
            label9.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(268, 149);
            label9.Name = "label9";
            label9.Size = new Size(195, 31);
            label9.TabIndex = 20;
            label9.Text = "Detalle Del Pedido";
            // 
            // dtpFechaPedido
            // 
            dtpFechaPedido.CalendarMonthBackground = Color.White;
            dtpFechaPedido.Location = new Point(3, 274);
            dtpFechaPedido.Name = "dtpFechaPedido";
            dtpFechaPedido.Size = new Size(214, 23);
            dtpFechaPedido.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 80, 200);
            label7.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(12, 149);
            label7.Name = "label7";
            label7.Size = new Size(176, 31);
            label7.TabIndex = 15;
            label7.Text = "Registrar Pedido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 307);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 9;
            label4.Text = "Seleccione el cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 251);
            label3.Name = "label3";
            label3.Size = new Size(197, 20);
            label3.TabIndex = 5;
            label3.Text = "Seleccione la fecha del pedido";
            // 
            // txtNumeroPedido
            // 
            txtNumeroPedido.BackColor = Color.FromArgb(26, 32, 40);
            txtNumeroPedido.ForeColor = SystemColors.HighlightText;
            txtNumeroPedido.Location = new Point(21, 215);
            txtNumeroPedido.Name = "txtNumeroPedido";
            txtNumeroPedido.Size = new Size(154, 23);
            txtNumeroPedido.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 192);
            label2.Name = "label2";
            label2.Size = new Size(174, 20);
            label2.TabIndex = 3;
            label2.Text = "Digite el número de pedido";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._0ea7e28e_ca75_4def_b2cc_15cf0356b9dd;
            pictureBox1.Location = new Point(125, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnExit);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1030, 35);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(956, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(28, 29);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Image = Properties.Resources.cerrar;
            btnExit.Location = new Point(990, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(28, 29);
            btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            btnExit.TabIndex = 0;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // RegistrarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 667);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrarPedido";
            Text = "RegistrarPedido";
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
            MenuVertical.ResumeLayout(false);
            MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private Panel panel1;
        private Button btnEliminar;
        private Panel panel4;
        private Button btnLimpiar;
        private Panel panel3;
        private Button btnGuardar;
        private DataGridView dgvDetalles;
        private Panel MenuVertical;
        private DateTimePicker dtpFechaPedido;
        private Label label7;
        private Label label4;
        private Label label3;
        private TextBox txtNumeroPedido;
        private Label label2;
        private Panel BarraTitulo;
        private PictureBox btnMinimizar;
        private PictureBox btnExit;
        private PictureBox pictureBox1;
        private ComboBox cmbCliente;
        private Label label9;
        private TextBox txtDireccion;
        private Label label5;
        private ComboBox cmbRepartidor;
        private Label label1;
        private Label label8;
        private ComboBox cmbArticulo;
        private TextBox txtCantidad;
        private Label label6;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn TipoArticulo;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Monto;
        private Panel panel2;
        private Button btnAgregarArticulo;
        private Label label10;
        private DataGridView dgvPedidos;
        private Label label11;
        private DataGridViewTextBoxColumn NumeroPedido;
        private DataGridViewTextBoxColumn FechaPedido;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Repartidor;
    }
}