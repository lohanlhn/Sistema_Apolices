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

                obj.id = reader.GetInt32(0);
                obj.nome = reader.GetString(1);

                lstRetorno.Add(obj);

            }

            reader.Close();
            banco.FecharConexao();

            return lstRetorno;

        }

        public Marca Selecionar(Marca objEntrada)
        {
            SqlCommand cmd;

            ConexaoBanco banco = new ConexaoBanco();

            banco.AbrirConexao();

            cmd = new SqlCommand("SELECT id, nome FROM marca WHERE id = @id");

            cmd.Parameters.Add(new SqlParameter("@id", objEntrada.id));

            SqlDataReader reader = banco.Pesquisar(cmd);
            reader.Read();

            Marca obj = new Marca();

            obj.id = reader.GetInt32(0);
            obj.nome = reader.GetString(1);

            reader.Close();

            Modelo modelo = new Modelo();
            modelo.marca = new Marca();
            modelo.marca.id = objEntrada.id;

            obj.modelos = new ModeloService().Listar(modelo);

            //cmd = new SqlCommand("SELECT id, nome FROM modelo WHERE marca_id = @marca_id");

            //cmd.Parameters.Add(new SqlParameter("@marca_id", objEntrada.id));

            //reader = banco.Pesquisar(cmd);

            //obj.modelos = new List<Modelo>();

            //while (reader.Read())
            //{

            //    Modelo modelo = new Modelo();                

            //    modelo.id = reader.GetInt32(0);
            //    modelo.nome = reader.GetString(1);

            //    obj.modelos.Add(modelo);

            //}

            reader.Close();
            

            banco.FecharConexao();

            return obj;
        }
    }
}
