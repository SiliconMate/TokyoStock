namespace TokyoStock.App
{
    partial class CompraVentaForm
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
            splitContainer1 = new SplitContainer();
            label3 = new Label();
            btSiguienteC = new Button();
            btAnteriorC = new Button();
            dgvCompra = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            btSiguienteV = new Button();
            btAnteriorV = new Button();
            dgvVenta = new DataGridView();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Moccasin;
            panel1.Controls.Add(splitContainer1);
            panel1.Location = new Point(25, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 413);
            panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Moccasin;
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(btSiguienteC);
            splitContainer1.Panel1.Controls.Add(btAnteriorC);
            splitContainer1.Panel1.Controls.Add(dgvCompra);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Moccasin;
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(btSiguienteV);
            splitContainer1.Panel2.Controls.Add(btAnteriorV);
            splitContainer1.Panel2.Controls.Add(dgvVenta);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(754, 413);
            splitContainer1.SplitterDistance = 369;
            splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(132, 378);
            label3.Name = "label3";
            label3.Size = new Size(58, 21);
            label3.TabIndex = 4;
            label3.Text = "Pagina";
            // 
            // btSiguienteC
            // 
            btSiguienteC.Location = new Point(276, 378);
            btSiguienteC.Name = "btSiguienteC";
            btSiguienteC.Size = new Size(75, 23);
            btSiguienteC.TabIndex = 3;
            btSiguienteC.Text = "Siguiente";
            btSiguienteC.UseVisualStyleBackColor = true;
            btSiguienteC.Click += btSiguiente_Click;
            // 
            // btAnteriorC
            // 
            btAnteriorC.Location = new Point(14, 378);
            btAnteriorC.Name = "btAnteriorC";
            btAnteriorC.Size = new Size(75, 23);
            btAnteriorC.TabIndex = 2;
            btAnteriorC.Text = "Anterior";
            btAnteriorC.UseVisualStyleBackColor = true;
            btAnteriorC.Click += btAnterior_Click;
            // 
            // dgvCompra
            // 
            dgvCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompra.Location = new Point(14, 76);
            dgvCompra.Name = "dgvCompra";
            dgvCompra.ReadOnly = true;
            dgvCompra.Size = new Size(337, 275);
            dgvCompra.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 11);
            label1.Name = "label1";
            label1.Size = new Size(168, 48);
            label1.TabIndex = 0;
            label1.Text = "Compras";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(131, 378);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 5;
            label4.Text = "Pagina";
            // 
            // btSiguienteV
            // 
            btSiguienteV.Location = new Point(292, 378);
            btSiguienteV.Name = "btSiguienteV";
            btSiguienteV.Size = new Size(75, 23);
            btSiguienteV.TabIndex = 4;
            btSiguienteV.Text = "Siguiente";
            btSiguienteV.UseVisualStyleBackColor = true;
            btSiguienteV.Click += btSiguienteV_Click;
            // 
            // btAnteriorV
            // 
            btAnteriorV.Location = new Point(18, 379);
            btAnteriorV.Name = "btAnteriorV";
            btAnteriorV.Size = new Size(75, 23);
            btAnteriorV.TabIndex = 3;
            btAnteriorV.Text = "Anterior";
            btAnteriorV.UseVisualStyleBackColor = true;
            btAnteriorV.Click += btAnteriorV_Click;
            // 
            // dgvVenta
            // 
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Location = new Point(18, 76);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.ReadOnly = true;
            dgvVenta.Size = new Size(349, 275);
            dgvVenta.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(131, 11);
            label2.Name = "label2";
            label2.Size = new Size(132, 48);
            label2.TabIndex = 1;
            label2.Text = "Ventas";
            // 
            // CompraVentaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "CompraVentaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compras y Ventas";
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private Label label1;
        private Label label2;
        private DataGridView dgvCompra;
        private DataGridView dgvVenta;
        private Button btSiguienteC;
        private Button btAnteriorC;
        private Button btSiguienteV;
        private Button btAnteriorV;
        private Label label3;
        private Label label4;
    }
}