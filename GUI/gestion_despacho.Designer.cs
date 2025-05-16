namespace GUI
{
    partial class gestion_despachos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvDespachos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            No_Paquetes = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnFiltrar = new Button();
            btnLimpiar = new Button();
            dtHasta = new DateTimePicker();
            dtDesde = new DateTimePicker();
            txtMensajeroCliente = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnNuevo = new Button();
            btnElimiar = new Button();
            btnEditar = new Button();
            cbEstados = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDespachos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDespachos
            // 
            dgvDespachos.Anchor = AnchorStyles.None;
            dgvDespachos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDespachos.Columns.AddRange(new DataGridViewColumn[] { ID, Fecha, Estado, Cliente, Telefono, Direccion, Column1, No_Paquetes });
            dgvDespachos.Location = new Point(9, 407);
            dgvDespachos.Name = "dgvDespachos";
            dgvDespachos.RowHeadersWidth = 51;
            dgvDespachos.Size = new Size(1195, 265);
            dgvDespachos.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 50;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 160;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 125;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.Width = 160;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.Width = 150;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.Width = 210;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mensajero";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 160;
            // 
            // No_Paquetes
            // 
            No_Paquetes.HeaderText = "No_Paquetes";
            No_Paquetes.MinimumWidth = 6;
            No_Paquetes.Name = "No_Paquetes";
            No_Paquetes.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(cbEstados);
            groupBox1.Controls.Add(btnFiltrar);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(dtHasta);
            groupBox1.Controls.Add(dtDesde);
            groupBox1.Controls.Add(txtMensajeroCliente);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold);
            groupBox1.Location = new Point(32, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1161, 226);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros de búsqueda";
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = SystemColors.ActiveCaptionText;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold);
            btnFiltrar.ForeColor = SystemColors.Control;
            btnFiltrar.Location = new Point(979, 148);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(126, 46);
            btnFiltrar.TabIndex = 10;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.None;
            btnLimpiar.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold);
            btnLimpiar.Location = new Point(821, 148);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(126, 46);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dtHasta
            // 
            dtHasta.Anchor = AnchorStyles.None;
            dtHasta.Format = DateTimePickerFormat.Short;
            dtHasta.Location = new Point(892, 84);
            dtHasta.Name = "dtHasta";
            dtHasta.Size = new Size(250, 31);
            dtHasta.TabIndex = 8;
            // 
            // dtDesde
            // 
            dtDesde.Anchor = AnchorStyles.None;
            dtDesde.Format = DateTimePickerFormat.Short;
            dtDesde.Location = new Point(604, 84);
            dtDesde.Name = "dtDesde";
            dtDesde.Size = new Size(250, 31);
            dtDesde.TabIndex = 7;
            // 
            // txtMensajeroCliente
            // 
            txtMensajeroCliente.Anchor = AnchorStyles.None;
            txtMensajeroCliente.Location = new Point(19, 84);
            txtMensajeroCliente.Name = "txtMensajeroCliente";
            txtMensajeroCliente.Size = new Size(250, 31);
            txtMensajeroCliente.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(892, 59);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 3;
            label4.Text = "Fecha hasta";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(604, 59);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 2;
            label3.Text = "Fechas desde";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(307, 59);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 1;
            label2.Text = "Estados";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(19, 59);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 0;
            label1.Text = "Cliente / Mensajero";
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.None;
            btnNuevo.BackColor = SystemColors.ActiveCaptionText;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold);
            btnNuevo.ForeColor = SystemColors.Control;
            btnNuevo.Location = new Point(19, 339);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(137, 52);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnElimiar
            // 
            btnElimiar.Anchor = AnchorStyles.None;
            btnElimiar.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnElimiar.Location = new Point(363, 339);
            btnElimiar.Name = "btnElimiar";
            btnElimiar.Size = new Size(137, 52);
            btnElimiar.TabIndex = 3;
            btnElimiar.Text = "Elimiar";
            btnElimiar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.None;
            btnEditar.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold);
            btnEditar.Location = new Point(196, 339);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(137, 52);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // cbEstados
            // 
            cbEstados.FormattingEnabled = true;
            cbEstados.Location = new Point(307, 82);
            cbEstados.Name = "cbEstados";
            cbEstados.Size = new Size(265, 33);
            cbEstados.TabIndex = 11;
            // 
            // gestion_despachos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 708);
            Controls.Add(btnEditar);
            Controls.Add(btnElimiar);
            Controls.Add(btnNuevo);
            Controls.Add(groupBox1);
            Controls.Add(dgvDespachos);
            Name = "gestion_despachos";
            Text = "Gestion de Despachos";
            ((System.ComponentModel.ISupportInitialize)dgvDespachos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDespachos;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn No_Paquetes;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtHasta;
        private DateTimePicker dtDesde;
        private TextBox txtMensajeroCliente;
        private Label label4;
        private Button btnFiltrar;
        private Button btnLimpiar;
        private Button btnNuevo;
        private Button btnElimiar;
        private Button btnEditar;
        private ComboBox cbEstados;
    }
}
