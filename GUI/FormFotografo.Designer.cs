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
            btnBuscar = new Button();
            btnConsultar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            txtEspecialidad = new TextBox();
            lblEspecialidad = new Label();
            txtId = new TextBox();
            lblId = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
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
            btnBuscar.Location = new Point(560, 320);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(115, 37);
            btnBuscar.TabIndex = 36;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.None;
            btnConsultar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = SystemColors.Desktop;
            btnConsultar.Location = new Point(560, 432);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(115, 37);
            btnConsultar.TabIndex = 35;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.Desktop;
            btnEliminar.Location = new Point(560, 259);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 37);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.None;
            btnActualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.Desktop;
            btnActualizar.Location = new Point(560, 202);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(115, 37);
            btnActualizar.TabIndex = 33;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.None;
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.Desktop;
            btnAgregar.Location = new Point(560, 142);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(115, 37);
            btnAgregar.TabIndex = 32;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Anchor = AnchorStyles.None;
            txtEspecialidad.ForeColor = SystemColors.Desktop;
            txtEspecialidad.Location = new Point(242, 444);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(179, 25);
            txtEspecialidad.TabIndex = 31;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.Anchor = AnchorStyles.None;
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Segoe UI", 14.25F);
            lblEspecialidad.ForeColor = SystemColors.Desktop;
            lblEspecialidad.Location = new Point(112, 441);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(117, 25);
            lblEspecialidad.TabIndex = 30;
            lblEspecialidad.Text = "Especialidad";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.None;
            txtId.ForeColor = SystemColors.Desktop;
            txtId.Location = new Point(242, 154);
            txtId.Name = "txtId";
            txtId.Size = new Size(179, 25);
            txtId.TabIndex = 29;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 14.25F);
            lblId.ForeColor = SystemColors.Desktop;
            lblId.Location = new Point(112, 151);
            lblId.Name = "lblId";
            lblId.Size = new Size(30, 25);
            lblId.TabIndex = 28;
            lblId.Text = "ID";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.ForeColor = SystemColors.Desktop;
            txtNombre.Location = new Point(242, 202);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(179, 25);
            txtNombre.TabIndex = 27;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.ForeColor = SystemColors.Desktop;
            txtApellido.Location = new Point(242, 259);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(179, 25);
            txtApellido.TabIndex = 26;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.ForeColor = SystemColors.Desktop;
            txtEmail.Location = new Point(242, 380);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 25);
            txtEmail.TabIndex = 25;
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.None;
            txtTelefono.ForeColor = SystemColors.Desktop;
            txtTelefono.Location = new Point(242, 320);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(179, 25);
            txtTelefono.TabIndex = 24;
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.None;
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 14.25F);
            lblTelefono.ForeColor = SystemColors.Desktop;
            lblTelefono.Location = new Point(112, 317);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(84, 25);
            lblTelefono.TabIndex = 23;
            lblTelefono.Text = "Teléfono";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F);
            lblEmail.ForeColor = SystemColors.Desktop;
            lblEmail.Location = new Point(112, 377);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email";
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 14.25F);
            lblApellido.ForeColor = SystemColors.Desktop;
            lblApellido.Location = new Point(113, 259);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(82, 25);
            lblApellido.TabIndex = 21;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F);
            lblNombre.ForeColor = SystemColors.Desktop;
            lblNombre.Location = new Point(112, 199);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 20;
            lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(304, 69);
            label1.Name = "label1";
            label1.Size = new Size(158, 37);
            label1.TabIndex = 19;
            label1.Text = "Fotógrafos";
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.Desktop;
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 29);
            btnVolver.TabIndex = 37;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormFotografo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 538);
            Controls.Add(btnVolver);
            Controls.Add(btnBuscar);
            Controls.Add(btnConsultar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(txtEspecialidad);
            Controls.Add(lblEspecialidad);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(lblEmail);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Name = "FormFotografo";
            Text = "FormFotografo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnConsultar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private TextBox txtEspecialidad;
        private Label lblEspecialidad;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private Label lblEmail;
        private Label lblApellido;
        private Label lblNombre;
        private Label label1;
        private Button btnVolver;
    }
}