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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TokyoStock.Core.Business;
using TokyoStock.Core.Entities.Filters;
using TokyoStock.Core.Data;

namespace TokyoStock.App
{
    public partial class CompraVentaForm : Form
    {
        private static CompraRepository compraRepository = new CompraRepository();
        private static CompraBusiness compraBusiness = new CompraBusiness(compraRepository);

        private static VentaRepository ventaRepository = new VentaRepository();
        private static VentaBusiness ventaBusiness = new VentaBusiness(ventaRepository);

        private int currentPageIndex = 1;
        private int pageSize = 10;
        private int totalRecords = 0;

        private int currentPageIndexVenta = 1;
        private int pageSizeVenta = 10;
        private int totalRecordsVenta = 0;

        public CompraVentaForm()
        {
            InitializeComponent();
            InitdgvCompra();
            InitdgvVenta();
        }

        private void InitdgvCompra()
        {

            dgvCompra.Columns.Clear();

            dgvCompra.Columns.Add("Fecha", "Fecha");
            dgvCompra.Columns.Add("ProductoNombre", "Producto");
            dgvCompra.Columns.Add("Cantidad", "Cantidad");
            dgvCompra.Columns.Add("UsuarioNombre", "Usuario");


            var filter = new Filter
            {
                PageIndex = currentPageIndex,
                PageSize = pageSize
            };

            var result = compraBusiness.GetComprasByFilter(filter);
            totalRecords = result.total;

            var ds = result.list.Select(p => new
            {
                p.Fecha,
                ProductoNombre = p.Producto.Nombre,
                p.Cantidad,
                UsuarioNombre = p.Usuario.Nombre
            }).ToList();

            label3.Text = $"Pagina {currentPageIndex} de {Math.Ceiling((double)totalRecords / pageSize)}";
            dgvCompra.AutoGenerateColumns = false;
            dgvCompra.DataSource = ds;

            btAnteriorC.Enabled = currentPageIndex > 1;
            btSiguienteC.Enabled = currentPageIndex < (int)Math.Ceiling((double)totalRecords / pageSize);

            dgvCompra.Columns["Fecha"].DataPropertyName = "Fecha";
            dgvCompra.Columns["ProductoNombre"].DataPropertyName = "ProductoNombre";
            dgvCompra.Columns["Cantidad"].DataPropertyName = "Cantidad";
            dgvCompra.Columns["UsuarioNombre"].DataPropertyName = "UsuarioNombre";
            dgvCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void InitdgvVenta()
        {
            dgvVenta.Columns.Clear();

            dgvVenta.Columns.Add("Fecha", "Fecha");
            dgvVenta.Columns.Add("ProductoNombre", "Producto");
            dgvVenta.Columns.Add("Cantidad", "Cantidad");
            dgvVenta.Columns.Add("UsuarioNombre", "Usuario");

            var filterVenta = new Filter
            {
                PageIndex = currentPageIndexVenta,
                PageSize = pageSizeVenta
            };

            var result2 = ventaBusiness.GetVentasByFilter(filterVenta);
            totalRecordsVenta = result2.total;

            var ds2 = result2.list.Select(p => new
            {
                p.Fecha,
                ProductoNombre = p.Producto.Nombre,
                p.Cantidad,
                UsuarioNombre = p.Usuario.Nombre
            }).ToList();

            label4.Text = $"Pagina {currentPageIndexVenta} de {Math.Ceiling((double)totalRecordsVenta / pageSizeVenta)}";
            dgvVenta.AutoGenerateColumns = false;
            dgvVenta.DataSource = ds2;

            btAnteriorV.Enabled = currentPageIndexVenta > 1;
            btSiguienteV.Enabled = currentPageIndexVenta < (int)Math.Ceiling((double)totalRecordsVenta / pageSizeVenta);

            dgvVenta.Columns["Fecha"].DataPropertyName = "Fecha";
            dgvVenta.Columns["ProductoNombre"].DataPropertyName = "ProductoNombre";
            dgvVenta.Columns["Cantidad"].DataPropertyName = "Cantidad";
            dgvVenta.Columns["UsuarioNombre"].DataPropertyName = "UsuarioNombre";
            dgvVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        
        private void btSiguiente_Click(object sender, EventArgs e)
        {
            if ((currentPageIndex * pageSize) < totalRecords)
            {
                currentPageIndex++;
                InitdgvCompra();
            }
        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            if (currentPageIndex > 1)
            {
                currentPageIndex--;
                InitdgvCompra();
            }
        }

        private void btSiguienteV_Click(object sender, EventArgs e)
        {
            if ((currentPageIndexVenta * pageSizeVenta) < totalRecordsVenta)
            {
                currentPageIndexVenta++;
                InitdgvVenta();
            }
        }

        private void btAnteriorV_Click(object sender, EventArgs e)
        {
            if (currentPageIndexVenta > 1)
            {
                currentPageIndexVenta--;
                InitdgvVenta();
            }
        }
    }
}
