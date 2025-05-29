namespace GUI
{
    partial class FormFotografo
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelCampos = new Panel();
            txtEspecialidad = new TextBox();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            btnVolver = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            lblEspecialidad = new Label();
            txtEmail = new TextBox();
            lblTelefono = new Label();
            lblEmail = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            panelBuscar = new Panel();
            btnVerFotografos = new Button();
            txtBuscar = new TextBox();
            label2 = new Label();
            dgv = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            panelCampos.SuspendLayout();
            panelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // panelCampos
            // 
            panelCampos.BackColor = Color.White;
            panelCampos.Controls.Add(txtEspecialidad);
            panelCampos.Controls.Add(txtTelefono);
            panelCampos.Controls.Add(txtApellido);
            panelCampos.Controls.Add(txtNombre);
            panelCampos.Controls.Add(label1);
            panelCampos.Controls.Add(btnVolver);
            panelCampos.Controls.Add(btnEliminar);
            panelCampos.Controls.Add(btnActualizar);
            panelCampos.Controls.Add(btnAgregar);
            panelCampos.Controls.Add(lblEspecialidad);
            panelCampos.Controls.Add(txtEmail);
            panelCampos.Controls.Add(lblTelefono);
            panelCampos.Controls.Add(lblEmail);
            panelCampos.Controls.Add(lblApellido);
            panelCampos.Controls.Add(lblNombre);
            panelCampos.Dock = DockStyle.Top;
            panelCampos.Location = new Point(0, 0);
            panelCampos.Name = "panelCampos";
            panelCampos.Size = new Size(1114, 308);
            panelCampos.TabIndex = 25;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Anchor = AnchorStyles.Top;
            txtEspecialidad.BackColor = Color.DimGray;
            txtEspecialidad.BorderStyle = BorderStyle.None;
            txtEspecialidad.ForeColor = Color.White;
            txtEspecialidad.Location = new Point(870, 96);
            txtEspecialidad.Margin = new Padding(3, 4, 3, 4);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(204, 20);
            txtEspecialidad.TabIndex = 38;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top;
            txtTelefono.BackColor = Color.DimGray;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.ForeColor = Color.White;
            txtTelefono.Location = new Point(502, 158);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(204, 20);
            txtTelefono.TabIndex = 37;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top;
            txtApellido.BackColor = Color.DimGray;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.ForeColor = Color.White;
            txtApellido.Location = new Point(147, 157);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(204, 20);
            txtApellido.TabIndex = 36;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top;
            txtNombre.BackColor = Color.DimGray;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(147, 86);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(204, 20);
            txtNombre.TabIndex = 35;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(451, 15);
            label1.Name = "label1";
            label1.Size = new Size(195, 46);
            label1.TabIndex = 34;
            label1.Text = "Fotógrafos";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.DimGray;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(12, 18);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 34);
            btnVolver.TabIndex = 33;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top;
            btnEliminar.BackColor = Color.DimGray;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(642, 219);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 44);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top;
            btnActualizar.BackColor = Color.DimGray;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(467, 219);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(131, 44);
            btnActualizar.TabIndex = 30;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top;
            btnAgregar.BackColor = Color.DimGray;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(292, 219);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 44);
            btnAgregar.TabIndex = 29;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.Anchor = AnchorStyles.Top;
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Segoe UI", 14.25F);
            lblEspecialidad.ForeColor = SystemColors.Desktop;
            lblEspecialidad.Location = new Point(710, 86);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(144, 32);
            lblEspecialidad.TabIndex = 27;
            lblEspecialidad.Text = "Especialidad";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.BackColor = Color.DimGray;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(468, 92);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 20);
            txtEmail.TabIndex = 24;
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.Top;
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 14.25F);
            lblTelefono.ForeColor = SystemColors.Desktop;
            lblTelefono.Location = new Point(391, 153);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(107, 32);
            lblTelefono.TabIndex = 22;
            lblTelefono.Text = "Teléfono";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F);
            lblEmail.ForeColor = SystemColors.Desktop;
            lblEmail.Location = new Point(391, 82);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(71, 32);
            lblEmail.TabIndex = 21;
            lblEmail.Text = "Email";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.Top;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 14.25F);
            lblApellido.ForeColor = SystemColors.Desktop;
            lblApellido.Location = new Point(41, 153);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(102, 32);
            lblApellido.TabIndex = 20;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F);
            lblNombre.ForeColor = SystemColors.Desktop;
            lblNombre.Location = new Point(40, 82);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(102, 32);
            lblNombre.TabIndex = 19;
            lblNombre.Text = "Nombre";
            // 
            // panelBuscar
            // 
            panelBuscar.BackColor = Color.White;
            panelBuscar.Controls.Add(btnVerFotografos);
            panelBuscar.Controls.Add(txtBuscar);
            panelBuscar.Controls.Add(label2);
            panelBuscar.Controls.Add(dgv);
            panelBuscar.Dock = DockStyle.Fill;
            panelBuscar.Location = new Point(0, 0);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(1114, 690);
            panelBuscar.TabIndex = 24;
            // 
            // btnVerFotografos
            // 
            btnVerFotografos.Anchor = AnchorStyles.Top;
            btnVerFotografos.BackColor = Color.DimGray;
            btnVerFotografos.FlatStyle = FlatStyle.Flat;
            btnVerFotografos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerFotografos.ForeColor = Color.White;
            btnVerFotografos.Location = new Point(333, 311);
            btnVerFotografos.Margin = new Padding(3, 4, 3, 4);
            btnVerFotografos.Name = "btnVerFotografos";
            btnVerFotografos.Size = new Size(142, 52);
            btnVerFotografos.TabIndex = 31;
            btnVerFotografos.Text = "Ver fotógrafos";
            btnVerFotografos.UseVisualStyleBackColor = false;
            btnVerFotografos.Click += btnVerFotografos_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.DimGray;
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(123, 328);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(204, 20);
            txtBuscar.TabIndex = 27;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(34, 316);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 26;
            label2.Text = "Buscar";
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.LightGray;
            dgv.Location = new Point(0, 370);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv.Size = new Size(1114, 317);
            dgv.TabIndex = 25;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // FormFotografo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 690);
            Controls.Add(panelCampos);
            Controls.Add(panelBuscar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormFotografo";
            Text = "FormFotografo";
            Load += FormFotografo_Load;
            panelCampos.ResumeLayout(false);
            panelCampos.PerformLayout();
            panelBuscar.ResumeLayout(false);
            panelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCampos;
        private TextBox txtEspecialidad;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label1;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private Label lblEspecialidad;
        private TextBox txtEmail;
        private Label lblTelefono;
        private Label lblEmail;
        private Label lblApellido;
        private Label lblNombre;
        private Panel panelBuscar;
        private Button btnVerFotografos;
        private TextBox txtBuscar;
        private Label label2;
        private DataGridView dgv;
        private System.Windows.Forms.Timer timer1;
    }
}