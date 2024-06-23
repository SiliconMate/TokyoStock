using Microsoft.EntityFrameworkCore;
using TokyoStock.Core.Entities;
using TokyoStock.Core.Entities.Filters;

namespace TokyoStock.Core.Data
{
    public class ProductoRepository
    {
        public List<Producto> GetProductos()
        {
            var list = new List<Producto>();

            using (var db = new TokyoStockContext())
            {
                list = db.Productos.Include(p => p.Categoria).ToList();
            }

            return list;
        }

        public (List<Producto> list, int total) GetProductosByFilter(Filter f)
        {
            var total = 0;
            var list = new List<Producto>();

            using (var db = new TokyoStockContext())
            {
                total = db.Productos.Count();
                list = db.Productos.Include(p => p.Categoria)
                    .Skip((f.PageIndex - 1) * f.PageSize)
                    .Take(f.PageSize)
                    .ToList();
            }

            return (list, total);
        }


        public Producto GetProducto(int id)
        {
            var prod = new Producto();

            using (var db = new TokyoStockContext())
            {
                prod = db.Productos.Include(p => p.Categoria).FirstOrDefault(p => p.ProductoId == id);
            }

            return prod;
        }

        public Producto GetProductoByName(string name)
        {
            var prod = new Producto();

            using (var db = new TokyoStockContext())
            {
                prod = db.Productos.Include(p => p.Categoria).FirstOrDefault(p => p.Nombre == name);
            }

            return prod;
        }

        public void AddProducto(Producto p)
        {
            using (var db = new TokyoStockContext())
            {
                db.Productos.Add(p);
                db.SaveChanges();
            }
        }

        public void DeleteProducto(int id)
        {
            using (var db = new TokyoStockContext())
            {
                var prod = db.Productos.FirstOrDefault(p => p.ProductoId == id);
                db.Productos.Remove(prod);
                db.SaveChanges();
            }
        }

        public void UpdateProducto(Producto p)
        {
            using (var db = new TokyoStockContext())
            {
                db.Productos.Update(p);
                db.SaveChanges();
            }
        }
    }
}
