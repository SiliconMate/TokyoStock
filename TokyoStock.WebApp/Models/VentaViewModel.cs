using System.ComponentModel.DataAnnotations;

namespace TokyoStock.WebApp.Models
{
    public class VentaViewModel
    {
        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required]
        public int ProductoId { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public int UsuarioId { get; set; }
    }
}
