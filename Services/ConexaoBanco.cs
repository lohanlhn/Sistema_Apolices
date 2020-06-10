using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ConexaoBanco
    {
        SqlConnection con = new SqlConnection();
        public ConexaoBanco()
        {
            //Casa
            con.ConnectionString = @"Data Source=DESKTOP-T0AKLBR\SQLEXPRESS;Initial Catalog=bd_apolice;Integrated Security=True";
            //Trabalho
            //con.ConnectionString = @"Data Source = TI01\SQLEXPRESS; Initial Catalog = bd_apolice; Integrated Security = True";
        }

        public void AbrirConexao()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
        }

        public void FecharConexao()
        {
            if (con.State != ConnectionState.Closed)
                con.Close();
        }

        public SqlDataReader Pesquisar(SqlCommand cmd)
        {
            try
            {

                cmd.Connection = con;
                return cmd.ExecuteReader();

            }
            catch
            {
                FecharConexao();
                throw;
            }
        }

        public void Executar(SqlCommand cmd)
        {
            try
            {
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
            catch
            {
                FecharConexao();
                    throw;
            }
        }
    }
}
