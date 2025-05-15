namespace GUI
{
    partial class FormDespacho
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpFecha = new DateTimePicker();
            label5 = new Label();
            numup = new NumericUpDown();
            cbClientes = new ComboBox();
            cbMensajeros = new ComboBox();
            btnGuardar = new Button();
            cbEstados = new ComboBox();
            textDireccion = new TextBox();
            label7 = new Label();
            textTelefono = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numup).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 67);
            label1.Name = "label1";
            label1.Size = new Size(165, 22);
            label1.TabIndex = 0;
            label1.Text = "Fecha Despacho:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 158);
            label2.Name = "label2";
            label2.Size = new Size(73, 22);
            label2.TabIndex = 1;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 356);
            label3.Name = "label3";
            label3.Size = new Size(106, 22);
            label3.TabIndex = 2;
            label3.Text = "Mensajero";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(343, 67);
            label4.Name = "label4";
            label4.Size = new Size(199, 22);
            label4.TabIndex = 3;
            label4.Text = "Numero de Paquetes";
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.None;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(40, 105);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(214, 27);
            dtpFecha.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 467);
            label5.Name = "label5";
            label5.Size = new Size(77, 22);
            label5.TabIndex = 5;
            label5.Text = "Estado:";
            // 
            // numup
            // 
            numup.Anchor = AnchorStyles.None;
            numup.Location = new Point(343, 105);
            numup.Name = "numup";
            numup.Size = new Size(253, 27);
            numup.TabIndex = 10;
            // 
            // cbClientes
            // 
            cbClientes.Anchor = AnchorStyles.None;
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(40, 195);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(556, 28);
            cbClientes.TabIndex = 13;
            // 
            // cbMensajeros
            // 
            cbMensajeros.Anchor = AnchorStyles.None;
            cbMensajeros.FormattingEnabled = true;
            cbMensajeros.Location = new Point(40, 398);
            cbMensajeros.Name = "cbMensajeros";
            cbMensajeros.Size = new Size(556, 28);
            cbMensajeros.TabIndex = 14;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.Location = new Point(175, 566);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(253, 57);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "AGREGAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbEstados
            // 
            cbEstados.Anchor = AnchorStyles.None;
            cbEstados.FormattingEnabled = true;
            cbEstados.Location = new Point(40, 506);
            cbEstados.Name = "cbEstados";
            cbEstados.Size = new Size(556, 28);
            cbEstados.TabIndex = 19;
            // 
            // textDireccion
            // 
            textDireccion.Anchor = AnchorStyles.None;
            textDireccion.Location = new Point(343, 294);
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(253, 27);
            textDireccion.TabIndex = 18;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(343, 256);
            label7.Name = "label7";
            label7.Size = new Size(96, 22);
            label7.TabIndex = 17;
            label7.Text = "Dirección";
            // 
            // textTelefono
            // 
            textTelefono.Anchor = AnchorStyles.None;
            textTelefono.Location = new Point(40, 294);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(259, 27);
            textTelefono.TabIndex = 16;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(40, 256);
            label6.Name = "label6";
            label6.Size = new Size(89, 22);
            label6.TabIndex = 15;
            label6.Text = "Telefono";
            // 
            // FormDespacho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 644);
            Controls.Add(btnGuardar);
            Controls.Add(cbEstados);
            Controls.Add(label4);
            Controls.Add(textDireccion);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(textTelefono);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(dtpFecha);
            Controls.Add(cbMensajeros);
            Controls.Add(label5);
            Controls.Add(cbClientes);
            Controls.Add(numup);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDespacho";
            Text = "FormDespacho";
            ((System.ComponentModel.ISupportInitialize)numup).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpFecha;
        private Label label5;
        private NumericUpDown numup;
        private ComboBox cbClientes;
        private ComboBox cbMensajeros;
        private Button btnGuardar;
        private ComboBox cbEstados;
        private TextBox textDireccion;
        private Label label7;
        private TextBox textTelefono;
        private Label label6;
    }
}