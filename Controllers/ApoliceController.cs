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

        public Apolice Selecionar(Apolice objEntrada)
        {
            return new ApoliceService().Selecionar(objEntrada);
        }

        public void Inserir(Apolice objEntrada)
        {
            new ApoliceService().Inserir(objEntrada);
        }

        public void Alterar(Apolice objEntrada)
        {
            new ApoliceService().Alterar(objEntrada);
        }
    }
}
