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
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(16, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 208);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(87, 162);
            button1.Name = "button1";
            button1.Size = new Size(92, 34);
            button1.TabIndex = 3;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.ButtonShadow;
            textBox2.Location = new Point(14, 118);
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = RightToLeft.No;
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "Contraseña";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ButtonShadow;
            textBox1.Location = new Point(14, 76);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Usuario";
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
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(14, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 205);
            panel3.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(14, 136);
            button2.Name = "button2";
            button2.Size = new Size(165, 34);
            button2.TabIndex = 3;
            button2.Text = "Registrarse";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.ButtonShadow;
            textBox3.Location = new Point(14, 92);
            textBox3.Name = "textBox3";
            textBox3.RightToLeft = RightToLeft.No;
            textBox3.Size = new Size(165, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "Contraseña";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.ForeColor = SystemColors.ButtonShadow;
            textBox4.Location = new Point(14, 54);
            textBox4.Name = "textBox4";
            textBox4.RightToLeft = RightToLeft.No;
            textBox4.Size = new Size(165, 23);
            textBox4.TabIndex = 1;
            textBox4.Text = "Usuario";
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
            // InitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(484, 326);
            Controls.Add(panel1);
            Name = "InitForm";
            Text = "InitForm";
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private Panel panel2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private PictureBox pictureBox1;
    }
}