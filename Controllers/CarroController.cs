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
    public class CarroController
    {
        public List<Carro> Listar()
        {
            return new CarroService().Listar();
        }

        public void Inserir(Carro objEntrada)
        {
            Consistir(objEntrada);
            new CarroService().Inserir(objEntrada);
        }

        public Carro Selecionar(Carro objEntrada)
        {
            return new CarroService().Selecionar(objEntrada);
        }

        public void Alterar(Carro objEntrada)
        {
            Consistir(objEntrada);
            new CarroService().Alterar(objEntrada);
        }

        void Consistir(Carro objEntrada)
        {
            if (objEntrada.modelo.marca.id <= 0)
            {
                throw new ConsistenciaException("Por favor, selecione uma marca");
            }
            if (objEntrada.modelo.id <= 0)
            {
                throw new ConsistenciaException("Por favor, selecione um modelo");
            }
            if (String.IsNullOrEmpty(objEntrada.chassi))
            {
                throw new ConsistenciaException("Por favor, preencha o campo Chassi");
            }
            if (String.IsNullOrEmpty(objEntrada.placa))
            {
                throw new ConsistenciaException("Por favor, preencha o campo Placa");
            }
            if (String.IsNullOrEmpty(objEntrada.renavam))
            {
                throw new ConsistenciaException("Por favor, preencha o campo Renavam");
            }
        }
    }
}
