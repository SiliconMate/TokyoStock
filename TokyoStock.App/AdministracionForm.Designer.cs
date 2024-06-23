namespace TokyoStock.App
{
    partial class AdministracionForm
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
            label1 = new Label();
            label2 = new Label();
            cbCategoria = new ComboBox();
            label3 = new Label();
            tbId = new TextBox();
            btBuscar = new Button();
            btAgregar = new Button();
            btGuardar = new Button();
            btEliminar = new Button();
            panel1 = new Panel();
            label4 = new Label();
            tbNombre = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightPink;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 9);
            label1.Name = "label1";
            label1.Size = new Size(347, 50);
            label1.TabIndex = 0;
            label1.Text = "ADMINISTRACION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(99, 75);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // cbCategoria
            // 
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(180, 114);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(159, 23);
            cbCategoria.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(89, 112);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 3;
            label3.Text = "Categoria:";
            // 
            // tbId
            // 
            tbId.Location = new Point(180, 39);
            tbId.Name = "tbId";
            tbId.Size = new Size(59, 23);
            tbId.TabIndex = 4;
            tbId.TextChanged += tbId_TextChanged;
            // 
            // btBuscar
            // 
            btBuscar.BackColor = Color.FromArgb(224, 224, 224);
            btBuscar.Location = new Point(264, 39);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(75, 23);
            btBuscar.TabIndex = 5;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = false;
            btBuscar.Click += btBuscar_Click;
            // 
            // btAgregar
            // 
            btAgregar.Location = new Point(99, 173);
            btAgregar.Name = "btAgregar";
            btAgregar.Size = new Size(75, 23);
            btAgregar.TabIndex = 6;
            btAgregar.Text = "Agregar";
            btAgregar.UseVisualStyleBackColor = true;
            btAgregar.Click += btAgregar_Click;
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(218, 173);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(75, 23);
            btGuardar.TabIndex = 7;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Visible = false;
            btGuardar.Click += btGuardar_Click;
            // 
            // btEliminar
            // 
            btEliminar.Location = new Point(340, 173);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(75, 23);
            btEliminar.TabIndex = 8;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = true;
            btEliminar.Visible = false;
            btEliminar.Click += btEliminar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PapayaWhip;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbNombre);
            panel1.Controls.Add(btAgregar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbId);
            panel1.Controls.Add(btBuscar);
            panel1.Controls.Add(btEliminar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbCategoria);
            panel1.Controls.Add(btGuardar);
            panel1.Location = new Point(12, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 252);
            panel1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(144, 37);
            label4.Name = "label4";
            label4.Size = new Size(30, 21);
            label4.TabIndex = 9;
            label4.Text = "ID:";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(180, 77);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(159, 23);
            tbNombre.TabIndex = 10;
            // 
            // AdministracionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(484, 326);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "AdministracionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administracion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbCategoria;
        private Label label3;
        private TextBox tbId;
        private Button btBuscar;
        private Button btAgregar;
        private Button btGuardar;
        private Button btEliminar;
        private Panel panel1;
        private Label label4;
        private TextBox tbNombre;
    }
}