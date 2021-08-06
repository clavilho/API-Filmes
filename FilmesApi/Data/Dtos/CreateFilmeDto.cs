using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O campo titulo é um campo obrigatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo dirtor é um campo obrigatorio")]
        public string Diretor { get; set; }
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve ter no minimo 1 e no maximo 600 minutos")]
        public int Duracao { get; set; }
    }
}
