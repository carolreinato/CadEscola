using CadEscola._2_Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadEscola._2_Domain.Models
{
    public class EscolasDatabaseSettings : IDatabaseSettings
    {
        public string EscolasCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
