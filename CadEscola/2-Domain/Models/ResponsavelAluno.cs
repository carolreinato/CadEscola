using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadEscola._2_Domain.Models
{
    public class ResponsavelAluno
    {
        public string NomeResponsavel { get; set; }
        public string CPFResponsavel { get; set; }
        public string ContatoResponsavel { get; set; }
    }
}
