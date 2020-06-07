using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MarcaService
    {
        public List<Marca> Listar()
        {

            SqlCommand cmd = new SqlCommand("SELECT id, nome FROM marca");

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();
            SqlDataReader reader = banco.Pesquisar(cmd);

            List<Marca> lstRetorno = new List<Marca>();

            while (reader.Read())
            {

                Marca obj = new Marca();

                obj.id = reader.GetInt32(0);
                obj.nome = reader.GetString(1);

                lstRetorno.Add(obj);

            }

            reader.Close();
            banco.FecharConexao();

            return lstRetorno;

        }
        
    }
}
