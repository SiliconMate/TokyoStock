using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TokyoStock.Core.Business;
using TokyoStock.Core.Data;
using TokyoStock.Core.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TokyoStock.App
{
    public partial class AdministracionForm : Form
    {
        private static ProductoRepository productoRepository = new ProductoRepository();
        private static ProductoBusiness productoBusiness = new ProductoBusiness(productoRepository);

        private static CategoriaRepository categoriaRepository = new CategoriaRepository();
        private static CategoriaBusiness categoriaBusiness = new CategoriaBusiness(categoriaRepository);
        public AdministracionForm()
        {
            InitializeComponent();
            InitControls();
        }
        private void InitControls()
        {
            var categorias = categoriaBusiness.getCategorias();

            cbCategoria.DataSource = categorias;
            cbCategoria.DisplayMember = "Nombre";
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            if (tbId.Text != "")
            {
                btAgregar.Visible = false;
            }
            else
            {
                btAgregar.Visible = true;
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (tbId.Text != "" && Convert.ToInt32(tbId.Text) > 0)
            {
                if (productoBusiness.GetProducto(Convert.ToInt32(tbId.Text)) != null)
                {
                    var prod = productoBusiness.GetProducto(Convert.ToInt32(tbId.Text));
                    tbNombre.Text = prod.Nombre;
                    cbCategoria.Text = prod.Categoria.Nombre;
                    btGuardar.Visible = true;
                    btEliminar.Visible = true;
                }
                else
                {
                    MessageBox.Show("No se encontró el producto");
                };
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido");
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {

            if (tbNombre.Text != "" && tbId.Text == "")
            {
                var prod = new Producto
                {
                    Nombre = tbNombre.Text,
                    CategoriaId = obtenerCategoria().CategoriaId,
                    Habilitado = true
                };

                //Validar que no exista un producto con el mismo nombre
                if (productoBusiness.GetProductoByName(prod.Nombre) != null)
                {
                    MessageBox.Show("Ya existe un producto con ese nombre");
                    return;
                }
                else
                productoBusiness.AddProducto(prod);
                {
                    MessageBox.Show("Producto agregado");
                }
                tbNombre.Text = "";
            }
            else if (tbNombre.Text != "" && tbId.Text != "")
            {
                MessageBox.Show("No se pueden agregar productos con ID");
            }
            else
            {
                MessageBox.Show("Complete los campos");
            }
        }

        private Categoria obtenerCategoria()
        {
            var categoria = cbCategoria.Text;
            return categoriaBusiness.getCategoria(categoria);
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (tbId.Text != "" && Convert.ToInt32(tbId.Text) > 0)
            {
                productoBusiness.DeleteProducto(Convert.ToInt32(tbId.Text));
                MessageBox.Show("Producto eliminado");
                tbNombre.Text = "";
                tbId.Text = "";
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido");
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if(tbId.Text != "" && Convert.ToInt32(tbId.Text) > 0)
            {
                var prod = productoBusiness.GetProducto(Convert.ToInt32(tbId.Text));
                prod.Nombre = tbNombre.Text;
                prod.CategoriaId = obtenerCategoria().CategoriaId;
                productoBusiness.UpdateProducto(prod);
                MessageBox.Show("Producto actualizado");
                tbNombre.Text = "";
                tbId.Text = "";
            }
            else
            {
                MessageBox.Show("Ingrese un ID válido");
            }
        }
    }
}
