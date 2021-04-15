using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadEscola._2_Domain.Models
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public ResponsavelAluno Responsavel { get; set; }
        public bool IsAtivo { get; set; }
    }
}
