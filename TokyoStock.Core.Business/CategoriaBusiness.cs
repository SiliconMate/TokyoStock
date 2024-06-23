using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokyoStock.Core.Data;
using TokyoStock.Core.Entities;

namespace TokyoStock.Core.Business
{
    public class CategoriaBusiness
    {
        private readonly CategoriaRepository _cr;

        public CategoriaBusiness(CategoriaRepository cr)
        {
            _cr = cr;
        }

        public List<Categoria> getCategorias()
        {
           return _cr.GetCategorias();
        }

    }
}
