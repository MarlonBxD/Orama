namespace GUI
{
    partial class FormMensajero
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgv = new DataGridView();
            label2 = new Label();
            txtBuscar = new TextBox();
            panelBuscar = new Panel();
            btnVerMensajeros = new Button();
            lblNombre = new Label();
            lblApellido = new Label();
            lblEmail = new Label();
            lblTelefono = new Label();
            txtEmail = new TextBox();
            lblDireccion = new Label();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnVolver = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            panelCampos = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panelBuscar.SuspendLayout();
            panelCampos.SuspendLayout();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.LightGray;
            dgv.Location = new Point(0, 352);
            dgv.Name = "dgv";
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv.Size = new Size(1111, 338);
            dgv.TabIndex = 25;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(12, 316);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 26;
            label2.Text = "Buscar";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.DimGray;
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(86, 320);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(204, 20);
            txtBuscar.TabIndex = 27;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // panelBuscar
            // 
            panelBuscar.BackColor = Color.White;
            panelBuscar.Controls.Add(btnVerMensajeros);
            panelBuscar.Controls.Add(txtBuscar);
            panelBuscar.Controls.Add(label2);
            panelBuscar.Controls.Add(dgv);
            panelBuscar.Dock = DockStyle.Fill;
            panelBuscar.Location = new Point(0, 0);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(1114, 690);
            panelBuscar.TabIndex = 24;
            // 
            // btnVerMensajeros
            // 
            btnVerMensajeros.Anchor = AnchorStyles.Top;
            btnVerMensajeros.BackColor = Color.DimGray;
            btnVerMensajeros.FlatStyle = FlatStyle.Flat;
            btnVerMensajeros.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerMensajeros.ForeColor = Color.White;
            btnVerMensajeros.Location = new Point(321, 311);
            btnVerMensajeros.Margin = new Padding(3, 4, 3, 4);
            btnVerMensajeros.Name = "btnVerMensajeros";
            btnVerMensajeros.Size = new Size(151, 34);
            btnVerMensajeros.TabIndex = 31;
            btnVerMensajeros.Text = "Ver mensajeros";
            btnVerMensajeros.UseVisualStyleBackColor = false;
            btnVerMensajeros.Click += btnVerClientes_Click;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F);
            lblNombre.ForeColor = SystemColors.Desktop;
            lblNombre.Location = new Point(54, 89);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 19;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.Top;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 14.25F);
            lblApellido.ForeColor = SystemColors.Desktop;
            lblApellido.Location = new Point(55, 160);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(82, 25);
            lblApellido.TabIndex = 20;
            lblApellido.Text = "Apellido";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F);
            lblEmail.ForeColor = SystemColors.Desktop;
            lblEmail.Location = new Point(405, 89);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 21;
            lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.Top;
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 14.25F);
            lblTelefono.ForeColor = SystemColors.Desktop;
            lblTelefono.Location = new Point(405, 160);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(84, 25);
            lblTelefono.TabIndex = 22;
            lblTelefono.Text = "Teléfono";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.BackColor = Color.DimGray;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(516, 93);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 20);
            txtEmail.TabIndex = 24;
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.Top;
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 14.25F);
            lblDireccion.ForeColor = SystemColors.Desktop;
            lblDireccion.Location = new Point(759, 88);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(92, 25);
            lblDireccion.TabIndex = 27;
            lblDireccion.Text = "Dirección";
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top;
            btnAgregar.BackColor = Color.DimGray;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(306, 226);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 44);
            btnAgregar.TabIndex = 29;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top;
            btnActualizar.BackColor = Color.DimGray;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(481, 226);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(131, 44);
            btnActualizar.TabIndex = 30;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top;
            btnEliminar.BackColor = Color.DimGray;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(656, 226);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 44);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(461, 18);
            label1.Name = "label1";
            label1.Size = new Size(164, 37);
            label1.TabIndex = 34;
            label1.Text = "Mensajeros";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top;
            txtNombre.BackColor = Color.DimGray;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(161, 93);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(204, 20);
            txtNombre.TabIndex = 35;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.Top;
            txtApellido.BackColor = Color.DimGray;
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.ForeColor = Color.White;
            txtApellido.Location = new Point(161, 164);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(204, 20);
            txtApellido.TabIndex = 36;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Top;
            txtTelefono.BackColor = Color.DimGray;
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.ForeColor = Color.White;
            txtTelefono.Location = new Point(516, 165);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(204, 20);
            txtTelefono.TabIndex = 37;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Top;
            txtDireccion.BackColor = Color.DimGray;
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.ForeColor = Color.White;
            txtDireccion.Location = new Point(883, 93);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(204, 20);
            txtDireccion.TabIndex = 38;
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
            panelCampos.TabIndex = 25;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // FormMensajero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 690);
            Controls.Add(panelCampos);
            Controls.Add(panelBuscar);
            Name = "FormMensajero";
            Text = "FormMensajero";
            Load += FormMensajero_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panelBuscar.ResumeLayout(false);
            panelBuscar.PerformLayout();
            panelCampos.ResumeLayout(false);
            panelCampos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv;
        private Label label2;
        private TextBox txtBuscar;
        private Panel panelBuscar;
        private Button btnVerMensajeros;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblEmail;
        private Label lblTelefono;
        private TextBox txtEmail;
        private Label lblDireccion;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnVolver;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Panel panelCampos;
        private System.Windows.Forms.Timer timer1;
    }
}