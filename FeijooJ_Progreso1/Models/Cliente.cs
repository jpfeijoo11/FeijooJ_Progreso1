using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FeijooJ_Progreso1.Models
{
    public class Cliente
    {
        public String FeijooJ {  get; set; }
        [Key]
        
        public int Id { get; set; }
  
        
        [MaxLength(50)]
        public string Nombre { get; set; }
       
        public double Edad { get; set; }
        [Required]
        public bool SeHospedoAntes { get; set; }
        [Required]
        
        
        public string FechaEntrada { get; set; }

        [Required]
        public string FechaSalida { get; set; }

    }
        
}
