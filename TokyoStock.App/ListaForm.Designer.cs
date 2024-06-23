namespace TokyoStock.App
{
    partial class ListaForm
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
            panel1 = new Panel();
            dgvVendido = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendido).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(dgvVendido);
            panel1.Location = new Point(12, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 251);
            panel1.TabIndex = 0;
            // 
            // dgvVendido
            // 
            dgvVendido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendido.Location = new Point(13, 12);
            dgvVendido.Name = "dgvVendido";
            dgvVendido.ReadOnly = true;
            dgvVendido.Size = new Size(432, 224);
            dgvVendido.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PaleGreen;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 9);
            label1.Name = "label1";
            label1.Size = new Size(264, 50);
            label1.TabIndex = 1;
            label1.Text = "Mas Vendidos";
            // 
            // ListaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(484, 326);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ListaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVendido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvVendido;
        private Label label1;
    }
}