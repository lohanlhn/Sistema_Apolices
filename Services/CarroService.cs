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
                obj.Modelo = new Modelo();
                obj.Modelo.Marca = new Marca();

                obj.Id = reader.GetInt32(0);
                obj.Modelo.Marca.Nome = reader.GetString(1);
                obj.Modelo.Nome = reader.GetString(2);
                obj.Chassi = reader.GetString(3);
                obj.Placa = reader.GetString(4);
                obj.Renavam = reader.GetString(5);


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
            

            cmd.Parameters.Add(new SqlParameter("@modelo_id", objEntrada.Modelo.Id));
            cmd.Parameters.Add(new SqlParameter("@chassi", objEntrada.Chassi));
            cmd.Parameters.Add(new SqlParameter("@placa", objEntrada.Placa));
            cmd.Parameters.Add(new SqlParameter("@renavam", objEntrada.Renavam));

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

            cmd = new SqlCommand("SELECT carro.id, modelo.id, modelo.nome, marca.id, marca.nome, chassi, placa, renavam FROM carro " +
                                 "INNER JOIN modelo on modelo.id = carro.modelo_id " +
                                 "INNER JOIN marca on marca.id = modelo.marca_id " +
                                 "WHERE carro.id = @id");

            cmd.Parameters.Add(new SqlParameter("@id", objEntrada.Id));

            SqlDataReader reader = banco.Pesquisar(cmd);
            reader.Read();

            Carro obj = new Carro();
            obj.Modelo = new Modelo();
            obj.Modelo.Marca = new Marca();

            obj.Id = reader.GetInt32(0);
            obj.Modelo.Id = reader.GetInt32(1);
            obj.Modelo.Nome = reader.GetString(2);
            obj.Modelo.Marca.Id = reader.GetInt32(3);
            obj.Modelo.Marca.Nome = reader.GetString(4);
            obj.Chassi = reader.GetString(5);
            obj.Placa = reader.GetString(6);
            obj.Renavam = reader.GetString(7);                       

            reader.Close();
            banco.FecharConexao();

            return obj;
        }

        public void Alterar(Carro objEntrada)
        {
            SqlCommand cmd = new SqlCommand("UPDATE carro SET modelo_id = @modelo_id, chassi = @chassi, placa = @placa, renavam = @renavam " +
                                            "WHERE id = @id");

            cmd.Parameters.Add(new SqlParameter("@id", objEntrada.Id));
            cmd.Parameters.Add(new SqlParameter("@modelo_id", objEntrada.Modelo.Id));
            cmd.Parameters.Add(new SqlParameter("@chassi", objEntrada.Chassi));
            cmd.Parameters.Add(new SqlParameter("@placa", objEntrada.Placa));
            cmd.Parameters.Add(new SqlParameter("@renavam", objEntrada.Renavam));

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();
            banco.Executar(cmd);
            banco.FecharConexao();
        }
    }
}
