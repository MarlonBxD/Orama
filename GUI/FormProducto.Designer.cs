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
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(546, 291);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(176, 37);
            btnBuscar.TabIndex = 37;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnConsultar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultar.Location = new Point(546, 380);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(176, 37);
            btnConsultar.TabIndex = 36;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(546, 230);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(176, 37);
            btnEliminar.TabIndex = 35;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnActualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(546, 173);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(176, 37);
            btnActualizar.TabIndex = 34;
            btnActualizar.Text = "Actualizar nombre";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(546, 113);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(176, 37);
            btnAgregar.TabIndex = 33;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtId.Location = new Point(223, 134);
            txtId.Name = "txtId";
            txtId.Size = new Size(179, 25);
            txtId.TabIndex = 30;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 14.25F);
            lblId.Location = new Point(102, 131);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 25);
            lblId.TabIndex = 29;
            lblId.Text = "ID";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Location = new Point(223, 182);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(179, 25);
            txtNombre.TabIndex = 28;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescripcion.Location = new Point(223, 239);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(179, 25);
            txtDescripcion.TabIndex = 27;
            // 
            // txtStock
            // 
            txtStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtStock.Location = new Point(223, 360);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(179, 25);
            txtStock.TabIndex = 26;
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPrecio.Location = new Point(223, 300);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(179, 25);
            txtPrecio.TabIndex = 25;
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 14.25F);
            lblTelefono.Location = new Point(102, 297);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(65, 25);
            lblTelefono.TabIndex = 24;
            lblTelefono.Text = "Precio";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F);
            lblEmail.Location = new Point(102, 357);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(56, 25);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "Stock";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 14.25F);
            lblApellido.Location = new Point(103, 239);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(111, 25);
            lblApellido.TabIndex = 22;
            lblApellido.Text = "Descripción";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F);
            lblNombre.Location = new Point(102, 179);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 21;
            lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 41);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 20;
            label1.Text = "Productos";
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 29);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 538);
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