
using TokyoStock.Core.Entities;
using TokyoStock.Core.Data;

namespace TokyoStock.Core.Business
{
    public class UsuarioBusiness
    {
        private readonly UsuarioRepository _ur;

        public UsuarioBusiness(UsuarioRepository ur)
        {
            _ur = ur;
        }

        public List<Usuario> GetUsuarios()
        {
            return _ur.GetUsuarios();
        }

        public Usuario GetUsuarioByName(string nombre)
        {
            return _ur.GetUsuarioByName(nombre);
        }

        public void RegistrarUsuario(string nom, string pass)
        {
            var salt = SecurityHelper.GenerateSalt();
            var hash = SecurityHelper.HashPassword(pass, salt);

            var usuario = new Usuario()
            {
                Nombre = nom,
                Hash = hash,
                Salt = salt
            };

            _ur.AddUsuario(usuario);
        }

        public bool ValidarUsuario(string nomb, string pass)
        {
            var user = _ur.GetUsuarioByName(nomb);

            if (user == null)
            {
                return false;
            }

            byte[] hashedPassword = SecurityHelper.HashPassword(pass, user.Salt);

            return hashedPassword.SequenceEqual(user.Hash);
        }
    }
}
