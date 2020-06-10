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
        public void Inserir(Apolice objEntrada)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO apolice(carro_id, dt_inicio, dt_fim, vl_franquia, vl_premio) " +
                                            "VALUES (@carro_id, @dt_inicio, @dt_fim, @vl_franquia, @vl_premio)");


            cmd.Parameters.Add(new SqlParameter("@carro_id", objEntrada.carro.id));
            cmd.Parameters.Add(new SqlParameter("@dt_inicio", objEntrada.dtInicio));
            cmd.Parameters.Add(new SqlParameter("@dt_fim", objEntrada.dtFim));
            cmd.Parameters.Add(new SqlParameter("@vl_franquia", objEntrada.valorFranquia));
            cmd.Parameters.Add(new SqlParameter("@vl_premio", objEntrada.valorPremio));

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();
            banco.Executar(cmd);
            banco.FecharConexao();
        }
    }
}
