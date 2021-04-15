using CadEscola._2_Domain.Entities;
using CadEscola._2_Domain.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadEscola._4_Infra._4._1_Data.Repository
{
    public class EscolaRepository : IEscolaRepository
    {
        private readonly IMongoCollection<Escola> _escolas;

        public EscolaRepository(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _escolas = database.GetCollection<Escola>(settings.EscolasCollectionName);
        }

        public async Task<List<Escola>> Get() => await _escolas.FindSync(escola => true).ToListAsync();

        public async Task<Escola> Get(string id) => await _escolas.FindSync<Escola>(escola => escola.Id == id).FirstOrDefaultAsync();

        public async Task<Escola> Create(Escola escola)
        {
            try
            {
                await _escolas.InsertOneAsync(escola);
            }
            catch(Exception ex)
            {
                
            }
            return escola;
        }

        public async void Update(string id, Escola escolaIn) => await _escolas.ReplaceOneAsync(escola => escola.Id == id, escolaIn);

        public async void Remove(Escola escolaIn) => await _escolas.DeleteOneAsync(escola => escola.Id == escolaIn.Id);

        public async void Remove(string id) => await _escolas.DeleteOneAsync(escola => escola.Id == id);
    }
}
