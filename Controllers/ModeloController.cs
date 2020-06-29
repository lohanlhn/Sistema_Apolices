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
    public class ModeloController
    {
        public List<Modelo> Listar()
        {
            return new ModeloService().Listar();
        }
        public List<Modelo> ListarPorMarcaId(int marcaId)
        {
            return new ModeloService().ListarPorMarcaId(marcaId);
        }
        public void Inserir(Modelo objEntrada)
        {
            Consistir(objEntrada);
            new ModeloService().Inserir(objEntrada);
        }
        public void Alterar(Modelo objEntrada)
        {
            Consistir(objEntrada);
            new ModeloService().Alterar(objEntrada);
        }
        void Consistir(Modelo objEntrada)
        {            
            if (string.IsNullOrWhiteSpace(objEntrada.Nome))
            {
                throw new ConsistenciaException("Por favor, preencha o nome do modelo");
            }
            if (objEntrada.Marca.Id <= 0)
            {
                throw new ConsistenciaException("Por favor, escolha a marca");
            }
        }

    }
}
