﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Carro
    {
        public int Id { get; set; }
        public string Chassi { get; set; }
        public string Placa { get; set; }
        public string Renavam { get; set; }
        public Modelo Modelo { get; set; }
    }
}
