using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class DataGridException : Exception
    {
        public String Mensagem { get; set; }

        public DataGridException(String Mensagem)
        {
            this.Mensagem = Mensagem;
        }
    }
}
