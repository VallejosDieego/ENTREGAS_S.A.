namespace Presentacion
{
    partial class frmArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulo));
            panelContenedor = new Panel();
            panel1 = new Panel();
            btnEliminar = new Button();
            dgvArticulo = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            TipoArticulo = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Inventario = new DataGridViewTextBoxColumn();
            Activo = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            btnLimpiar = new Button();
            panel3 = new Panel();
            btnGuardar = new Button();
            MenuVertical = new Panel();
            cmbTipo = new ComboBox();
            label7 = new Label();
            cmbActivo = new ComboBox();
            label6 = new Label();
            txtInventario = new TextBox();
            label5 = new Label();
            txtValor = new TextBox();
            label4 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            BarraTitulo = new Panel();
            btnMinimizar = new PictureBox();
            btnExit = new PictureBox();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArticulo).BeginInit();
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
            panelContenedor.Controls.Add(panel1);
            panelContenedor.Controls.Add(btnEliminar);
            panelContenedor.Controls.Add(dgvArticulo);
            panelContenedor.Controls.Add(panel4);
            panelContenedor.Controls.Add(btnLimpiar);
            panelContenedor.Controls.Add(panel3);
            panelContenedor.Controls.Add(btnGuardar);
            panelContenedor.Controls.Add(MenuVertical);
            panelContenedor.Controls.Add(BarraTitulo);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.ForeColor = SystemColors.ControlText;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(902, 566);
            panelContenedor.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(220, 98);
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
            btnEliminar.Location = new Point(220, 98);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(195, 35);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvArticulo
            // 
            dgvArticulo.AllowUserToDeleteRows = false;
            dgvArticulo.BackgroundColor = Color.FromArgb(46, 66, 82);
            dgvArticulo.BorderStyle = BorderStyle.None;
            dgvArticulo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticulo.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, TipoArticulo, Valor, Inventario, Activo });
            dgvArticulo.Location = new Point(235, 218);
            dgvArticulo.Name = "dgvArticulo";
            dgvArticulo.ReadOnly = true;
            dgvArticulo.Size = new Size(644, 336);
            dgvArticulo.TabIndex = 16;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // TipoArticulo
            // 
            TipoArticulo.DataPropertyName = "TipoArticulo";
            TipoArticulo.HeaderText = "Tipo de Artículo";
            TipoArticulo.Name = "TipoArticulo";
            TipoArticulo.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.DataPropertyName = "Valor";
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // Inventario
            // 
            Inventario.DataPropertyName = "Inventario";
            Inventario.HeaderText = "Inventario";
            Inventario.Name = "Inventario";
            Inventario.ReadOnly = true;
            // 
            // Activo
            // 
            Activo.DataPropertyName = "Activo";
            Activo.HeaderText = "Activo";
            Activo.Name = "Activo";
            Activo.ReadOnly = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 80, 200);
            panel4.Location = new Point(220, 64);
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
            btnLimpiar.Location = new Point(220, 64);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(195, 35);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(220, 35);
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
            btnGuardar.Location = new Point(220, 35);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(195, 35);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(26, 32, 40);
            MenuVertical.Controls.Add(cmbTipo);
            MenuVertical.Controls.Add(label7);
            MenuVertical.Controls.Add(cmbActivo);
            MenuVertical.Controls.Add(label6);
            MenuVertical.Controls.Add(txtInventario);
            MenuVertical.Controls.Add(label5);
            MenuVertical.Controls.Add(txtValor);
            MenuVertical.Controls.Add(label4);
            MenuVertical.Controls.Add(label1);
            MenuVertical.Controls.Add(txtNombre);
            MenuVertical.Controls.Add(label3);
            MenuVertical.Controls.Add(txtID);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Controls.Add(label2);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 35);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(220, 531);
            MenuVertical.TabIndex = 2;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(21, 332);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 80, 200);
            label7.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(56, 139);
            label7.Name = "label7";
            label7.Size = new Size(99, 31);
            label7.TabIndex = 15;
            label7.Text = "Artículos";
            // 
            // cmbActivo
            // 
            cmbActivo.BackColor = Color.FromArgb(26, 32, 40);
            cmbActivo.ForeColor = SystemColors.HighlightText;
            cmbActivo.Location = new Point(21, 501);
            cmbActivo.Name = "cmbActivo";
            cmbActivo.Size = new Size(154, 23);
            cmbActivo.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(12, 478);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 13;
            label6.Text = "Se encuentra activo";
            // 
            // txtInventario
            // 
            txtInventario.BackColor = Color.FromArgb(26, 32, 40);
            txtInventario.ForeColor = SystemColors.HighlightText;
            txtInventario.Location = new Point(21, 452);
            txtInventario.Name = "txtInventario";
            txtInventario.Size = new Size(154, 23);
            txtInventario.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(12, 429);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 11;
            label5.Text = "Ingrese la catidad";
            // 
            // txtValor
            // 
            txtValor.BackColor = Color.FromArgb(26, 32, 40);
            txtValor.ForeColor = SystemColors.HighlightText;
            txtValor.Location = new Point(21, 391);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(154, 23);
            txtValor.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 368);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 9;
            label4.Text = "Ingrese el valor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 309);
            label1.Name = "label1";
            label1.Size = new Size(187, 20);
            label1.TabIndex = 7;
            label1.Text = "Seleccione el tipo del artículo";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(26, 32, 40);
            txtNombre.ForeColor = SystemColors.HighlightText;
            txtNombre.Location = new Point(21, 274);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(154, 23);
            txtNombre.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 251);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 5;
            label3.Text = "Digite el nombre";
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(26, 32, 40);
            txtID.ForeColor = SystemColors.HighlightText;
            txtID.Location = new Point(21, 215);
            txtID.Name = "txtID";
            txtID.Size = new Size(154, 23);
            txtID.TabIndex = 4;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 192);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 3;
            label2.Text = "Digite el ID";
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(0, 80, 200);
            BarraTitulo.Controls.Add(btnMinimizar);
            BarraTitulo.Controls.Add(btnExit);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(902, 35);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown_1;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(828, 3);
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
            btnExit.Location = new Point(862, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(28, 29);
            btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            btnExit.TabIndex = 0;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 566);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmArticulo";
            Text = "frmArticulo";
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvArticulo).EndInit();
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
        private Panel BarraTitulo;
        private PictureBox btnMinimizar;
        private PictureBox btnExit;
        private Panel MenuVertical;
        private PictureBox pictureBox1;
        private TextBox txtID;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox txtValor;
        private ComboBox cmbActivo;
        private Label label6;
        private TextBox txtInventario;
        private Panel panel4;
        private Button btnLimpiar;
        private Panel panel3;
        private Button btnGuardar;
        private DataGridView dgvArticulo;
        private Label label7;
        private Panel panel1;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn TipoArticulo;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Inventario;
        private DataGridViewTextBoxColumn Activo;
        private ComboBox cmbTipo;
    }
}