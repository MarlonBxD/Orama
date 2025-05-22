namespace GUI
{
    partial class FormClienteConsulta
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
            dgvConsulta = new DataGridView();
            btnVolver = new Button();
            btnGetAll = new Button();
            btnPagos = new Button();
            label1 = new Label();
            txtId = new TextBox();
            btnReservas = new Button();
            btnDespachos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // dgvConsulta
            // 
            dgvConsulta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Location = new Point(2, 237);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.Size = new Size(781, 298);
            dgvConsulta.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(12, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(76, 27);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnGetAll
            // 
            btnGetAll.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGetAll.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGetAll.Location = new Point(8, 125);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(187, 91);
            btnGetAll.TabIndex = 2;
            btnGetAll.Text = "Consultar todos";
            btnGetAll.UseVisualStyleBackColor = true;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // btnPagos
            // 
            btnPagos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPagos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPagos.Location = new Point(201, 125);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(187, 91);
            btnPagos.TabIndex = 3;
            btnPagos.Text = "Consultar Pagos del cliente";
            btnPagos.UseVisualStyleBackColor = true;
            btnPagos.Click += btnPagos_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 61);
            label1.Name = "label1";
            label1.Size = new Size(104, 30);
            label1.TabIndex = 4;
            label1.Text = "ID Cliente";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtId.Location = new Point(334, 68);
            txtId.Name = "txtId";
            txtId.Size = new Size(207, 25);
            txtId.TabIndex = 5;
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // btnReservas
            // 
            btnReservas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnReservas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReservas.Location = new Point(394, 125);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(187, 91);
            btnReservas.TabIndex = 6;
            btnReservas.Text = "Consular reservas del cliente";
            btnReservas.UseVisualStyleBackColor = true;
            btnReservas.Click += btnReservas_Click;
            // 
            // btnDespachos
            // 
            btnDespachos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDespachos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDespachos.Location = new Point(587, 125);
            btnDespachos.Name = "btnDespachos";
            btnDespachos.Size = new Size(187, 91);
            btnDespachos.TabIndex = 7;
            btnDespachos.Text = "Consular despachos del cliente";
            btnDespachos.UseVisualStyleBackColor = true;
            btnDespachos.Click += btnDespachos_Click;
            // 
            // FormClienteConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 538);
            Controls.Add(btnDespachos);
            Controls.Add(btnReservas);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnPagos);
            Controls.Add(btnGetAll);
            Controls.Add(btnVolver);
            Controls.Add(dgvConsulta);
            Name = "FormClienteConsulta";
            Text = "FormClienteConsulta";
            Load += FormClienteConsulta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvConsulta;
        private Button btnVolver;
        private Button btnGetAll;
        private Button btnPagos;
        private Label label1;
        private TextBox txtId;
        private Button btnReservas;
        private Button btnDespachos;
    }
}