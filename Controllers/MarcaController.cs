using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Controllers
{
    public class MarcaController
    {
        public List<Marca> Listar()
        {
            return new MarcaService().Listar();
        }
        public void Inserir(Marca objEntrada)
        {
            Consistir(objEntrada);
            new MarcaService().Inserir(objEntrada);
        }

        public void Alterar(Marca objEntrada)
        {
            Consistir(objEntrada);
            new MarcaService().Alterar(objEntrada);
        }

        void Consistir(Marca objEntrada)
        {
            if (string.IsNullOrEmpty(objEntrada.nome))
            {
                throw new ConsistenciaException("Por favor, preencha o nome da marca");
            }
        }
    }
}
