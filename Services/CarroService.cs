using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CarroService
    {
        public List<Carro> Listar()
        {

            SqlCommand cmd = new SqlCommand("SELECT id, modelo_id, chassi, placa, renavam nome FROM marca");

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();
            SqlDataReader reader = banco.Pesquisar(cmd);

            List<Carro> lstRetorno = new List<Carro>();

            while (reader.Read())
            {

                Carro obj = new Carro();

                obj.id = reader.GetInt32(0);
                obj.modelo.id = reader.GetInt32(1);
                obj.chassi = reader.GetString(2);
                obj.chassi = reader.GetString(3);
                obj.renavam = reader.GetInt32(4);

                lstRetorno.Add(obj);

            }

            reader.Close();
            banco.FecharConexao();

            return lstRetorno;

        }
    }
}
