using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class CarroController
    {
        public List<Carro> Listar()
        {
            return new CarroService().Listar();
        }
    }
}
