﻿using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Controllers
{
    public class ApoliceController
    {
        public List<Apolice> Listar(Apolice objEntrada)
        {
            return new ApoliceService().Listar(objEntrada);
        }

        public Apolice Selecionar(Apolice objEntrada)
        {
            return new ApoliceService().Selecionar(objEntrada);
        }

        public void Inserir(Apolice objEntrada)
        {
            Consistir(objEntrada);
            new ApoliceService().Inserir(objEntrada);
        }

        public void Alterar(Apolice objEntrada)
        {
            Consistir(objEntrada);
            new ApoliceService().Alterar(objEntrada);
        }
        void Consistir(Apolice objEntrada)
        {
            if (objEntrada.DtInicio >= objEntrada.DtFim)
            {
                throw new ConsistenciaException("Por favor, Início da vigência deve ser menor que o campo Fim da vigência");
            }
            if(objEntrada.ValorFranquia == 0)
            {
                throw new ConsistenciaException("Por favor, preencha o campo Valor da Franquia");
            }
            if (objEntrada.ValorPremio == 0)
            {
                throw new ConsistenciaException("Por favor, preencha o campo Valor da Prêmio");
            }
            if(objEntrada.ValorPremio <= objEntrada.ValorFranquia)
            {
                throw new ConsistenciaException("O valor do prêmio deve ser maior que o valor da franquia");
            }
        }
    }
}
