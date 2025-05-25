namespace GUI
{
    partial class Principal
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
            panelMenu = new Panel();
            btnProductos = new Button();
            btnEquipoFotografico = new Button();
            btnFotografos = new Button();
            btnClientes = new Button();
            panel1 = new Panel();
            panelFormHijo = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(233, 241, 250);
            panelMenu.Controls.Add(btnProductos);
            panelMenu.Controls.Add(btnEquipoFotografico);
            panelMenu.Controls.Add(btnFotografos);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(219, 577);
            panelMenu.TabIndex = 0;
            // 
            // btnProductos
            // 
            btnProductos.Dock = DockStyle.Top;
            btnProductos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.Black;
            btnProductos.Location = new Point(0, 191);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(219, 37);
            btnProductos.TabIndex = 11;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click_1;
            // 
            // btnEquipoFotografico
            // 
            btnEquipoFotografico.Dock = DockStyle.Top;
            btnEquipoFotografico.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEquipoFotografico.ForeColor = Color.Black;
            btnEquipoFotografico.Location = new Point(0, 154);
            btnEquipoFotografico.Name = "btnEquipoFotografico";
            btnEquipoFotografico.Size = new Size(219, 37);
            btnEquipoFotografico.TabIndex = 7;
            btnEquipoFotografico.Text = "Equipo Fotográfico";
            btnEquipoFotografico.TextAlign = ContentAlignment.MiddleLeft;
            btnEquipoFotografico.UseVisualStyleBackColor = true;
            btnEquipoFotografico.Click += btnEquipoFotografico_Click;
            // 
            // btnFotografos
            // 
            btnFotografos.Dock = DockStyle.Top;
            btnFotografos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFotografos.ForeColor = Color.Black;
            btnFotografos.Location = new Point(0, 117);
            btnFotografos.Name = "btnFotografos";
            btnFotografos.Size = new Size(219, 37);
            btnFotografos.TabIndex = 5;
            btnFotografos.Text = "Fotografos";
            btnFotografos.TextAlign = ContentAlignment.MiddleLeft;
            btnFotografos.UseVisualStyleBackColor = true;
            btnFotografos.Click += btnFotografos_Click;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.Black;
            btnClientes.Location = new Point(0, 80);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(219, 37);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 80);
            panel1.TabIndex = 0;
            // 
            // panelFormHijo
            // 
            panelFormHijo.BackColor = SystemColors.AppWorkspace;
            panelFormHijo.Dock = DockStyle.Fill;
            panelFormHijo.ForeColor = Color.Transparent;
            panelFormHijo.Location = new Point(219, 0);
            panelFormHijo.Name = "panelFormHijo";
            panelFormHijo.Size = new Size(802, 577);
            panelFormHijo.TabIndex = 1;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 577);
            Controls.Add(panelFormHijo);
            Controls.Add(panelMenu);
            ForeColor = Color.Gainsboro;
            MinimumSize = new Size(833, 516);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += Principal_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private Button btnFotografos;
        private Button btnClientes;
        private Panel panelFormHijo;
        private Button btnEquipoFotografico;
        private Button btnProductos;
    }
}