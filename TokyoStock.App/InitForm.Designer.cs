namespace TokyoStock.App
{
    partial class InitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitForm));
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            btEntrar = new Button();
            tbContraIngreso = new TextBox();
            tbUsuarioIngreso = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btRegistrar = new Button();
            tbContraRegistro = new TextBox();
            tbUsuarioRegistro = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(splitContainer1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 302);
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
            splitContainer1.Panel1.Controls.Add(panel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(panel3);
            splitContainer1.Size = new Size(460, 302);
            splitContainer1.SplitterDistance = 228;
            splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(btEntrar);
            panel2.Controls.Add(tbContraIngreso);
            panel2.Controls.Add(tbUsuarioIngreso);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(16, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 208);
            panel2.TabIndex = 0;
            // 
            // btEntrar
            // 
            btEntrar.BackColor = SystemColors.Highlight;
            btEntrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btEntrar.ForeColor = SystemColors.Control;
            btEntrar.Location = new Point(87, 162);
            btEntrar.Name = "btEntrar";
            btEntrar.Size = new Size(92, 34);
            btEntrar.TabIndex = 3;
            btEntrar.Text = "Entrar";
            btEntrar.UseVisualStyleBackColor = false;
            btEntrar.Click += btEntrar_Click;
            // 
            // tbContraIngreso
            // 
            tbContraIngreso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbContraIngreso.ForeColor = SystemColors.ButtonShadow;
            tbContraIngreso.Location = new Point(14, 118);
            tbContraIngreso.Name = "tbContraIngreso";
            tbContraIngreso.RightToLeft = RightToLeft.No;
            tbContraIngreso.Size = new Size(165, 23);
            tbContraIngreso.TabIndex = 2;
            tbContraIngreso.Text = "Contraseña";
            tbContraIngreso.Enter += tbContraIngreso_Enter;
            tbContraIngreso.Leave += tbContraIngreso_Leave;
            // 
            // tbUsuarioIngreso
            // 
            tbUsuarioIngreso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbUsuarioIngreso.ForeColor = SystemColors.ButtonShadow;
            tbUsuarioIngreso.Location = new Point(14, 76);
            tbUsuarioIngreso.Name = "tbUsuarioIngreso";
            tbUsuarioIngreso.RightToLeft = RightToLeft.No;
            tbUsuarioIngreso.Size = new Size(165, 23);
            tbUsuarioIngreso.TabIndex = 1;
            tbUsuarioIngreso.Text = "Usuario";
            tbUsuarioIngreso.Enter += tbUsuarioIngreso_Enter;
            tbUsuarioIngreso.Leave += tbUsuarioIngreso_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 27);
            label1.Name = "label1";
            label1.Size = new Size(168, 21);
            label1.TabIndex = 0;
            label1.Text = "Accede con tu cuenta";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(149, 234);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(btRegistrar);
            panel3.Controls.Add(tbContraRegistro);
            panel3.Controls.Add(tbUsuarioRegistro);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(14, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 205);
            panel3.TabIndex = 1;
            // 
            // btRegistrar
            // 
            btRegistrar.BackColor = SystemColors.Highlight;
            btRegistrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btRegistrar.ForeColor = SystemColors.Control;
            btRegistrar.Location = new Point(14, 136);
            btRegistrar.Name = "btRegistrar";
            btRegistrar.Size = new Size(165, 34);
            btRegistrar.TabIndex = 3;
            btRegistrar.Text = "Registrarse";
            btRegistrar.UseVisualStyleBackColor = false;
            btRegistrar.Click += btRegistrar_Click;
            // 
            // tbContraRegistro
            // 
            tbContraRegistro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbContraRegistro.ForeColor = SystemColors.ButtonShadow;
            tbContraRegistro.Location = new Point(14, 92);
            tbContraRegistro.Name = "tbContraRegistro";
            tbContraRegistro.RightToLeft = RightToLeft.No;
            tbContraRegistro.Size = new Size(165, 23);
            tbContraRegistro.TabIndex = 2;
            tbContraRegistro.Text = "Contraseña";
            tbContraRegistro.Enter += tbContraRegistro_Enter;
            tbContraRegistro.Leave += tbContraRegistro_Leave;
            // 
            // tbUsuarioRegistro
            // 
            tbUsuarioRegistro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbUsuarioRegistro.ForeColor = SystemColors.ButtonShadow;
            tbUsuarioRegistro.Location = new Point(14, 54);
            tbUsuarioRegistro.Name = "tbUsuarioRegistro";
            tbUsuarioRegistro.RightToLeft = RightToLeft.No;
            tbUsuarioRegistro.Size = new Size(165, 23);
            tbUsuarioRegistro.TabIndex = 1;
            tbUsuarioRegistro.Text = "Usuario";
            tbUsuarioRegistro.Enter += tbUsuarioRegistro_Enter;
            tbUsuarioRegistro.Leave += tbUsuarioRegistro_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 13);
            label2.Name = "label2";
            label2.Size = new Size(160, 21);
            label2.TabIndex = 0;
            label2.Text = "¿Eres usuario nuevo?";
            // 
            // InitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(484, 326);
            Controls.Add(panel1);
            Name = "InitForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuarios";
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private Panel panel2;
        private TextBox tbContraIngreso;
        private TextBox tbUsuarioIngreso;
        private Label label1;
        private Button btEntrar;
        private Panel panel3;
        private Button btRegistrar;
        private TextBox tbContraRegistro;
        private TextBox tbUsuarioRegistro;
        private Label label2;
        private PictureBox pictureBox1;
    }
}