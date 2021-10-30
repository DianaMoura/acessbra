using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcessBrasil.Models
{
    public class Carro
    {

        [Key]
        public int ID { get; set; }
        public int IDMarca { get; set; }
        [Required(ErrorMessage = "O Modelo é Obrigatório", AllowEmptyStrings = false)]
        public string Modelo { get; set; }
        [Required]
        public int Ano { get; set; }
        public string Cor { get; set; }

        public ICollection<Marca> Marcas { get; set; }

    }
}
