using TokyoStock.Core.Business;
using TokyoStock.Core.Data;

namespace TokyoStock.Core.Tests
{
    public class UsuarioBusinessDebe
    {
        //[Fact]
        //public void AgregarUnUsuarioALaDB()
        //{
        //    
        //    var ur = new UsuarioRepository();
        //    var ub = new UsuarioBusiness(ur);
        //    ub.RegistrarUsuario("Prueba", "123");

        //    Assert.Single(ub.GetUsuarios());

        //}

        [Fact]
        public void BuscarUsuario()
        {
            var ur = new UsuarioRepository();
            var ub = new UsuarioBusiness(ur);

            var nombre = "Prueba";

            var dbUsuario = ub.GetUsuarioByName("Prueba");

            Assert.Equal(nombre, dbUsuario.Nombre);
        }

    }
}