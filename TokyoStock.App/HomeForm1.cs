namespace TokyoStock.App
{
    public partial class HomeForm1 : Form
    {
        public HomeForm1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            var initForm = new InitForm();
            initForm.ShowDialog();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        private void btAdministracion_Click(object sender, EventArgs e)
        {
            var adminForm = new AdministracionForm();
            adminForm.ShowDialog();
        }

        private void btLista_Click(object sender, EventArgs e)
        {
           var listaform = new ListaForm();
            listaform.ShowDialog();
        }

        private void btVentas_Click(object sender, EventArgs e)
        {
            var cvform = new CompraVentaForm();
            cvform.ShowDialog();
        }
    }
}
