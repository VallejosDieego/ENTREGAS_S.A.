namespace Presentacion
{
    partial class frmTipoArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoArticulo));
            panelContenedor = new Panel();
            dgvTipoArticulo = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnGuardar = new Button();
            MenuVertical = new Panel();
            label7 = new Label();
            txtDescripcion = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            BarraTitulo = new Panel();
            pictureBox2 = new PictureBox();
            btnExit = new PictureBox();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipoArticulo).BeginInit();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(46, 66, 82);
            panelContenedor.Controls.Add(dgvTipoArticulo);
            panelContenedor.Controls.Add(panel3);
            panelContenedor.Controls.Add(btnGuardar);
            panelContenedor.Controls.Add(MenuVertical);
            panelContenedor.Controls.Add(BarraTitulo);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(681, 561);
            panelContenedor.TabIndex = 4;
            // 
            // dgvTipoArticulo
            // 
            dgvTipoArticulo.BackgroundColor = Color.FromArgb(46, 66, 82);
            dgvTipoArticulo.BorderStyle = BorderStyle.None;
            dgvTipoArticulo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoArticulo.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Descripcion });
            dgvTipoArticulo.GridColor = Color.FromArgb(46, 66, 82);
            dgvTipoArticulo.Location = new Point(269, 202);
            dgvTipoArticulo.Name = "dgvTipoArticulo";
            dgvTipoArticulo.ReadOnly = true;
            dgvTipoArticulo.Size = new Size(344, 319);
            dgvTipoArticulo.TabIndex = 16;
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
            // Descripcion
            // 
            Descripcion.DataPropertyName = "Descripcion";
            Descripcion.HeaderText = "Descripción";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(322, 112);
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
            btnGuardar.Location = new Point(322, 112);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(220, 35);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(26, 32, 40);
            MenuVertical.Controls.Add(label7);
            MenuVertical.Controls.Add(txtDescripcion);
            MenuVertical.Controls.Add(label4);
            MenuVertical.Controls.Add(txtNombre);
            MenuVertical.Controls.Add(label3);
            MenuVertical.Controls.Add(txtID);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Controls.Add(label2);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 35);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(220, 526);
            MenuVertical.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 80, 200);
            label7.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(38, 141);
            label7.Name = "label7";
            label7.Size = new Size(137, 31);
            label7.TabIndex = 15;
            label7.Text = "Tipo Artículo";
            label7.Click += label7_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(26, 32, 40);
            txtDescripcion.ForeColor = SystemColors.Window;
            txtDescripcion.Location = new Point(21, 334);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(181, 180);
            txtDescripcion.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 311);
            label4.Name = "label4";
            label4.Size = new Size(210, 20);
            label4.TabIndex = 9;
            label4.Text = "Ingrese una pequeña descripción";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(26, 32, 40);
            txtNombre.ForeColor = SystemColors.Window;
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
            txtID.ForeColor = SystemColors.Window;
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
            BarraTitulo.Controls.Add(pictureBox2);
            BarraTitulo.Controls.Add(btnExit);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(0, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(681, 35);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(619, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnExit
            // 
            btnExit.Cursor = Cursors.Hand;
            btnExit.Image = Properties.Resources.cerrar;
            btnExit.Location = new Point(653, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(28, 29);
            btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            btnExit.TabIndex = 0;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmTipoArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 561);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTipoArticulo";
            Text = "TipoArticulo";
            Load += TipoArticulo_Load;
            panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTipoArticulo).EndInit();
            MenuVertical.ResumeLayout(false);
            MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private DataGridView dgvTipoArticulo;
        private Panel panel3;
        private Button btnGuardar;
        private Panel MenuVertical;
        private Label label7;
        private TextBox txtDescripcion;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtID;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel BarraTitulo;
        private PictureBox btnExit;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private PictureBox pictureBox2;
    }
}