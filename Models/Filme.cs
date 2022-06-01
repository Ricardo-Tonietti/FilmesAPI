using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id {get; set;}
        [Required(ErrorMessage = "O campo título é obrigatorio!")]
        public string? Titulo { get; set; }
        [Required(ErrorMessage = "O campo Diretor é obrigatorio!")]
        public string? Diretor { get; set; }
        public string? Genero { get; set; }
        [Range(1,600, ErrorMessage = "Duração deve ter no minimo 1 e no maximo 600 minutos")]
        public int? Duracao { get; set;}
    }
}