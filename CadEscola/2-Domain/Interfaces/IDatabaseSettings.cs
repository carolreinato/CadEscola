using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadEscola._2_Domain.Interfaces
{
    public interface IDatabaseSettings
    {
        string EscolasCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
