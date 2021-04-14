using CadEscola._2_Domain.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadEscola._2_Domain.Entities
{
    public class Escola
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string NomeEscola { get; set; }
        public string Bairro { get; set; }
        public List<Turma> Turmas { get; set; }
    }
}
