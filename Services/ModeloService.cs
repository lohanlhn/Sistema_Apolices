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

            SqlCommand cmd = new SqlCommand("SELECT id, marca_id, nome FROM modelo WHERE marca_id = @marca_id");

            cmd.Parameters.Add(new SqlParameter("@marca_id", objEntrada.marca.id));

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();
            SqlDataReader reader = banco.Pesquisar(cmd);

            List<Modelo> lstRetorno = new List<Modelo>();

            while (reader.Read())
            {

                Modelo obj = new Modelo();
                obj.marca = new Marca();

                obj.id = reader.GetInt32(0);
                obj.marca.id = reader.GetInt32(1);
                obj.nome = reader.GetString(2);

                lstRetorno.Add(obj);

            }

            reader.Close();
            banco.FecharConexao();

            return lstRetorno;

        }
    }
}
