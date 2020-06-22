using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Apolice
    {
        public int Id { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
        public decimal ValorFranquia { get; set; }
        public decimal ValorPremio { get; set; }
        public Carro Carro { get; set; }
    }
}
