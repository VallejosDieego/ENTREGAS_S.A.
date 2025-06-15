namespace Presentacion
{
    partial class frmRepartidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepartidor));
            panelContenedor = new Panel();
            panel1 = new Panel();
            btnEliminar = new Button();
            panel4 = new Panel();
            btnLimpiar = new Button();
            panel3 = new Panel();
            btnGuardar = new Button();
            dgvRepartidores = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            PrimerApellido = new DataGridViewTextBoxColumn();
            SegundoApellido = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            FechaContratacion = new DataGridViewTextBoxColumn();
            Activo = new DataGridViewTextBoxColumn();
            MenuVertical = new Panel();
            dtpFechaContratacion = new DateTimePicker();
            label8 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            label1 = new Label();
            label7 = new Label();
            cmbActivo = new ComboBox();
            label6 = new Label();
            txtSegundoApellido = new TextBox();
            label5 = new Label();
            txtPrimerApellido = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            BarraTitulo = new Panel();
            btnMinimizar = new PictureBox();
            btnExit = new PictureBox();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRepartidores).BeginInit();
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
            panelContenedor.Controls.Add(panel4);
            panelContenedor.Controls.Add(btnLimpiar);
            panelContenedor.Controls.Add(panel3);
            panelContenedor.Controls.Add(btnGuardar);
            panelContenedor.Controls.Add(dgvRepartidores);
            panelContenedor.Controls.Add(MenuVertical);
            panelContenedor.Controls.Add(BarraTitulo);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1013, 667);
            panelContenedor.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(219, 67);
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
            btnEliminar.Location = new Point(226, 67);
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
            panel4.Location = new Point(219, 97);
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
            btnLimpiar.Location = new Point(226, 97);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(193, 35);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(219, 35);
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
            btnGuardar.Location = new Point(226, 35);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(193, 35);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvRepartidores
            // 
            dgvRepartidores.AllowUserToDeleteRows = false;
            dgvRepartidores.BackgroundColor = Color.FromArgb(46, 66, 82);
            dgvRepartidores.BorderStyle = BorderStyle.None;
            dgvRepartidores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRepartidores.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, FechaContratacion, Activo });
            dgvRepartidores.GridColor = SystemColors.InfoText;
            dgvRepartidores.Location = new Point(235, 218);
            dgvRepartidores.Name = "dgvRepartidores";
            dgvRepartidores.ReadOnly = true;
            dgvRepartidores.Size = new Size(775, 336);
            dgvRepartidores.TabIndex = 16;
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
            // PrimerApellido
            // 
            PrimerApellido.DataPropertyName = "PrimerApellido";
            PrimerApellido.HeaderText = "Primer Apellido";
            PrimerApellido.Name = "PrimerApellido";
            PrimerApellido.ReadOnly = true;
            // 
            // SegundoApellido
            // 
            SegundoApellido.DataPropertyName = "SegundoApellido";
            SegundoApellido.HeaderText = "Segundo Apellido";
            SegundoApellido.Name = "SegundoApellido";
            SegundoApellido.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.DataPropertyName = "FechaNacimiento";
            FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.ReadOnly = true;
            // 
            // FechaContratacion
            // 
            FechaContratacion.HeaderText = "Fecha de Contratación";
            FechaContratacion.Name = "FechaContratacion";
            FechaContratacion.ReadOnly = true;
            // 
            // Activo
            // 
            Activo.DataPropertyName = "Activo";
            Activo.HeaderText = "Activo";
            Activo.Name = "Activo";
            Activo.ReadOnly = true;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(26, 32, 40);
            MenuVertical.Controls.Add(dtpFechaContratacion);
            MenuVertical.Controls.Add(label8);
            MenuVertical.Controls.Add(dtpFechaNacimiento);
            MenuVertical.Controls.Add(label1);
            MenuVertical.Controls.Add(label7);
            MenuVertical.Controls.Add(cmbActivo);
            MenuVertical.Controls.Add(label6);
            MenuVertical.Controls.Add(txtSegundoApellido);
            MenuVertical.Controls.Add(label5);
            MenuVertical.Controls.Add(txtPrimerApellido);
            MenuVertical.Controls.Add(label4);
            MenuVertical.Controls.Add(txtNombre);
            MenuVertical.Controls.Add(label3);
            MenuVertical.Controls.Add(txtID);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Controls.Add(label2);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 35);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(220, 632);
            MenuVertical.TabIndex = 2;
            // 
            // dtpFechaContratacion
            // 
            dtpFechaContratacion.CalendarMonthBackground = Color.White;
            dtpFechaContratacion.Location = new Point(3, 493);
            dtpFechaContratacion.Name = "dtpFechaContratacion";
            dtpFechaContratacion.Size = new Size(214, 23);
            dtpFechaContratacion.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(12, 470);
            label8.Name = "label8";
            label8.Size = new Size(199, 20);
            label8.TabIndex = 18;
            label8.Text = "Ingrese la fecha de contratación";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CalendarMonthBackground = Color.White;
            dtpFechaNacimiento.Location = new Point(3, 436);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(214, 23);
            dtpFechaNacimiento.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 413);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 16;
            label1.Text = "Ingrese la fecha de nacimiento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 80, 200);
            label7.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(56, 139);
            label7.Name = "label7";
            label7.Size = new Size(115, 31);
            label7.TabIndex = 15;
            label7.Text = "Repartidor";
            // 
            // cmbActivo
            // 
            cmbActivo.BackColor = Color.FromArgb(26, 32, 40);
            cmbActivo.ForeColor = SystemColors.HighlightText;
            cmbActivo.Location = new Point(21, 552);
            cmbActivo.Name = "cmbActivo";
            cmbActivo.Size = new Size(154, 23);
            cmbActivo.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(12, 529);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 13;
            label6.Text = "Se encuentra activo";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.BackColor = Color.FromArgb(26, 32, 40);
            txtSegundoApellido.ForeColor = SystemColors.HighlightText;
            txtSegundoApellido.Location = new Point(21, 387);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(154, 23);
            txtSegundoApellido.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(12, 364);
            label5.Name = "label5";
            label5.Size = new Size(178, 20);
            label5.TabIndex = 11;
            label5.Text = "Ingrese el segundo apellido";
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.BackColor = Color.FromArgb(26, 32, 40);
            txtPrimerApellido.ForeColor = SystemColors.HighlightText;
            txtPrimerApellido.Location = new Point(21, 330);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(154, 23);
            txtPrimerApellido.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 307);
            label4.Name = "label4";
            label4.Size = new Size(163, 20);
            label4.TabIndex = 9;
            label4.Text = "Ingrese el primer apellido";
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
            BarraTitulo.Size = new Size(1013, 35);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(948, 3);
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
            btnExit.Location = new Point(982, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(28, 29);
            btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            btnExit.TabIndex = 0;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmRepartidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 667);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRepartidor";
            Text = "frmRepartidor";
            Load += frmRepartidor_Load;
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRepartidores).EndInit();
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
        private DataGridView dgvRepartidores;
        private Panel panel4;
        private Button btnLimpiar;
        private Panel panel3;
        private Button btnGuardar;
        private Panel MenuVertical;
        private DateTimePicker dtpFechaNacimiento;
        private Label label1;
        private Label label7;
        private ComboBox cmbActivo;
        private Label label6;
        private TextBox txtSegundoApellido;
        private Label label5;
        private TextBox txtPrimerApellido;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtID;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel BarraTitulo;
        private PictureBox btnMinimizar;
        private PictureBox btnExit;
        private DateTimePicker dtpFechaContratacion;
        private Label label8;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrimerApellido;
        private DataGridViewTextBoxColumn SegundoApellido;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn FechaContratacion;
        private DataGridViewTextBoxColumn Activo;
    }
}