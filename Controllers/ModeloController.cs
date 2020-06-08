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
    public class ModeloController
    {
        public List<Modelo> Listar(Modelo objEntrada)
        {
            return new ModeloService().Listar(objEntrada);
        }
        public void Inserir(Modelo objEntrada)
        {
            Consistir(objEntrada);
            new ModeloController().Inserir(objEntrada);
        }

        public void Alterar(Modelo objEntrada)
        {
            Consistir(objEntrada);
            new ModeloService().Alterar(objEntrada);
        }
        void Consistir(Modelo objEntrada)
        {            
            if (string.IsNullOrEmpty(objEntrada.nome))
            {
                throw new ConsistenciaException("Por favor, preencha o nome do modelo");
            }
            if (objEntrada.marca.id <= 0)
            {
                throw new ConsistenciaException("Por favor, escolha a marca");
            }
        }

    }
}
