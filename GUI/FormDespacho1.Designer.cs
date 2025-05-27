namespace GUI
{
    partial class FormDespacho1
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelCampos = new Panel();
            label3 = new Label();
            btnAsignarCliente = new Button();
            dtFecha = new DateTimePicker();
            btnAsignarMensajero = new Button();
            btnAsignarPaquete = new Button();
            txtNumPaquetes = new TextBox();
            txtEstado = new TextBox();
            label1 = new Label();
            btnVolver = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            lblApellido = new Label();
            lblNombre = new Label();
            panelBuscar = new Panel();
            chkFiltrarPorFecha = new CheckBox();
            dtHasta = new DateTimePicker();
            dtDesde = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            cbEstado = new ComboBox();
            btnVerDespachos = new Button();
            txtBuscar = new TextBox();
            label2 = new Label();
            dgv = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            panelCampos.SuspendLayout();
            panelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // panelCampos
            // 
            panelCampos.BackColor = Color.White;
            panelCampos.Controls.Add(label3);
            panelCampos.Controls.Add(btnAsignarCliente);
            panelCampos.Controls.Add(dtFecha);
            panelCampos.Controls.Add(btnAsignarMensajero);
            panelCampos.Controls.Add(btnAsignarPaquete);
            panelCampos.Controls.Add(txtNumPaquetes);
            panelCampos.Controls.Add(txtEstado);
            panelCampos.Controls.Add(label1);
            panelCampos.Controls.Add(btnVolver);
            panelCampos.Controls.Add(btnEliminar);
            panelCampos.Controls.Add(btnActualizar);
            panelCampos.Controls.Add(btnAgregar);
            panelCampos.Controls.Add(lblApellido);
            panelCampos.Controls.Add(lblNombre);
            panelCampos.Dock = DockStyle.Top;
            panelCampos.Location = new Point(0, 0);
            panelCampos.Name = "panelCampos";
            panelCampos.Size = new Size(1114, 308);
            panelCampos.TabIndex = 25;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(548, 90);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 39;
            label3.Text = "Fecha";
            // 
            // btnAsignarCliente
            // 
            btnAsignarCliente.Anchor = AnchorStyles.Top;
            btnAsignarCliente.BackColor = Color.DimGray;
            btnAsignarCliente.FlatStyle = FlatStyle.Flat;
            btnAsignarCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAsignarCliente.ForeColor = Color.White;
            btnAsignarCliente.Location = new Point(509, 155);
            btnAsignarCliente.Margin = new Padding(3, 4, 3, 4);
            btnAsignarCliente.Name = "btnAsignarCliente";
            btnAsignarCliente.Size = new Size(182, 34);
            btnAsignarCliente.TabIndex = 30;
            btnAsignarCliente.Text = "Asignar cliente";
            btnAsignarCliente.UseVisualStyleBackColor = false;
            btnAsignarCliente.Click += btnAsignarCliente_Click;
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(641, 88);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(270, 27);
            dtFecha.TabIndex = 38;
            // 
            // btnAsignarMensajero
            // 
            btnAsignarMensajero.Anchor = AnchorStyles.Top;
            btnAsignarMensajero.BackColor = Color.DimGray;
            btnAsignarMensajero.FlatStyle = FlatStyle.Flat;
            btnAsignarMensajero.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAsignarMensajero.ForeColor = Color.White;
            btnAsignarMensajero.Location = new Point(711, 155);
            btnAsignarMensajero.Margin = new Padding(3, 4, 3, 4);
            btnAsignarMensajero.Name = "btnAsignarMensajero";
            btnAsignarMensajero.Size = new Size(182, 34);
            btnAsignarMensajero.TabIndex = 29;
            btnAsignarMensajero.Text = "Asignar mensajero";
            btnAsignarMensajero.UseVisualStyleBackColor = false;
            btnAsignarMensajero.Click += btnAsignarMensajero_Click;
            // 
            // btnAsignarPaquete
            // 
            btnAsignarPaquete.Anchor = AnchorStyles.Top;
            btnAsignarPaquete.BackColor = Color.DimGray;
            btnAsignarPaquete.FlatStyle = FlatStyle.Flat;
            btnAsignarPaquete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAsignarPaquete.ForeColor = Color.White;
            btnAsignarPaquete.Location = new Point(913, 154);
            btnAsignarPaquete.Margin = new Padding(3, 4, 3, 4);
            btnAsignarPaquete.Name = "btnAsignarPaquete";
            btnAsignarPaquete.Size = new Size(182, 34);
            btnAsignarPaquete.TabIndex = 28;
            btnAsignarPaquete.Text = "Asignar paquete";
            btnAsignarPaquete.UseVisualStyleBackColor = false;
            btnAsignarPaquete.Click += btnAsignarPaquete_Click;
            // 
            // txtNumPaquetes
            // 
            txtNumPaquetes.Anchor = AnchorStyles.Top;
            txtNumPaquetes.BackColor = Color.DimGray;
            txtNumPaquetes.BorderStyle = BorderStyle.None;
            txtNumPaquetes.ForeColor = Color.White;
            txtNumPaquetes.Location = new Point(245, 165);
            txtNumPaquetes.Margin = new Padding(3, 4, 3, 4);
            txtNumPaquetes.Name = "txtNumPaquetes";
            txtNumPaquetes.Size = new Size(204, 20);
            txtNumPaquetes.TabIndex = 36;
            // 
            // txtEstado
            // 
            txtEstado.Anchor = AnchorStyles.Top;
            txtEstado.BackColor = Color.DimGray;
            txtEstado.BorderStyle = BorderStyle.None;
            txtEstado.ForeColor = Color.White;
            txtEstado.Location = new Point(245, 94);
            txtEstado.Margin = new Padding(3, 4, 3, 4);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(204, 20);
            txtEstado.TabIndex = 35;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(467, 15);
            label1.Name = "label1";
            label1.Size = new Size(142, 37);
            label1.TabIndex = 34;
            label1.Text = "Despacho";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.DimGray;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(12, 18);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(86, 34);
            btnVolver.TabIndex = 33;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top;
            btnEliminar.BackColor = Color.DimGray;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(650, 233);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 44);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top;
            btnActualizar.BackColor = Color.DimGray;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(475, 233);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(131, 44);
            btnActualizar.TabIndex = 30;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top;
            btnAgregar.BackColor = Color.DimGray;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(300, 233);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 44);
            btnAgregar.TabIndex = 29;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.Top;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 14.25F);
            lblApellido.ForeColor = SystemColors.Desktop;
            lblApellido.Location = new Point(41, 160);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(189, 25);
            lblApellido.TabIndex = 20;
            lblApellido.Text = "Numero de paquetes";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F);
            lblNombre.ForeColor = SystemColors.Desktop;
            lblNombre.Location = new Point(40, 89);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(68, 25);
            lblNombre.TabIndex = 19;
            lblNombre.Text = "Estado";
            // 
            // panelBuscar
            // 
            panelBuscar.BackColor = Color.White;
            panelBuscar.Controls.Add(chkFiltrarPorFecha);
            panelBuscar.Controls.Add(dtHasta);
            panelBuscar.Controls.Add(dtDesde);
            panelBuscar.Controls.Add(label5);
            panelBuscar.Controls.Add(label6);
            panelBuscar.Controls.Add(label4);
            panelBuscar.Controls.Add(cbEstado);
            panelBuscar.Controls.Add(btnVerDespachos);
            panelBuscar.Controls.Add(txtBuscar);
            panelBuscar.Controls.Add(label2);
            panelBuscar.Controls.Add(dgv);
            panelBuscar.Dock = DockStyle.Fill;
            panelBuscar.Location = new Point(0, 0);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(1114, 690);
            panelBuscar.TabIndex = 24;
            panelBuscar.Paint += panelBuscar_Paint;
            // 
            // chkFiltrarPorFecha
            // 
            chkFiltrarPorFecha.AutoSize = true;
            chkFiltrarPorFecha.Location = new Point(12, 383);
            chkFiltrarPorFecha.Name = "chkFiltrarPorFecha";
            chkFiltrarPorFecha.Size = new Size(133, 24);
            chkFiltrarPorFecha.TabIndex = 38;
            chkFiltrarPorFecha.Text = "Filtrar por fecha";
            chkFiltrarPorFecha.UseVisualStyleBackColor = true;
            // 
            // dtHasta
            // 
            dtHasta.Anchor = AnchorStyles.None;
            dtHasta.Format = DateTimePickerFormat.Short;
            dtHasta.Location = new Point(459, 382);
            dtHasta.Name = "dtHasta";
            dtHasta.Size = new Size(250, 27);
            dtHasta.TabIndex = 37;
            // 
            // dtDesde
            // 
            dtDesde.Anchor = AnchorStyles.None;
            dtDesde.Format = DateTimePickerFormat.Short;
            dtDesde.Location = new Point(177, 382);
            dtDesde.Name = "dtDesde";
            dtDesde.Size = new Size(250, 27);
            dtDesde.TabIndex = 36;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(465, 357);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 35;
            label5.Text = "Fecha hasta";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(177, 357);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 34;
            label6.Text = "Fechas desde";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.ForeColor = SystemColors.Desktop;
            label4.Location = new Point(743, 383);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 33;
            label4.Text = "Estado";
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(817, 381);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(265, 28);
            cbEstado.TabIndex = 32;
            // 
            // btnVerDespachos
            // 
            btnVerDespachos.Anchor = AnchorStyles.Top;
            btnVerDespachos.BackColor = Color.DimGray;
            btnVerDespachos.FlatStyle = FlatStyle.Flat;
            btnVerDespachos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerDespachos.ForeColor = Color.White;
            btnVerDespachos.Location = new Point(699, 315);
            btnVerDespachos.Margin = new Padding(3, 4, 3, 4);
            btnVerDespachos.Name = "btnVerDespachos";
            btnVerDespachos.Size = new Size(152, 34);
            btnVerDespachos.TabIndex = 31;
            btnVerDespachos.Text = "Ver despachos";
            btnVerDespachos.UseVisualStyleBackColor = false;
            btnVerDespachos.Click += btnVerDespachos_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.DimGray;
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(413, 324);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(204, 20);
            txtBuscar.TabIndex = 27;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(232, 320);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 26;
            label2.Text = "Buscar por cliente";
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.LightGray;
            dgv.Location = new Point(0, 415);
            dgv.Name = "dgv";
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv.Size = new Size(1114, 275);
            dgv.TabIndex = 25;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // FormDespacho1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 690);
            Controls.Add(panelCampos);
            Controls.Add(panelBuscar);
            Name = "FormDespacho1";
            Text = "FormDespacho1";
            Load += FormDespacho1_Load;
            panelCampos.ResumeLayout(false);
            panelCampos.PerformLayout();
            panelBuscar.ResumeLayout(false);
            panelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCampos;
        private TextBox txtNumPaquetes;
        private TextBox txtEstado;
        private Label label1;
        private Button btnVolver;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private Label lblApellido;
        private Label lblNombre;
        private Panel panelBuscar;
        private Button btnVerDespachos;
        private Button btnAsignarCliente;
        private Button btnAsignarMensajero;
        private Button btnAsignarPaquete;
        private TextBox txtBuscar;
        private Label label2;
        private DataGridView dgv;
        private Label label3;
        private DateTimePicker dtFecha;
        private System.Windows.Forms.Timer timer1;
        private ComboBox cbEstado;
        private Label label4;
        private DateTimePicker dtHasta;
        private DateTimePicker dtDesde;
        private Label label5;
        private Label label6;
        private CheckBox chkFiltrarPorFecha;
    }
}