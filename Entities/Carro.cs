using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Carro
    {
        public int id { get; set; }
        public string chassi { get; set; }
        public string placa { get; set; }
        public string renavam { get; set; }
        public Modelo modelo { get; set; }
    }
}
