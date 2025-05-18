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
            panel1 = new Panel();
            btnGestionGeneral = new Button();
            pnlSubMenuGestionGeneral = new Panel();
            btnClientes = new Button();
            btnPaqueteFotografico = new Button();
            btnReservas = new Button();
            btnEventos = new Button();
            panelMenu.SuspendLayout();
            pnlSubMenuGestionGeneral.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(233, 241, 250);
            panelMenu.Controls.Add(pnlSubMenuGestionGeneral);
            panelMenu.Controls.Add(btnGestionGeneral);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 679);
            panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 0;
            // 
            // btnGestionGeneral
            // 
            btnGestionGeneral.BackColor = Color.White;
            btnGestionGeneral.Dock = DockStyle.Top;
            btnGestionGeneral.FlatAppearance.BorderSize = 0;
            btnGestionGeneral.FlatAppearance.MouseDownBackColor = Color.FromArgb(233, 241, 250);
            btnGestionGeneral.FlatStyle = FlatStyle.Flat;
            btnGestionGeneral.Location = new Point(0, 125);
            btnGestionGeneral.Name = "btnGestionGeneral";
            btnGestionGeneral.Padding = new Padding(10, 0, 0, 0);
            btnGestionGeneral.Size = new Size(250, 45);
            btnGestionGeneral.TabIndex = 1;
            btnGestionGeneral.Text = "Gestion General";
            btnGestionGeneral.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionGeneral.UseVisualStyleBackColor = false;
            // 
            // pnlSubMenuGestionGeneral
            // 
            pnlSubMenuGestionGeneral.BackColor = Color.White;
            pnlSubMenuGestionGeneral.Controls.Add(btnEventos);
            pnlSubMenuGestionGeneral.Controls.Add(btnReservas);
            pnlSubMenuGestionGeneral.Controls.Add(btnPaqueteFotografico);
            pnlSubMenuGestionGeneral.Controls.Add(btnClientes);
            pnlSubMenuGestionGeneral.Dock = DockStyle.Top;
            pnlSubMenuGestionGeneral.Location = new Point(0, 170);
            pnlSubMenuGestionGeneral.Name = "pnlSubMenuGestionGeneral";
            pnlSubMenuGestionGeneral.Size = new Size(250, 165);
            pnlSubMenuGestionGeneral.TabIndex = 2;
            // 
            // btnClientes
            // 
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(233, 241, 250);
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Location = new Point(0, 0);
            btnClientes.Name = "btnClientes";
            btnClientes.Padding = new Padding(35, 0, 0, 0);
            btnClientes.Size = new Size(250, 40);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnPaqueteFotografico
            // 
            btnPaqueteFotografico.Dock = DockStyle.Top;
            btnPaqueteFotografico.FlatAppearance.BorderSize = 0;
            btnPaqueteFotografico.FlatAppearance.MouseDownBackColor = Color.FromArgb(233, 241, 250);
            btnPaqueteFotografico.FlatStyle = FlatStyle.Flat;
            btnPaqueteFotografico.Location = new Point(0, 40);
            btnPaqueteFotografico.Name = "btnPaqueteFotografico";
            btnPaqueteFotografico.Padding = new Padding(35, 0, 0, 0);
            btnPaqueteFotografico.Size = new Size(250, 40);
            btnPaqueteFotografico.TabIndex = 2;
            btnPaqueteFotografico.Text = "Paquete Fotografico";
            btnPaqueteFotografico.TextAlign = ContentAlignment.MiddleLeft;
            btnPaqueteFotografico.UseVisualStyleBackColor = true;
            // 
            // btnReservas
            // 
            btnReservas.Dock = DockStyle.Top;
            btnReservas.FlatAppearance.BorderSize = 0;
            btnReservas.FlatAppearance.MouseDownBackColor = Color.FromArgb(233, 241, 250);
            btnReservas.FlatStyle = FlatStyle.Flat;
            btnReservas.Location = new Point(0, 80);
            btnReservas.Name = "btnReservas";
            btnReservas.Padding = new Padding(35, 0, 0, 0);
            btnReservas.Size = new Size(250, 40);
            btnReservas.TabIndex = 3;
            btnReservas.Text = "Reservas";
            btnReservas.TextAlign = ContentAlignment.MiddleLeft;
            btnReservas.UseVisualStyleBackColor = true;
            // 
            // btnEventos
            // 
            btnEventos.Dock = DockStyle.Top;
            btnEventos.FlatAppearance.BorderSize = 0;
            btnEventos.FlatAppearance.MouseDownBackColor = Color.FromArgb(233, 241, 250);
            btnEventos.FlatStyle = FlatStyle.Flat;
            btnEventos.Location = new Point(0, 120);
            btnEventos.Name = "btnEventos";
            btnEventos.Padding = new Padding(35, 0, 0, 0);
            btnEventos.Size = new Size(250, 40);
            btnEventos.TabIndex = 4;
            btnEventos.Text = "Eventos";
            btnEventos.TextAlign = ContentAlignment.MiddleLeft;
            btnEventos.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 679);
            Controls.Add(panelMenu);
            ForeColor = Color.Gainsboro;
            MinimumSize = new Size(950, 600);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += Principal_Load;
            panelMenu.ResumeLayout(false);
            pnlSubMenuGestionGeneral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private Panel pnlSubMenuGestionGeneral;
        private Button btnGestionGeneral;
        private Button btnEventos;
        private Button btnReservas;
        private Button btnPaqueteFotografico;
        private Button btnClientes;
    }
}