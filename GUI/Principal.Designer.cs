namespace GUI
{
    partial class Orama
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
            panelMenu.BackColor = Color.DimGray;
            panelMenu.Controls.Add(btnProductos);
            panelMenu.Controls.Add(btnEquipoFotografico);
            panelMenu.Controls.Add(btnFotografos);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 729);
            panelMenu.TabIndex = 0;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.DimGray;
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(0, 226);
            btnProductos.Margin = new Padding(3, 4, 3, 4);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(220, 44);
            btnProductos.TabIndex = 11;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click_1;
            // 
            // btnEquipoFotografico
            // 
            btnEquipoFotografico.Dock = DockStyle.Top;
            btnEquipoFotografico.FlatStyle = FlatStyle.Flat;
            btnEquipoFotografico.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEquipoFotografico.ForeColor = Color.White;
            btnEquipoFotografico.Location = new Point(0, 182);
            btnEquipoFotografico.Margin = new Padding(3, 4, 3, 4);
            btnEquipoFotografico.Name = "btnEquipoFotografico";
            btnEquipoFotografico.Size = new Size(220, 44);
            btnEquipoFotografico.TabIndex = 7;
            btnEquipoFotografico.Text = "Equipo Fotográfico";
            btnEquipoFotografico.TextAlign = ContentAlignment.MiddleLeft;
            btnEquipoFotografico.UseVisualStyleBackColor = true;
            btnEquipoFotografico.Click += btnEquipoFotografico_Click;
            // 
            // btnFotografos
            // 
            btnFotografos.BackColor = Color.DimGray;
            btnFotografos.Dock = DockStyle.Top;
            btnFotografos.FlatStyle = FlatStyle.Flat;
            btnFotografos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFotografos.ForeColor = Color.White;
            btnFotografos.Location = new Point(0, 138);
            btnFotografos.Margin = new Padding(3, 4, 3, 4);
            btnFotografos.Name = "btnFotografos";
            btnFotografos.Size = new Size(220, 44);
            btnFotografos.TabIndex = 5;
            btnFotografos.Text = "Fotografos";
            btnFotografos.TextAlign = ContentAlignment.MiddleLeft;
            btnFotografos.UseVisualStyleBackColor = false;
            btnFotografos.Click += btnFotografos_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.DimGray;
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(0, 94);
            btnClientes.Margin = new Padding(3, 4, 3, 4);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(220, 44);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 94);
            panel1.TabIndex = 0;
            // 
            // panelFormHijo
            // 
            panelFormHijo.BackColor = Color.WhiteSmoke;
            panelFormHijo.Dock = DockStyle.Fill;
            panelFormHijo.ForeColor = Color.Transparent;
            panelFormHijo.Location = new Point(220, 0);
            panelFormHijo.Margin = new Padding(3, 4, 3, 4);
            panelFormHijo.Name = "panelFormHijo";
            panelFormHijo.Size = new Size(1130, 729);
            panelFormHijo.TabIndex = 1;
            // 
            // Orama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panelFormHijo);
            Controls.Add(panelMenu);
            ForeColor = Color.Gainsboro;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(950, 600);
            Name = "Orama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orama";
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