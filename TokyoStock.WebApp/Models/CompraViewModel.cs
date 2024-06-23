using System.ComponentModel.DataAnnotations;

namespace TokyoStock.WebApp.Models
{
    public class CompraViewModel
    {
        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int ProductoId { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public int UsuarioId { get; set; }
    }
}
