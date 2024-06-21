using TokyoStock.Core.Data;

namespace TokyoStock.Core.Tests
{
    public class VentaRepositoryDebe
    {
        [Fact]
        public void EstarVacioUsandoGetVentas()
        {
            var lista = new VentaRepository().GetVentas();

            Assert.Empty(lista);
        }
    }
}