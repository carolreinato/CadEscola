using CadEscola._2_Domain.Entities;
using CadEscola._2_Domain.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadEscola._4_Infra._4._1_Data.Repository
{
    public class EscolaRepository
    {
        private readonly IMongoCollection<Escola> _escolas;

        public EscolaRepository(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _escolas = database.GetCollection<Escola>(settings.EscolasCollectionName);
        }

        public List<Escola> Get() => _escolas.Find(escola => true).ToList();

        public Escola Get(string id) => _escolas.Find<Escola>(escola => escola.Id == id).FirstOrDefault();

        public Escola Create(Escola escola)
        {
            _escolas.InsertOne(escola);
            return escola;
        }

        public void Update(string id, Escola escolaIn) => _escolas.ReplaceOne(aluno => aluno.Id == id, escolaIn);

        public void Remove(Escola escolaIn) => _escolas.DeleteOne(escola => escola.Id == escolaIn.Id);

        public void Remove(string id) => _escolas.DeleteOne(escola => escola.Id == id);
    }
}
