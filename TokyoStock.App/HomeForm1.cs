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
            initForm.Show();
        }
    }
}
