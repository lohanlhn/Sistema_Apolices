using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class ApoliceController
    {
        public List<Apolice> Listar()
        {
            return new ApoliceService().Listar();
        }
    }
}
