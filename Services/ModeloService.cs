using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ModeloService
    {
        public List<Modelo> Listar(Modelo objEntrada)
        {
            SqlCommand cmd = new SqlCommand();
            ConexaoBanco banco = new ConexaoBanco();
            SqlDataReader reader;
            List<Modelo> lstRetorno = new List<Modelo>();
            
            if (objEntrada.Marca.Id > 0)
            {
                cmd = new SqlCommand("SELECT id, marca_id, nome FROM modelo WHERE marca_id = @marca_id");

                cmd.Parameters.Add(new SqlParameter("@marca_id", objEntrada.Marca.Id));

                banco.AbrirConexao();
                reader = banco.Pesquisar(cmd);

                while (reader.Read())
                {

                    Modelo obj = new Modelo();
                    obj.Marca = new Marca();

                    obj.Id = reader.GetInt32(0);
                    obj.Marca.Id = reader.GetInt32(1);
                    obj.Nome = reader.GetString(2);

                    lstRetorno.Add(obj);

                }
            }
            else
            {
                cmd = new SqlCommand("SELECT modelo.id, marca.id, marca.nome, modelo.nome FROM modelo " +
                                     "INNER JOIN marca on marca.id = modelo.marca_id");

                banco.AbrirConexao();
                reader = banco.Pesquisar(cmd);

                while (reader.Read())
                {

                    Modelo obj = new Modelo();
                    obj.Marca = new Marca();

                    obj.Id = reader.GetInt32(0);
                    obj.Marca.Id = reader.GetInt32(1);
                    obj.Marca.Nome = reader.GetString(2);
                    obj.Nome = reader.GetString(3);

                    lstRetorno.Add(obj);

                }
            }
            
            
            reader.Close();
            banco.FecharConexao();

            return lstRetorno;

        }

        public void Inserir(Modelo objEntrada)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO modelo(nome, marca_id) " +
                                            "VALUES (@nome, @marca_id)");


            cmd.Parameters.Add(new SqlParameter("@nome", objEntrada.Nome));
            cmd.Parameters.Add(new SqlParameter("@marca_id", objEntrada.Marca.Id));

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();
            banco.Executar(cmd);
            banco.FecharConexao();
        }
        public void Alterar(Modelo objEntrada)
        {
            SqlCommand cmd = new SqlCommand("UPDATE modelo SET nome = @nome, marca_id = @marca_id " +
                                            "WHERE id = @id");

            cmd.Parameters.Add(new SqlParameter("@id", objEntrada.Id));
            cmd.Parameters.Add(new SqlParameter("@nome", objEntrada.Nome));
            cmd.Parameters.Add(new SqlParameter("@marca_id", objEntrada.Marca.Id));

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();
            banco.Executar(cmd);
            banco.FecharConexao();
        }
    }
}
