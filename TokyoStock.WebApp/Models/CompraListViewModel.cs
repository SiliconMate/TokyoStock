using TokyoStock.Core.Entities;

namespace testPaginacion.Models
{
    public class CompraListViewModel
    {
        public List<Compra> Compras { get; set; }
        public int PageIndex { get; set; }
        public int TotalPages { get; set; }

        public bool HasPreviousPage => PageIndex > 1;
        public bool HasNextPage => PageIndex < TotalPages;
    }
}
