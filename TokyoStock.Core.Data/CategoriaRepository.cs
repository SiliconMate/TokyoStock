using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TokyoStock.Core.Entities;

namespace TokyoStock.Core.Data
{
    public class CategoriaRepository
    {
        public CategoriaRepository() { }

        public List<Categoria> GetCategorias()
        {
            var list = new List<Categoria>();

            using (var db = new TokyoStockContext())
            {
                list = db.Categoria.ToList();
            }

            return list;
        }
    }
}
