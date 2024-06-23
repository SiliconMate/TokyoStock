using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TokyoStock.Core.Business;
using TokyoStock.Core.Data;
using TokyoStock.Core.Entities;

namespace TokyoStock.App
{
    public partial class ListaForm : Form
    {
        private static ProductoRepository productoRepository = new ProductoRepository();
        private static ProductoBusiness productoBusiness = new ProductoBusiness(productoRepository);

        private static VentaRepository ventaRepository = new VentaRepository();
        private static VentaBusiness ventaBusiness = new VentaBusiness(ventaRepository);

        public ListaForm()
        {
            InitializeComponent();
            InitdgvLista();
        }

        private void InitdgvLista()
        {
            dgvVendido.Columns.Clear();

            dgvVendido.Columns.Add("ProductoNombre", "Producto");
            dgvVendido.Columns.Add("CategoriaNombre", "Categoria");
            dgvVendido.Columns.Add("Cantidad", "Cantidad Vendida");

            List<Venta> ventas = ventaBusiness.GetVentasWithProducts();
      
            var productosMasVendidosCompleto = ventas.GroupBy(v => v.ProductoId)
                .Select(g => new
                {
                    ProductoNombre = productoBusiness.GetProducto(g.First().ProductoId).Nombre,
                    CategoriaNombre = productoBusiness.GetProducto(g.First().ProductoId).Categoria.Nombre,
                    CantidadVendida = g.Sum(v => v.Cantidad)
                })
                .OrderByDescending(p => p.CantidadVendida)
                .Take(5)
                .ToList();

            dgvVendido.AutoGenerateColumns = false;
            dgvVendido.DataSource = productosMasVendidosCompleto;

            dgvVendido.Columns["ProductoNombre"].DataPropertyName = "ProductoNombre";
            dgvVendido.Columns["CategoriaNombre"].DataPropertyName = "CategoriaNombre";
            dgvVendido.Columns["Cantidad"].DataPropertyName = "CantidadVendida";
            dgvVendido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
