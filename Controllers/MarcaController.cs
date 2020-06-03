using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class MarcaController
    {
        public List<Marca> Listar()
        {
            return new MarcaService().Listar();
        }
    }
}
