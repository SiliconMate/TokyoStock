
using TokyoStock.Core.Entities;

namespace TokyoStock.Core.Data
{
    public class UsuarioRepository
    {

        public UsuarioRepository()
        {

        }

        public List<Usuario> GetUsuarios()
        {
            var list = new List<Usuario>();

            using (var db = new TokyoStockContext())
            {
                list = db.Usuarios.ToList();
            }

            return list;
        }

        public Usuario GetUsuarioByName(string nombre)
        {
            using (var db = new TokyoStockContext())
            {
                return db.Usuarios.ToList().Where(u => u.Nombre == nombre).FirstOrDefault();
            }
        }

        public void AddUsuario(Usuario u)
        {
            using (var db = new TokyoStockContext())
            {
                db.Usuarios.Add(u);
                db.SaveChanges();
            }
        }

    }
}
