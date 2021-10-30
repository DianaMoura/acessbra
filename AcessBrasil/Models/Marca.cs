using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AcessBrasil.Models
{
    public class Marca
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "O Nome é Obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }

    }
}
