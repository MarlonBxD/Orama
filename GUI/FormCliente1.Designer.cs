namespace GUI
{
    partial class FormCliente1
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
            panelBuscar = new Panel();
            btnDespachos = new Button();
            btnReservas = new Button();
            btnPagos = new Button();
            txtBuscar = new TextBox();
            label2 = new Label();
            dgv = new DataGridView();
            panelCampos = new Panel();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            btnVolver = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            lblDireccion = new Label();
            txtEmail = new TextBox();
            lblTelefono = new Label();
            lblEmail = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panelCampos.SuspendLayout();
            SuspendLayout();
            // 
            // panelBuscar
            // 
            panelBuscar.BackColor = Color.White;
            panelBuscar.Controls.Add(btnDespachos);
            panelBuscar.Controls.Add(btnReservas);
            panelBuscar.Controls.Add(btnPagos);
            panelBuscar.Controls.Add(txtBuscar);
            panelBuscar.Controls.Add(label2);
            panelBuscar.Controls.Add(dgv);
            panelBuscar.Dock = DockStyle.Fill;
            panelBuscar.Location = new Point(0, 0);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(1114, 690);
            panelBuscar.TabIndex = 22;
            // 
            // btnDespachos
            // 
            btnDespachos.Anchor = AnchorStyles.Top;
            btnDespachos.BackColor = Color.DimGray;
            btnDespachos.FlatStyle = FlatStyle.Flat;
            btnDespachos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDespachos.ForeColor = Color.White;
            btnDespachos.Location = new Point(468, 314);
            btnDespachos.Margin = new Padding(3, 4, 3, 4);
            btnDespachos.Name = "btnDespachos";
            btnDespachos.Size = new Size(205, 47);
            btnDespachos.TabIndex = 30;
            btnDespachos.Text = "Despachos del cliente";
            btnDespachos.UseVisualStyleBackColor = false;
            btnDespachos.Click += btnDespachos_Click;
            // 
            // btnReservas
            // 
            btnReservas.Anchor = AnchorStyles.Top;
            btnReservas.BackColor = Color.DimGray;
            btnReservas.FlatStyle = FlatStyle.Flat;
            btnReservas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReservas.ForeColor = Color.White;
            btnReservas.Location = new Point(682, 314);
            btnReservas.Margin = new Padding(3, 4, 3, 4);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(205, 47);
            btnReservas.TabIndex = 29;
            btnReservas.Text = "Reservas del cliente";
            btnReservas.UseVisualStyleBackColor = false;
            btnReservas.Click += btnReservas_Click;
            // 
            // btnPagos
            // 
            btnPagos.Anchor = AnchorStyles.Top;
            btnPagos.BackColor = Color.DimGray;
            btnPagos.FlatStyle = FlatStyle.Flat;
            btnPagos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPagos.ForeColor = Color.White;
            btnPagos.Location = new Point(896, 314);
            btnPagos.Margin = new Padding(3, 4, 3, 4);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(205, 47);
            btnPagos.TabIndex = 28;
            btnPagos.Text = "Pagos del cliente";
            btnPagos.UseVisualStyleBackColor = false;
            btnPagos.Click += btnPagos_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.DimGray;
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(101, 326);
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
            label2.Location = new Point(12, 316);
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
            dgv.Location = new Point(0, 368);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv.Size = new Size(1114, 322);
            dgv.TabIndex = 25;
            dgv.CellClick += dgv_CellClick;
            // 
            // panelCampos
            // 
            panelCampos.BackColor = Color.White;
            panelCampos.Controls.Add(txtDireccion);
            panelCampos.Controls.Add(txtTelefono);
            panelCampos.Controls.Add(txtApellido);
            panelCampos.Controls.Add(txtNombre);
            panelCampos.Controls.Add(label1);
            panelCampos.Controls.Add(btnVolver);
            panelCampos.Controls.Add(btnEliminar);
            panelCampos.Controls.Add(btnActualizar);
            panelCampos.Controls.Add(btnAgregar);
            panelCampos.Controls.Add(lblDireccion);
            panelCampos.Controls.Add(txtEmail);
            panelCampos.Controls.Add(lblTelefono);
            panelCampos.Controls.Add(lblEmail);
            panelCampos.Controls.Add(lblApellido);
            panelCampos.Controls.Add(lblNombre);
            panelCampos.Dock = DockStyle.Top;
            panelCampos.Location = new Point(0, 0);
            panelCampos.Name = "panelCampos";
            panelCampos.Size = new Size(1114, 308);
            panelCampos.TabIndex = 23;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Top;
            txtDireccion.BackColor = Color.DimGray;
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.ForeColor = Color.White;
            txtDireccion.Location = new Point(879, 90);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(204, 20);
            txtDireccion.TabIndex = 38;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top;
            txtTelefono.BackColor = Color.DimGray;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.ForeColor = Color.White;
            txtTelefono.Location = new Point(512, 162);
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
            txtApellido.Location = new Point(157, 161);
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
            txtNombre.Location = new Point(157, 90);
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
            label1.Location = new Point(472, 15);
            label1.Name = "label1";
            label1.Size = new Size(146, 46);
            label1.TabIndex = 34;
            label1.Text = "Clientes";
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
            btnEliminar.Location = new Point(652, 223);
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
            btnActualizar.Location = new Point(477, 223);
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
            btnAgregar.Location = new Point(302, 223);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 44);
            btnAgregar.TabIndex = 29;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.Top;
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 14.25F);
            lblDireccion.ForeColor = SystemColors.Desktop;
            lblDireccion.Location = new Point(755, 85);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(114, 32);
            lblDireccion.TabIndex = 27;
            lblDireccion.Text = "Dirección";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.BackColor = Color.DimGray;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(512, 90);
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
            lblTelefono.Location = new Point(401, 157);
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
            lblEmail.Location = new Point(401, 86);
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
            lblApellido.Location = new Point(51, 157);
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
            lblNombre.Location = new Point(50, 86);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(102, 32);
            lblNombre.TabIndex = 19;
            lblNombre.Text = "Nombre";
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // FormCliente1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 690);
            Controls.Add(panelCampos);
            Controls.Add(panelBuscar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCliente1";
            Load += FormCliente1_Load;
            panelBuscar.ResumeLayout(false);
            panelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panelCampos.ResumeLayout(false);
            panelCampos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelBuscar;
        private Panel panelCampos;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private Label lblDireccion;
        private TextBox txtEmail;
        private Label lblTelefono;
        private Label lblEmail;
        private Label lblApellido;
        private Label lblNombre;
        private Label label1;
        private Button btnVolver;
        private Button btnDespachos;
        private Button btnReservas;
        private Button btnPagos;
        private TextBox txtBuscar;
        private Label label2;
        private DataGridView dgv;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private System.Windows.Forms.Timer timer1;
    }
}