using Microsoft.IdentityModel.Tokens;
using System.Drawing.Printing;
using System.Windows.Forms;
using TokyoStock.Core.Business;
using TokyoStock.Core.Data;
using TokyoStock.Core.Entities;
using TokyoStock.Core.Entities.Filters;

namespace TokyoStock.App
{
    public partial class HomeForm1 : Form
    {
        private static ProductoRepository productoRepository = new ProductoRepository();
        private static ProductoBusiness productoBusiness = new ProductoBusiness(productoRepository);
        private static CategoriaRepository categoriaRepository = new CategoriaRepository();
        private static CategoriaBusiness categoriaBusiness = new CategoriaBusiness(categoriaRepository);

        public static bool _isLogged = false;

        private int currentPageIndex = 1;
        private int pageSize = 10;
        private int totalRecords = 0;

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

            var filter = new Filter
            {
                PageIndex = currentPageIndex,
                PageSize = pageSize
            };

            var result = productoBusiness.GetProductosByFilter(filter);
            totalRecords = result.total;

            var ds = result.list.Select(p => new
            {
                p.ProductoId,
                p.Nombre,
                CategoriaNombre = p.Categoria.Nombre,
                p.Habilitado
            }).ToList(); 


            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds;

            label3.Text = $"Pagina {currentPageIndex} de {Math.Ceiling((double)totalRecords / pageSize)}";
            btAnterior.Enabled = currentPageIndex > 1;
            btSiguiente.Enabled = currentPageIndex < (int)Math.Ceiling((double)totalRecords / pageSize);

            dataGridView1.Columns["ProductoId"].DataPropertyName = "ProductoId";
            dataGridView1.Columns["Nombre"].DataPropertyName = "Nombre";
            dataGridView1.Columns["CategoriaNombre"].DataPropertyName = "CategoriaNombre";
            
            var categorias = categoriaBusiness.getCategorias();
            comboBox1.DataSource = categorias;
            comboBox1.DisplayMember = "Nombre";
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
            btCancelar.Visible = true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            tbNombre.Text = "";
            InitControls();
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            if ((currentPageIndex * pageSize) < totalRecords)
            {
                currentPageIndex++;
                InitControls();
            }
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 1)
            {
                currentPageIndex--;
                InitControls();
            }
        }
    }
}
