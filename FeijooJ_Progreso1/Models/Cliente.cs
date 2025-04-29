using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FeijooJ_Progreso1.Models
{
    public class Cliente
    {
        public String FeijooJ {  get; set; }
        [Key]
        [MaxLength(10)]
        public int Id { get; set; }
  
        
        [MaxLength(50)]
        public string Nombre { get; set; }
        [MaxLength (20)]
        public double Edad { get; set; }
        [Required]
        public bool SeHospedoAntes { get; set; }

        
        [MaxLength(50)]
        public string FechaEntrada { get; set; }
        
        [MaxLength(50)]
        public string FechaSalida { get; set; }

    }
        
}
