using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Apolice
    {
        public int id { get; set; }
        public DateTime dtInicio { get; set; }
        public DateTime dtFim { get; set; }
        public decimal valorFranquia { get; set; }
        public decimal valorPremio { get; set; }
        public Carro carro { get; set; }
    }
}
