using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class ConsistenciaException : Exception
    {

        public String Mensagem { get; set; }

        public ConsistenciaException(String Mensagem)
        {
            this.Mensagem = Mensagem;
        }

    }
}
