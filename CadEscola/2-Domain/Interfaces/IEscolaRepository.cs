using CadEscola._2_Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadEscola._2_Domain.Interfaces
{
    public interface IEscolaRepository
    {
        Task<Escola> Create(Escola escola);
        Task<List<Escola>> Get();
        Task<Escola> Get(string id);
        void Remove(Escola escolaIn);
        void Remove(string id);
        void Update(string id, Escola escolaIn);
    }
}