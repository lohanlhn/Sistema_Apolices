using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Modelo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Marca Marca { get; set; }
    }
}
