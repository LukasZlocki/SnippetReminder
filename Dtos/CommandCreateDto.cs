using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandCreateDto
    {
        //public int Id { get; set; }  <- id nie wysylamy, baza sama nada odpowiednie Id
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }
        
        [Required]
        public string Line { get; set; }
       
        [Required]
        public string Platform { get; set; }
    }
}