
using Microsoft.EntityFrameworkCore;
using TokyoStock.Core.Data;
using TokyoStock.Core.Entities;
using TokyoStock.Core.Entities.Filters;

namespace TokyoStock.Core.Business
{
    public class VentaBusiness
    {
        private readonly VentaRepository _vr;

        public VentaBusiness(VentaRepository vr)
        {
            _vr = vr;
        }

        public List<Venta> GetVentas()
        {
            return _vr.GetVentas();
        }

        public (List<Venta> list, int total) GetVentasByFilter(Filter f)
        {
            return GetVentasByFilter(f);
        }
    }
}
