using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Modelo
    {
        public int id { get; set; }
        public string nome { get; set; }
        public Marca marca { get; set; }
    }
}
