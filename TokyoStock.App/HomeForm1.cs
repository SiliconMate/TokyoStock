using Microsoft.IdentityModel.Tokens;
using System.Windows.Forms;
using TokyoStock.Core.Business;
using TokyoStock.Core.Data;

namespace TokyoStock.App
{
    public partial class HomeForm1 : Form
    {
        private static ProductoRepository productoRepository = new ProductoRepository();
        private static ProductoBusiness productoBusiness = new ProductoBusiness(productoRepository);
        public static bool _isLogged = false;
        public HomeForm1()
        {
            InitializeComponent();
            InitControls();
        }
        
        private void InitControls()
        {

            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("ProductoId", "ID");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("CategoriaNombre", "Categoria");
            DataGridViewCheckBoxColumn habilitadoColumn = new DataGridViewCheckBoxColumn
            {
                Name = "Habilitado",
                HeaderText = "Habilitado",
                DataPropertyName = "Habilitado",
                TrueValue = true,
                FalseValue = false
            };
            dataGridView1.Columns.Add(habilitadoColumn);

            var ds = productoBusiness.GetProductos().Select(p => new
            {
                p.ProductoId,
                p.Nombre,
                CategoriaNombre = p.Categoria.Nombre,
                p.Habilitado
            }).ToList();

            comboBox1.DataSource = ds;
            comboBox1.DisplayMember = "CategoriaNombre";
            dataGridView1.DataSource = ds;
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns["ProductoId"].DataPropertyName = "ProductoId";
            dataGridView1.Columns["Nombre"].DataPropertyName = "Nombre";
            dataGridView1.Columns["CategoriaNombre"].DataPropertyName = "CategoriaNombre";
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            var initForm = new InitForm();
            initForm.ShowDialog();
            if (_isLogged)
            {
                btAdministracion.Visible = true;
                btLista.Visible = true;
                btVentas.Visible = true;
                btBuscar.Visible = true;
                tbNombre.Visible = true;
                comboBox1.Visible = true;
                label2.Visible = true;
                dataGridView1.Visible = true;
            }
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


        private void btBuscar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text.ToLower();
            string categoria = comboBox1.Text;
            var ds = productoBusiness.GetProductos().Select(p => new
            {
                p.ProductoId,
                p.Nombre,
                CategoriaNombre = p.Categoria.Nombre,
                p.Habilitado
            }).ToList();

            if (!nombre.IsNullOrEmpty())
            {
                ds = ds.Where(p => p.Nombre.ToLower().StartsWith(nombre) && p.CategoriaNombre.Contains(categoria)).ToList();
            }
            else if (nombre.IsNullOrEmpty())
            {
                ds = ds.Where(p => p.CategoriaNombre.Contains(categoria)).ToList();
            }
            dataGridView1.DataSource = ds;
        }
    }
}
