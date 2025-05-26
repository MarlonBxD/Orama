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
            btnBuscar = new Button();
            btnConsultar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            txtId = new TextBox();
            lblId = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            lblTelefono = new Label();
            lblEmail = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            label1 = new Label();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.Desktop;
            btnBuscar.Location = new Point(732, 371);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(201, 44);
            btnBuscar.TabIndex = 37;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.None;
            btnConsultar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = SystemColors.Desktop;
            btnConsultar.Location = new Point(732, 476);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(201, 44);
            btnConsultar.TabIndex = 36;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.Desktop;
            btnEliminar.Location = new Point(732, 300);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(201, 44);
            btnEliminar.TabIndex = 35;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.None;
            btnActualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.Desktop;
            btnActualizar.Location = new Point(732, 233);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(201, 44);
            btnActualizar.TabIndex = 34;
            btnActualizar.Text = "Actualizar nombre";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.Desktop;
            btnAgregar.Location = new Point(732, 162);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(201, 44);
            btnAgregar.TabIndex = 33;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.ForeColor = SystemColors.Desktop;
            txtId.Location = new Point(363, 187);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(204, 27);
            txtId.TabIndex = 30;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 14.25F);
            lblId.ForeColor = SystemColors.Desktop;
            lblId.Location = new Point(225, 183);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 25);
            lblId.TabIndex = 29;
            lblId.Text = "ID";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.ForeColor = SystemColors.Desktop;
            txtNombre.Location = new Point(363, 243);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(204, 27);
            txtNombre.TabIndex = 28;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.None;
            txtDescripcion.ForeColor = SystemColors.Desktop;
            txtDescripcion.Location = new Point(363, 310);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(204, 27);
            txtDescripcion.TabIndex = 27;
            // 
            // txtStock
            // 
            txtStock.Anchor = AnchorStyles.None;
            txtStock.ForeColor = SystemColors.Desktop;
            txtStock.Location = new Point(363, 453);
            txtStock.Margin = new Padding(3, 4, 3, 4);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(204, 27);
            txtStock.TabIndex = 26;
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.None;
            txtPrecio.ForeColor = SystemColors.Desktop;
            txtPrecio.Location = new Point(363, 382);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(204, 27);
            txtPrecio.TabIndex = 25;
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.None;
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 14.25F);
            lblTelefono.ForeColor = SystemColors.Desktop;
            lblTelefono.Location = new Point(225, 378);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(65, 25);
            lblTelefono.TabIndex = 24;
            lblTelefono.Text = "Precio";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F);
            lblEmail.ForeColor = SystemColors.Desktop;
            lblEmail.Location = new Point(225, 449);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(56, 25);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "Stock";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 14.25F);
            lblApellido.ForeColor = SystemColors.Desktop;
            lblApellido.Location = new Point(226, 310);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(111, 25);
            lblApellido.TabIndex = 22;
            lblApellido.Text = "Descripción";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F);
            lblNombre.ForeColor = SystemColors.Desktop;
            lblNombre.Location = new Point(225, 240);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 21;
            lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(463, 77);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 20;
            label1.Text = "Productos";
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.Desktop;
            btnVolver.Location = new Point(14, 14);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 34);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 690);
            Controls.Add(btnBuscar);
            Controls.Add(btnConsultar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(txtNombre);
            Controls.Add(txtDescripcion);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(lblTelefono);
            Controls.Add(lblEmail);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProducto";
            Text = "FormProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnConsultar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private Label lblTelefono;
        private Label lblEmail;
        private Label lblApellido;
        private Label lblNombre;
        private Label label1;
        private Button btnVolver;
    }
}