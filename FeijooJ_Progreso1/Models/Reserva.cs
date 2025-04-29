using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeijooJ_Progreso1.Models

//Reserva: Se debe incluir la fecha de la reserva (entrada y salida)
//, valor a pagar e información del cliente.
{
    public class Reserva
    {
        [Key]
        
        public String FechaEntradaCliente { get; set; }

        
        public String FechaSalidaCliente { get; set; }
        
        

        
        public double ValorAPagar {  get; set; }

        public int IdentificacionCliente { get; set; }
        [ForeignKey("IdentificacionCliente")]
        public Cliente Cliente { get; set; }

    }
}
