
using TokyoStock.Core.Data;
using TokyoStock.Core.Entities.Filters;
using TokyoStock.Core.Entities;

namespace TokyoStock.Core.Business
{
    public class CompraBusiness
    {
        private readonly CompraRepository _cr;

        public CompraBusiness(CompraRepository cr)
        {
            _cr = cr;
        }

        public List<Compra> GetCompras()
        {
            return _cr.GetCompras();
        }

        public (List<Compra> list, int total) GetComprasByFilter(Filter f)
        {
            return GetComprasByFilter(f);
        }
    }
}
