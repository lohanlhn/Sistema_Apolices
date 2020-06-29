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
        public Carro Selecionar(Carro objEntrada)
        {
            return new CarroService().Selecionar(objEntrada);
        }
        public void Inserir(Carro objEntrada)
        {
            Consistir(objEntrada);
            new CarroService().Inserir(objEntrada);
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
            if(objEntrada.Chassi.Trim().Length < 17)
            {
                throw new ConsistenciaException("Por favor, preencha o campo Chassi completamente");
            }
            if (objEntrada.Renavam.Trim().Length < 11)
            {
                throw new ConsistenciaException("Por favor, preencha o campo Renavam completamente");
            }
            if(objEntrada.Placa.Trim().Length < 7)
            {
                throw new ConsistenciaException("Por favor, preencha o campo Placa completamente");
            }
        }
    }
}
