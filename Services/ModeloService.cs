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
            if (objEntrada.marca.id > 0)
            {
                cmd = new SqlCommand("SELECT id, marca_id, nome FROM modelo WHERE marca_id = @marca_id");

                cmd.Parameters.Add(new SqlParameter("@marca_id", objEntrada.marca.id));

                banco.AbrirConexao();
                reader = banco.Pesquisar(cmd);

                while (reader.Read())
                {

                    Modelo obj = new Modelo();
                    obj.marca = new Marca();

                    obj.id = reader.GetInt32(0);
                    obj.marca.id = reader.GetInt32(1);
                    obj.nome = reader.GetString(2);

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
                    obj.marca = new Marca();

                    obj.id = reader.GetInt32(0);
                    obj.marca.id = reader.GetInt32(1);
                    obj.marca.nome = reader.GetString(2);
                    obj.nome = reader.GetString(3);

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


            cmd.Parameters.Add(new SqlParameter("@nome", objEntrada.nome));
            cmd.Parameters.Add(new SqlParameter("@marca_id", objEntrada.marca.id));

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();
            banco.Executar(cmd);
            banco.FecharConexao();
        }
        public void Alterar(Modelo objEntrada)
        {
            SqlCommand cmd = new SqlCommand("UPDATE modelo SET nome = @nome, marca_id = @marca_id " +
                                            "WHERE id = @id");

            cmd.Parameters.Add(new SqlParameter("@id", objEntrada.id));
            cmd.Parameters.Add(new SqlParameter("@nome", objEntrada.nome));
            cmd.Parameters.Add(new SqlParameter("@marca_id", objEntrada.marca.id));

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();
            banco.Executar(cmd);
            banco.FecharConexao();
        }
    }
}
