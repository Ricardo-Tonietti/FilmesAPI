using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Dtos
{
    public class ReadFilmeDto
    {
         public int Id {get; set;}
        public string? Titulo { get; set; }
        [Required(ErrorMessage = "O campo Diretor é obrigatorio!")]
        public string? Diretor { get; set; }
        public string? Genero { get; set; }
        [Range(1,600, ErrorMessage = "Duração deve ter no minimo 1 e no maximo 600 minutos")]
        public int? Duracao { get; set;}
        public DateTime HoraDaConsulta{get; set;}
    }
}