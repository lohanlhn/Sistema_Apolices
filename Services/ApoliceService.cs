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
        public List<Apolice> ListarPorCarroId(int carroId)
        {            

            SqlCommand cmd = new SqlCommand("SELECT id, dt_inicio, dt_fim, vl_franquia, vl_premio from apolice " +
                                            "WHERE carro_id = @carro_id");

            cmd.Parameters.Add(new SqlParameter("@carro_id", carroId));

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();
            SqlDataReader reader = banco.Pesquisar(cmd);

            List<Apolice> lstRetorno = new List<Apolice>();

            while (reader.Read())
            {

                Apolice obj = new Apolice();

                obj.Id = reader.GetInt32(0);
                obj.DtInicio = reader.GetDateTime(1);
                obj.DtFim = reader.GetDateTime(2);
                obj.ValorFranquia = reader.GetDecimal(3);
                obj.ValorPremio = reader.GetDecimal(4);

                lstRetorno.Add(obj);

            }

            reader.Close();
            banco.FecharConexao();

            return lstRetorno;

        }
        public Apolice Selecionar(Apolice objEntrada)
        {
            SqlCommand cmd;

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();

            cmd = new SqlCommand("SELECT id, dt_inicio, dt_fim, vl_franquia, vl_premio from apolice " +
                                 "WHERE id = @id");

            cmd.Parameters.Add(new SqlParameter("@id", objEntrada.Id));

            SqlDataReader reader = banco.Pesquisar(cmd);
            reader.Read();

            Apolice obj = new Apolice();

            obj.Id = reader.GetInt32(0);
            obj.DtInicio = reader.GetDateTime(1);
            obj.DtFim = reader.GetDateTime(2);
            obj.ValorFranquia = reader.GetDecimal(3);
            obj.ValorPremio = reader.GetDecimal(4);

            reader.Close();
            banco.FecharConexao();

            return obj;
        }
        public void Inserir(Apolice objEntrada)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO apolice(carro_id, dt_inicio, dt_fim, vl_franquia, vl_premio) " +
                                            "VALUES (@carro_id, @dt_inicio, @dt_fim, @vl_franquia, @vl_premio)");


            cmd.Parameters.Add(new SqlParameter("@carro_id", objEntrada.Carro.Id));
            cmd.Parameters.Add(new SqlParameter("@dt_inicio", objEntrada.DtInicio));
            cmd.Parameters.Add(new SqlParameter("@dt_fim", objEntrada.DtFim));
            cmd.Parameters.Add(new SqlParameter("@vl_franquia", objEntrada.ValorFranquia));
            cmd.Parameters.Add(new SqlParameter("@vl_premio", objEntrada.ValorPremio));

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();
            banco.Executar(cmd);
            banco.FecharConexao();
        }
        public void Alterar(Apolice objEntrada)
        {
            SqlCommand cmd = new SqlCommand("UPDATE apolice SET dt_inicio = @dt_inicio, dt_fim = @dt_fim, vl_franquia = @vl_franquia, vl_premio = @vl_premio " +
                                            "WHERE id = @id");

            cmd.Parameters.Add(new SqlParameter("@id", objEntrada.Id));
            cmd.Parameters.Add(new SqlParameter("@dt_inicio", objEntrada.DtInicio));
            cmd.Parameters.Add(new SqlParameter("@dt_fim", objEntrada.DtFim));
            cmd.Parameters.Add(new SqlParameter("@vl_franquia", objEntrada.ValorFranquia));
            cmd.Parameters.Add(new SqlParameter("@vl_premio", objEntrada.ValorPremio));

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();
            banco.Executar(cmd);
            banco.FecharConexao();
        }
    }
}
