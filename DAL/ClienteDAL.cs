using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class ClienteDAL
    {
        SqlConnection conexao;
        



        public Cliente ConsultarCliente(int telefone)
        {
            Cliente cliente = new Cliente();

            string SQL;
            try
            {
                try
                {
                    conexao = new SqlConnection(@"Data Source = DESKTOP-UTR2P7O\SQLEXPRESS; Initial Catalog = DB_PIZZARIA; Integrated Security = True");

                  
                    SQL = "SELECT CD_CLIENTE, NM_CLIENTE, NR_TELEFONE, ENDERECO FROM TB_CLIENTE WHERE NR_TELEFONE = '" + telefone + "' ORDER BY CD_CLIENTE";
                   

                  
                    SqlCommand comando = new SqlCommand(SQL, conexao);

                    SqlDataReader dr;

                    conexao.Open();

                    dr = comando.ExecuteReader();

                    while (dr.Read())
                    {
                       
                       
                        

                       cliente.codigo = Convert.ToInt32(dr["CD_CLIENTE"]);
                       cliente.nome = dr["NM_CLIENTE"].ToString();
                       cliente.telefone = Convert.ToInt32(dr["NR_TELEFONE"]);
                       cliente.endereco = dr["ENDERECO"].ToString();
                        
                      
                                                                  
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            finally
            {
                       
                conexao.Close();
            }

            return cliente;
        }

        public List<Cliente> MostrarCliente()
        {
            List<Cliente> Clientes = new List<Cliente>();

            string SQL;
            
            try
            {
                try
                {
                    
                    conexao = new SqlConnection(@"Data Source = DESKTOP-UTR2P7O\SQLEXPRESS; Initial Catalog = DB_PIZZARIA; Integrated Security = True");

                    SQL = "SELECT CD_CLIENTE, NM_CLIENTE, NR_TELEFONE, ENDERECO FROM TB_CLIENTE ORDER BY CD_CLIENTE";

                    SqlCommand comando = new SqlCommand(SQL, conexao);

                    SqlDataReader dr;

                    conexao.Open();

                    dr = comando.ExecuteReader();

                    while (dr.Read())
                    {
                        Cliente cliente = new Cliente();



                        cliente.codigo = Convert.ToInt32(dr["CD_CLIENTE"]);
                        cliente.nome = dr["NM_CLIENTE"].ToString();
                        cliente.telefone = Convert.ToInt32(dr["NR_TELEFONE"]);
                        cliente.endereco = dr["ENDERECO"].ToString();

                        Clientes.Add(cliente);

                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            finally
            {

                conexao.Close();
            }

            return Clientes;
        }

        public int IncluirCliente(Cliente cliente)
         {
             string SQL;
             SqlCommand comando;

             try
             {
                 conexao = new SqlConnection(@"Data Source = DESKTOP-UTR2P7O\SQLEXPRESS; Initial Catalog = DB_PIZZARIA; Integrated Security = True");


                 conexao.Open();

             
                 SQL = "INSERT TB_CLIENTE (NM_CLIENTE, NR_TELEFONE, ENDERECO) VALUES ('" + cliente.nome + "', '" + cliente.telefone + "', '" + cliente.endereco + "')";
               


                 comando = new SqlCommand(SQL, conexao);

                 comando.ExecuteNonQuery();
             }
             catch (Exception)
             {
                 throw;
             }
             finally
             {
                 conexao.Close();
             }

             return cliente.codigo;
         }

         public void AtualizarCliente(Cliente cliente)
         {
             string SQL;
             SqlCommand comando;

             try
             {
                 conexao = new SqlConnection(@"Data Source = DESKTOP-UTR2P7O\SQLEXPRESS; Initial Catalog = DB_PIZZARIA; Integrated Security = True");

                SQL = "UPDATE TB_CLIENTE SET NM_CLIENTE= '" + cliente.nome + "', NR_TELEFONE = '" + cliente.telefone + "', ENDERECO = '" + cliente.endereco + "' WHERE CD_CLIENTE = " + cliente.codigo;

                 comando = new SqlCommand(SQL, conexao);

                 conexao.Open();

                 comando.ExecuteNonQuery();
             }
             catch (Exception)
             {
                 throw;
             }
             finally
             {
                 conexao.Close();
             }
         }

        
          public void ExcluirCliente(int codigo)
        {
            string SQL;
            SqlCommand comando;

            try
            {
                conexao = new SqlConnection(@"Data Source = DESKTOP-UTR2P7O\SQLEXPRESS; Initial Catalog = DB_PIZZARIA; Integrated Security = True");

                SQL = "DELETE TB_CLIENTE WHERE CD_CLIENTE = " + codigo.ToString();

                comando = new SqlCommand(SQL, conexao);

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
        }
    } 
}

