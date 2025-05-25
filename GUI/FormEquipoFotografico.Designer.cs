namespace GUI
{
    partial class FormEquipoFotografico
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
            txtCantidad = new TextBox();
            lblDireccion = new Label();
            txtId = new TextBox();
            lblId = new Label();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtEstado = new TextBox();
            txtTipo = new TextBox();
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
            btnBuscar.Location = new Point(546, 291);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(115, 37);
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
            btnConsultar.Location = new Point(546, 403);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(115, 37);
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
            btnEliminar.Location = new Point(546, 230);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 37);
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
            btnActualizar.Location = new Point(546, 173);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(115, 37);
            btnActualizar.TabIndex = 34;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.Desktop;
            btnAgregar.Location = new Point(546, 113);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(115, 37);
            btnAgregar.TabIndex = 33;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Anchor = AnchorStyles.None;
            txtCantidad.ForeColor = SystemColors.Desktop;
            txtCantidad.Location = new Point(195, 415);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(179, 25);
            txtCantidad.TabIndex = 32;
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.None;
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 14.25F);
            lblDireccion.ForeColor = SystemColors.Desktop;
            lblDireccion.Location = new Point(98, 412);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(88, 25);
            lblDireccion.TabIndex = 31;
            lblDireccion.Text = "Cantidad";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.ForeColor = SystemColors.Desktop;
            txtId.Location = new Point(195, 125);
            txtId.Name = "txtId";
            txtId.Size = new Size(179, 25);
            txtId.TabIndex = 30;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 14.25F);
            lblId.ForeColor = SystemColors.Desktop;
            lblId.Location = new Point(98, 122);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 25);
            lblId.TabIndex = 29;
            lblId.Text = "ID";
            // 
            // txtMarca
            // 
            txtMarca.Anchor = AnchorStyles.None;
            txtMarca.ForeColor = SystemColors.Desktop;
            txtMarca.Location = new Point(195, 173);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(179, 25);
            txtMarca.TabIndex = 28;
            // 
            // txtModelo
            // 
            txtModelo.Anchor = AnchorStyles.None;
            txtModelo.ForeColor = SystemColors.Desktop;
            txtModelo.Location = new Point(195, 230);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(179, 25);
            txtModelo.TabIndex = 27;
            // 
            // txtEstado
            // 
            txtEstado.Anchor = AnchorStyles.None;
            txtEstado.ForeColor = SystemColors.Desktop;
            txtEstado.Location = new Point(195, 351);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(179, 25);
            txtEstado.TabIndex = 26;
            // 
            // txtTipo
            // 
            txtTipo.Anchor = AnchorStyles.None;
            txtTipo.ForeColor = SystemColors.Desktop;
            txtTipo.Location = new Point(195, 291);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(179, 25);
            txtTipo.TabIndex = 25;
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.None;
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 14.25F);
            lblTelefono.ForeColor = SystemColors.Desktop;
            lblTelefono.Location = new Point(98, 288);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(49, 25);
            lblTelefono.TabIndex = 24;
            lblTelefono.Text = "Tipo";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F);
            lblEmail.ForeColor = SystemColors.Desktop;
            lblEmail.Location = new Point(98, 348);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(68, 25);
            lblEmail.TabIndex = 23;
            lblEmail.Text = "Estado";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 14.25F);
            lblApellido.ForeColor = SystemColors.Desktop;
            lblApellido.Location = new Point(99, 230);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(77, 25);
            lblApellido.TabIndex = 22;
            lblApellido.Text = "Modelo";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F);
            lblNombre.ForeColor = SystemColors.Desktop;
            lblNombre.Location = new Point(98, 170);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 25);
            lblNombre.TabIndex = 21;
            lblNombre.Text = "Marca";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(265, 40);
            label1.Name = "label1";
            label1.Size = new Size(263, 37);
            label1.TabIndex = 20;
            label1.Text = "Equipo Fotográfico";
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.Desktop;
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 29);
            btnVolver.TabIndex = 19;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormEquipoFotografico
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 538);
            Controls.Add(btnBuscar);
            Controls.Add(btnConsultar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(txtCantidad);
            Controls.Add(lblDireccion);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(txtMarca);
            Controls.Add(txtModelo);
            Controls.Add(txtEstado);
            Controls.Add(txtTipo);
            Controls.Add(lblTelefono);
            Controls.Add(lblEmail);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Controls.Add(btnVolver);
            Name = "FormEquipoFotografico";
            Text = "FormEquipoFotografico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnConsultar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private TextBox txtCantidad;
        private Label lblDireccion;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtEstado;
        private TextBox txtTipo;
        private Label lblTelefono;
        private Label lblEmail;
        private Label lblApellido;
        private Label lblNombre;
        private Label label1;
        private Button btnVolver;
    }
}