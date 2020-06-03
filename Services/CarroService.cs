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

            SqlCommand cmd = new SqlCommand("SELECT carro.id, marca.nome, modelo.nome, chassi, placa, renavam nome FROM carro " +
                                            "INNER JOIN modelo on modelo.id = carro.modelo_id " +
                                            "INNER JOIN marca on marca.id = modelo.marca_id ");

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();
            SqlDataReader reader = banco.Pesquisar(cmd);

            List<Carro> lstRetorno = new List<Carro>();

            while (reader.Read())
            {

                Carro obj = new Carro();
                obj.modelo = new Modelo();
                obj.modelo.marca = new Marca();

                obj.id = reader.GetInt32(0);
                obj.modelo.marca.nome = reader.GetString(1);
                obj.modelo.nome = reader.GetString(2);
                obj.chassi = reader.GetString(3);
                obj.placa = reader.GetString(4);
                obj.renavam = reader.GetInt32(5);


                lstRetorno.Add(obj);

            }

            reader.Close();
            banco.FecharConexao();

            return lstRetorno;

        }
    }
}
