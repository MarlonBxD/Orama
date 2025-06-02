namespace GUI
{
    partial class FormSeleccionarPaquete
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgv = new DataGridView();
            panelBuscar = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnVerClientes = new Button();
            btnSeleccionar = new Button();
            txtBuscar = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.LightGray;
            dgv.Location = new Point(-1, 49);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv.Size = new Size(784, 361);
            dgv.TabIndex = 33;
            // 
            // panelBuscar
            // 
            panelBuscar.BackColor = Color.White;
            panelBuscar.Controls.Add(label1);
            panelBuscar.Controls.Add(dataGridView1);
            panelBuscar.Controls.Add(btnVerClientes);
            panelBuscar.Controls.Add(btnSeleccionar);
            panelBuscar.Controls.Add(txtBuscar);
            panelBuscar.Dock = DockStyle.Fill;
            panelBuscar.Location = new Point(0, 0);
            panelBuscar.Name = "panelBuscar";
            panelBuscar.Size = new Size(784, 411);
            panelBuscar.TabIndex = 34;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(340, 46);
            label1.TabIndex = 35;
            label1.Text = "Seleccionar paquete";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11.25F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(0, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Size = new Size(784, 360);
            dataGridView1.TabIndex = 32;
            // 
            // btnVerClientes
            // 
            btnVerClientes.Anchor = AnchorStyles.Top;
            btnVerClientes.BackColor = Color.DimGray;
            btnVerClientes.FlatStyle = FlatStyle.Flat;
            btnVerClientes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerClientes.ForeColor = Color.White;
            btnVerClientes.Location = new Point(608, 13);
            btnVerClientes.Margin = new Padding(3, 4, 3, 4);
            btnVerClientes.Name = "btnVerClientes";
            btnVerClientes.Size = new Size(164, 30);
            btnVerClientes.TabIndex = 31;
            btnVerClientes.Text = "Seleccionar";
            btnVerClientes.UseVisualStyleBackColor = false;
            btnVerClientes.Click += btnVerClientes_Click;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Anchor = AnchorStyles.Top;
            btnSeleccionar.BackColor = Color.DimGray;
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeleccionar.ForeColor = Color.White;
            btnSeleccionar.Location = new Point(859, 13);
            btnSeleccionar.Margin = new Padding(3, 4, 3, 4);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(205, 30);
            btnSeleccionar.TabIndex = 30;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.DimGray;
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.ForeColor = Color.White;
            txtBuscar.Location = new Point(376, 18);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(204, 20);
            txtBuscar.TabIndex = 27;
            txtBuscar.Text = "Buscar";
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // FormSeleccionarPaquete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(panelBuscar);
            Controls.Add(dgv);
            Name = "FormSeleccionarPaquete";
            Text = "FormSeleccionarPaquete";
            Load += FormSeleccionarPaquete_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panelBuscar.ResumeLayout(false);
            panelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv;
        private Panel panelBuscar;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnVerClientes;
        private Button btnSeleccionar;
        private TextBox txtBuscar;
        private System.Windows.Forms.Timer timer1;
    }
}