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

            SqlCommand cmd = new SqlCommand("SELECT carro.id, marca.nome, modelo.nome, chassi, placa, renavam FROM carro " +
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
                obj.renavam = reader.GetString(5);


                lstRetorno.Add(obj);

            }

            reader.Close();
            banco.FecharConexao();

            return lstRetorno;

        }

        public void Inserir(Carro objEntrada)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO carro(modelo_id, chassi, placa, renavam) " +
                                            "VALUES (@modelo_id, @chassi, @placa, @renavam)");
            

            cmd.Parameters.Add(new SqlParameter("@modelo_id", objEntrada.modelo.id));
            cmd.Parameters.Add(new SqlParameter("@chassi", objEntrada.chassi));
            cmd.Parameters.Add(new SqlParameter("@placa", objEntrada.placa));
            cmd.Parameters.Add(new SqlParameter("@renavam", objEntrada.renavam));

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();
            banco.Executar(cmd);
            banco.FecharConexao();            
        }

        public Carro Selecionar(Carro objEntrada)
        {
            SqlCommand cmd;

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();

            cmd = new SqlCommand("SELECT id, modelo_id, chassi, placa, renavam FROM carro WHERE id = @id");

            cmd.Parameters.Add(new SqlParameter("@id", objEntrada.id));

            SqlDataReader reader = banco.Pesquisar(cmd);
            reader.Read();

            Carro obj = new Carro();
            obj.modelo = new Modelo();

            obj.id = reader.GetInt32(0);
            obj.modelo.id = reader.GetInt32(1);
            obj.chassi = reader.GetString(2);
            obj.placa= reader.GetString(3);
            obj.renavam= reader.GetString(4);

            reader.Close();
            #region Carrega marca atraves do modelo
            cmd = new SqlCommand("SELECT marca_id FROM modelo WHERE id = @modelo_id");

            cmd.Parameters.Add(new SqlParameter("@modelo_id", obj.modelo.id));

            reader = banco.Pesquisar(cmd);
            reader.Read();

            obj.modelo.marca = new Marca();

            obj.modelo.marca.id = reader.GetInt32(0);
            #endregion


            reader.Close();
            banco.FecharConexao();

            return obj;
        }

        public void Alterar(Carro objEntrada)
        {
            SqlCommand cmd = new SqlCommand("UPDATE carro SET modelo_id = @modelo_id, chassi = @chassi, placa = @placa, renavam = @renavam " +
                                            "WHERE id = @id");

            cmd.Parameters.Add(new SqlParameter("@id", objEntrada.id));
            cmd.Parameters.Add(new SqlParameter("@modelo_id", objEntrada.modelo.id));
            cmd.Parameters.Add(new SqlParameter("@chassi", objEntrada.chassi));
            cmd.Parameters.Add(new SqlParameter("@placa", objEntrada.placa));
            cmd.Parameters.Add(new SqlParameter("@renavam", objEntrada.renavam));

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();
            banco.Executar(cmd);
            banco.FecharConexao();
        }
    }
}
