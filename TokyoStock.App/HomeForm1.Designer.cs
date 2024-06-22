namespace TokyoStock.App
{
    partial class HomeForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm1));
            splitContainer1 = new SplitContainer();
            btIniciar = new Button();
            btSalir = new Button();
            btAdministracion = new Button();
            btLista = new Button();
            btVentas = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.Info;
            splitContainer1.Panel1.Controls.Add(btIniciar);
            splitContainer1.Panel1.Controls.Add(btSalir);
            splitContainer1.Panel1.Controls.Add(btAdministracion);
            splitContainer1.Panel1.Controls.Add(btLista);
            splitContainer1.Panel1.Controls.Add(btVentas);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.AppWorkspace;
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 162;
            splitContainer1.TabIndex = 0;
            // 
            // btIniciar
            // 
            btIniciar.BackColor = Color.Lime;
            btIniciar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btIniciar.ForeColor = SystemColors.ActiveCaptionText;
            btIniciar.Image = (Image)resources.GetObject("btIniciar.Image");
            btIniciar.ImageAlign = ContentAlignment.MiddleLeft;
            btIniciar.Location = new Point(13, 348);
            btIniciar.Name = "btIniciar";
            btIniciar.Size = new Size(135, 37);
            btIniciar.TabIndex = 3;
            btIniciar.Text = "Iniciar";
            btIniciar.UseVisualStyleBackColor = false;
            btIniciar.Click += btIniciar_Click;
            // 
            // btSalir
            // 
            btSalir.BackColor = Color.Red;
            btSalir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSalir.ForeColor = SystemColors.Control;
            btSalir.Image = (Image)resources.GetObject("btSalir.Image");
            btSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btSalir.Location = new Point(12, 403);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(136, 35);
            btSalir.TabIndex = 4;
            btSalir.Text = "Salir";
            btSalir.UseVisualStyleBackColor = false;
            btSalir.Click += btSalir_Click;
            // 
            // btAdministracion
            // 
            btAdministracion.BackColor = SystemColors.ControlText;
            btAdministracion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btAdministracion.ForeColor = SystemColors.Control;
            btAdministracion.ImageAlign = ContentAlignment.MiddleLeft;
            btAdministracion.Location = new Point(13, 237);
            btAdministracion.Name = "btAdministracion";
            btAdministracion.Size = new Size(135, 37);
            btAdministracion.TabIndex = 2;
            btAdministracion.Text = "Administracion";
            btAdministracion.UseVisualStyleBackColor = false;
            // 
            // btLista
            // 
            btLista.BackColor = SystemColors.ActiveCaptionText;
            btLista.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLista.ForeColor = SystemColors.Control;
            btLista.Location = new Point(12, 194);
            btLista.Name = "btLista";
            btLista.Size = new Size(135, 37);
            btLista.TabIndex = 5;
            btLista.Text = "Listados";
            btLista.UseVisualStyleBackColor = false;
            // 
            // btVentas
            // 
            btVentas.BackColor = SystemColors.ActiveCaptionText;
            btVentas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btVentas.ForeColor = SystemColors.Control;
            btVentas.Image = (Image)resources.GetObject("btVentas.Image");
            btVentas.Location = new Point(12, 151);
            btVentas.Name = "btVentas";
            btVentas.Size = new Size(135, 37);
            btVentas.TabIndex = 1;
            btVentas.Text = "Ventas";
            btVentas.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private Button btAdministracion;
        private Button btVentas;
        private Button btLista;
        private Button btSalir;
        private Button btIniciar;
    }
}
