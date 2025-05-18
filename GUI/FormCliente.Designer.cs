namespace GUI
{
    partial class FormCliente
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
            lblasunto = new Label();
            txtTelefono = new TextBox();
            label1 = new Label();
            txtMensaje = new TextBox();
            btnEnviar = new Button();
            label2 = new Label();
            txtDestinatario = new TextBox();
            SuspendLayout();
            // 
            // lblasunto
            // 
            lblasunto.AutoSize = true;
            lblasunto.Location = new Point(188, 158);
            lblasunto.Name = "lblasunto";
            lblasunto.Size = new Size(53, 20);
            lblasunto.TabIndex = 0;
            lblasunto.Text = "asunto";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(264, 155);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(191, 27);
            txtTelefono.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 202);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 2;
            label1.Text = "cuerpo";
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(264, 202);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(191, 27);
            txtMensaje.TabIndex = 3;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(160, 252);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(198, 83);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 121);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 5;
            label2.Text = "Destinatario";
            // 
            // txtDestinatario
            // 
            txtDestinatario.Location = new Point(264, 114);
            txtDestinatario.Name = "txtDestinatario";
            txtDestinatario.Size = new Size(191, 27);
            txtDestinatario.TabIndex = 6;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 718);
            Controls.Add(txtDestinatario);
            Controls.Add(label2);
            Controls.Add(btnEnviar);
            Controls.Add(txtMensaje);
            Controls.Add(label1);
            Controls.Add(txtTelefono);
            Controls.Add(lblasunto);
            Name = "FormCliente";
            Text = "FormCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblasunto;
        private TextBox txtTelefono;
        private Label label1;
        private TextBox txtMensaje;
        private Button btnEnviar;
        private Label label2;
        private TextBox txtDestinatario;
    }
}