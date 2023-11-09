using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Models
{
    public class Pessoa
    {
        [Key]
        public int idPessoa { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public DateTime dataNasc { get; set; }
        public string cep { get; set; }
    }
}



