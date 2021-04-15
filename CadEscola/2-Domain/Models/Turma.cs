using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadEscola._2_Domain.Models
{
    public class Turma
    {
        public string Série { get; set; }
        public string SerieTurma { get; set; }
        public List<Aluno> Alunos { get; set; }
        public bool IsAtivo { get; set; }
    }
}
