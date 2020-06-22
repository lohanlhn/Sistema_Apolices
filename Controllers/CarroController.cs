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
            if (objEntrada.Modelo.Marca.Id <= 0)
            {
                throw new ConsistenciaException("Por favor, selecione uma marca");
            }
            if (objEntrada.Modelo.Id <= 0)
            {
                throw new ConsistenciaException("Por favor, selecione um modelo");
            }
            if (String.IsNullOrEmpty(objEntrada.Chassi))
            {
                throw new ConsistenciaException("Por favor, preencha o campo Chassi");
            }
            if (String.IsNullOrEmpty(objEntrada.Placa))
            {
                throw new ConsistenciaException("Por favor, preencha o campo Placa");
            }
            if(objEntrada.Placa.Length < 7)
            {
                throw new ConsistenciaException("Por favor, preencha o campo Placa completamente");
            }
            if (String.IsNullOrEmpty(objEntrada.Renavam))
            {
                throw new ConsistenciaException("Por favor, preencha o campo Renavam");
            }
        }
    }
}
