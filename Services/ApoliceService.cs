using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ApoliceService
    {
        public List<Apolice> Listar()
        {

            SqlCommand cmd = new SqlCommand("SELECT id, dt_inicio, dt_fim, vl_franquia, vl_premio from apolice");

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();
            SqlDataReader reader = banco.Pesquisar(cmd);

            List<Apolice> lstRetorno = new List<Apolice>();

            while (reader.Read())
            {

                Apolice obj = new Apolice();

                obj.id = reader.GetInt32(0);
                obj.dtInicio = reader.GetDateTime(1);
                obj.dtFim = reader.GetDateTime(2);
                obj.valorFranquia = reader.GetDecimal(3);
                obj.valorPremio = reader.GetDecimal(4);

                lstRetorno.Add(obj);

            }

            reader.Close();
            banco.FecharConexao();

            return lstRetorno;

        }
    }
}
