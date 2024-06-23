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

        private int currentPageIndex = 1;
        private int pageSize = 10;
        private int totalRecords = 0;
        public CompraVentaForm()
        {
            InitializeComponent();
            InitControls();
        }
        private void InitControls()
        {

            dgvCompra.Columns.Clear();

            dgvCompra.Columns.Add("CompraId", "ID");
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
                p.CompraId,
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

            dgvCompra.Columns["CompraId"].DataPropertyName = "CompraId";
            dgvCompra.Columns["Fecha"].DataPropertyName = "Fecha";
            dgvCompra.Columns["ProductoNombre"].DataPropertyName = "ProductoNombre";
            dgvCompra.Columns["Cantidad"].DataPropertyName = "Cantidad";
            dgvCompra.Columns["UsuarioNombre"].DataPropertyName = "UsuarioNombre";
        }
    }
}
