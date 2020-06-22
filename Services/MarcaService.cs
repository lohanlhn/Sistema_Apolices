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

                obj.Id = reader.GetInt32(0);
                obj.Nome = reader.GetString(1);

                lstRetorno.Add(obj);

            }

            reader.Close();
            banco.FecharConexao();

            return lstRetorno;

        }

        public void Inserir(Marca objEntrada)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO marca(nome) " +
                                            "VALUES (@nome)");


            cmd.Parameters.Add(new SqlParameter("@nome", objEntrada.Nome));            

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();
            banco.Executar(cmd);
            banco.FecharConexao();
        }
        public void Alterar(Marca objEntrada)
        {
            SqlCommand cmd = new SqlCommand("UPDATE marca SET nome = @nome " +
                                            "WHERE id = @id");

            cmd.Parameters.Add(new SqlParameter("@id", objEntrada.Id));
            cmd.Parameters.Add(new SqlParameter("@nome", objEntrada.Nome));

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();
            banco.Executar(cmd);
            banco.FecharConexao();
        }
    }
}
