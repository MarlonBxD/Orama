namespace GUI
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            btnIniciar = new Button();
            btnCapturar = new Button();
            label = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(44, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(521, 642);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(623, 463);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(216, 78);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            // 
            // btnCapturar
            // 
            btnCapturar.Location = new Point(623, 296);
            btnCapturar.Name = "btnCapturar";
            btnCapturar.Size = new Size(216, 79);
            btnCapturar.TabIndex = 2;
            btnCapturar.Text = "capturar";
            btnCapturar.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(693, 589);
            label.Name = "label";
            label.Size = new Size(70, 20);
            label.TabIndex = 3;
            label.Text = "iniciando";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 723);
            Controls.Add(label);
            Controls.Add(btnCapturar);
            Controls.Add(btnIniciar);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnIniciar;
        private Button btnCapturar;
        private Label label;
    }
}