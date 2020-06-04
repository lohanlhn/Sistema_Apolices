using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ModeloController
    {
        public List<Modelo> Listar(Modelo objEntrada)
        {
            return new ModeloService().Listar(objEntrada);
        }
    }
}
