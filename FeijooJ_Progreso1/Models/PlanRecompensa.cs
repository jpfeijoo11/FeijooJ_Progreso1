using System.ComponentModel.DataAnnotations;

namespace FeijooJ_Progreso1.Models
//Plan de recompensas (cliente): Debe tener 5 atributos: Id, Nombre,
//Fecha de inicio, puntos acumulados. (Por cada reserva realizada, el cliente gana 100 puntos)
//y tipo de recompensa (menos de 500 puntos: SILVER, más de 500 puntos: GOLD).
{
    public class PlanRecompensa
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public String Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public String FechaInicioP {  get; set; }
        public int NoReservas { get; set; }

        public int TotalPuntos
        {
            get
            {
                int total_puntos =  NoReservas * 100;
                return total_puntos;
            }
        }


    }
}
