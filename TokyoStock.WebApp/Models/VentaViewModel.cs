using System.ComponentModel.DataAnnotations;

namespace TokyoStock.WebApp.Models
{
    public class VentaViewModel
    {
        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public int ProductoId { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public string UsuarioId { get; set; }
    }
}
