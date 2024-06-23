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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            btBuscar = new Button();
            comboBox1 = new ComboBox();
            tbNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.LightSkyBlue;
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(btBuscar);
            splitContainer1.Panel2.Controls.Add(comboBox1);
            splitContainer1.Panel2.Controls.Add(tbNombre);
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
            btAdministracion.Click += btAdministracion_Click;
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
            btLista.Text = "Lo mas vendido";
            btLista.UseVisualStyleBackColor = false;
            btLista.Visible = false;
            btLista.Click += btLista_Click;
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
            btVentas.Text = "Compras / Ventas";
            btVentas.UseVisualStyleBackColor = false;
            btVentas.Visible = false;
            btVentas.Click += btVentas_Click;
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
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(607, 306);
            dataGridView1.TabIndex = 6;
            dataGridView1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(205, 105);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 5;
            label2.Text = "Nombre:";
            label2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSkyBlue;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(222, 30);
            label1.Name = "label1";
            label1.Size = new Size(199, 50);
            label1.TabIndex = 4;
            label1.Text = "Productos";
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(537, 103);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(75, 23);
            btBuscar.TabIndex = 3;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Visible = false;
            btBuscar.Click += btBuscar_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(387, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(144, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Visible = false;
            // 
            // tbNombre
            // 
            tbNombre.ForeColor = SystemColors.ControlText;
            tbNombre.Location = new Point(272, 103);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(109, 23);
            tbNombre.TabIndex = 1;
            tbNombre.Visible = false;
            // 
            // HomeForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "HomeForm1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TokyoStore";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Button btBuscar;
        private ComboBox comboBox1;
        private TextBox tbNombre;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
    }
}
