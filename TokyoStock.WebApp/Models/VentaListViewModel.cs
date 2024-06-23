using TokyoStock.Core.Entities;

namespace TokyoStock.WebApp.Models
{
    public class VentaListViewModel
    {
        public List<Venta> Ventas { get; set; }
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage => PageIndex > 1;
        public bool HasNextPage => PageIndex < TotalPages;
    }
}
