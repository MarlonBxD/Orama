namespace GUI
{
    partial class FormProducto
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
            txtStock = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            btnVolver = new Button();
            btnEliminar = new Button();
            btnActualizarNombre = new Button();
            btnAgregar = new Button();
            txtPrecio = new TextBox();
            lblTelefono = new Label();
            lblEmail = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            panelBuscar = new Panel();
            btnVerEquipos = new Button();
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
            panelCampos.Controls.Add(txtStock);
            panelCampos.Controls.Add(txtDescripcion);
            panelCampos.Controls.Add(txtNombre);
            panelCampos.Controls.Add(label1);
            panelCampos.Controls.Add(btnVolver);
            panelCampos.Controls.Add(btnEliminar);
            panelCampos.Controls.Add(btnActualizarNombre);
            panelCampos.Controls.Add(btnAgregar);
            panelCampos.Controls.Add(txtPrecio);
            panelCampos.Controls.Add(lblTelefono);
            panelCampos.Controls.Add(lblEmail);
            panelCampos.Controls.Add(lblApellido);
            panelCampos.Controls.Add(lblNombre);
            panelCampos.Dock = DockStyle.Top;
            panelCampos.Location = new Point(0, 0);
            panelCampos.Name = "panelCampos";
            panelCampos.Size = new Size(1114, 308);
            panelCampos.TabIndex = 29;
            // 
            // txtStock
            // 
            txtStock.Anchor = AnchorStyles.Top;
            txtStock.BackColor = Color.DimGray;
            txtStock.BorderStyle = BorderStyle.None;
            txtStock.ForeColor = Color.White;
            txtStock.Location = new Point(646, 172);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(204, 20);
            txtStock.TabIndex = 37;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top;
            txtDescripcion.BackColor = Color.DimGray;
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.ForeColor = Color.White;
            txtDescripcion.Location = new Point(291, 171);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(204, 20);
            txtDescripcion.TabIndex = 36;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top;
            txtNombre.BackColor = Color.DimGray;
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(291, 100);
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
            label1.Location = new Point(454, 15);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 34;
            label1.Text = "Productos";
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
            btnEliminar.Location = new Point(696, 228);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 44);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizarNombre
            // 
            btnActualizarNombre.Anchor = AnchorStyles.Top;
            btnActualizarNombre.BackColor = Color.DimGray;
            btnActualizarNombre.FlatStyle = FlatStyle.Flat;
            btnActualizarNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizarNombre.ForeColor = Color.White;
            btnActualizarNombre.Location = new Point(454, 228);
            btnActualizarNombre.Margin = new Padding(3, 4, 3, 4);
            btnActualizarNombre.Name = "btnActualizarNombre";
            btnActualizarNombre.Size = new Size(181, 44);
            btnActualizarNombre.TabIndex = 30;
            btnActualizarNombre.Text = "Actualizar Nombre";
            btnActualizarNombre.UseVisualStyleBackColor = false;
            btnActualizarNombre.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top;
            btnAgregar.BackColor = Color.DimGray;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(262, 228);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 44);
            btnAgregar.TabIndex = 29;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Top;
            txtPrecio.BackColor = Color.DimGray;
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.ForeColor = Color.White;
            txtPrecio.Location = new Point(646, 100);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(204, 20);
            txtPrecio.TabIndex = 24;
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.Top;
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 14.25F);
            lblTelefono.ForeColor = SystemColors.Desktop;
            lblTelefono.Location = new Point(535, 167);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 25);
            lblTelefono.TabIndex = 22;
            lblTelefono.Text = "Stock";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F);
            lblEmail.ForeColor = SystemColors.Desktop;
            lblEmail.Location = new Point(535, 96);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(65, 25);
            lblEmail.TabIndex = 21;
            lblEmail.Text = "Precio";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.Top;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 14.25F);
            lblApellido.ForeColor = SystemColors.Desktop;
            lblApellido.Location = new Point(174, 166);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(111, 25);
            lblApellido.TabIndex = 20;
            lblApellido.Text = "Descripción";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F);
            lblNombre.ForeColor = SystemColors.Desktop;
            lblNombre.Location = new Point(174, 95);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 19;
            lblNombre.Text = "Nombre";
            // 
            // panelBuscar
            // 
            panelBuscar.BackColor = Color.White;
            panelBuscar.Controls.Add(btnVerEquipos);
            panelBuscar.Controls.Add(txtBuscar);
            panelBuscar.Controls.Add(label2);
            panelBuscar.Controls.Add(dgv);
            panelBuscar.Dock = DockStyle.Fill;
            panelBuscar.Location = new Point(0, 0);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(1114, 690);
            panelBuscar.TabIndex = 28;
            // 
            // btnVerEquipos
            // 
            btnVerEquipos.Anchor = AnchorStyles.Top;
            btnVerEquipos.BackColor = Color.DimGray;
            btnVerEquipos.FlatStyle = FlatStyle.Flat;
            btnVerEquipos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerEquipos.ForeColor = Color.White;
            btnVerEquipos.Location = new Point(379, 311);
            btnVerEquipos.Margin = new Padding(3, 4, 3, 4);
            btnVerEquipos.Name = "btnVerEquipos";
            btnVerEquipos.Size = new Size(142, 34);
            btnVerEquipos.TabIndex = 31;
            btnVerEquipos.Text = "Ver productos";
            btnVerEquipos.UseVisualStyleBackColor = false;
            btnVerEquipos.Click += btnVerEquipos_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.DimGray;
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(108, 320);
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
            label2.Size = new Size(68, 25);
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
            dgv.Location = new Point(0, 352);
            dgv.Name = "dgv";
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv.Size = new Size(1114, 338);
            dgv.TabIndex = 25;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 690);
            Controls.Add(panelCampos);
            Controls.Add(panelBuscar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProducto";
            Text = "FormProducto";
            Load += FormProducto_Load;
            panelCampos.ResumeLayout(false);
            panelCampos.PerformLayout();
            panelBuscar.ResumeLayout(false);
            panelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCampos;
        private TextBox txtStock;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label label1;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnActualizarNombre;
        private Button btnAgregar;
        private TextBox txtPrecio;
        private Label lblTelefono;
        private Label lblEmail;
        private Label lblApellido;
        private Label lblNombre;
        private Panel panelBuscar;
        private Button btnVerEquipos;
        private TextBox txtBuscar;
        private Label label2;
        private DataGridView dgv;
        private System.Windows.Forms.Timer timer1;
    }
}