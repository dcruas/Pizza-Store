using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class PedidoDAL
    {
        SqlConnection conexao;
        string caminho = "@"/"Data Source = DESKTOP-UTR2P7O\SQLEXPRESS; Initial Catalog = DB_PIZZARIA; Integrated Security = True"/"";

        public List<Pedido> MostrarTodosPedidos()
        {
            List<Pedido> Pedidos = new List<Pedido>();
            string SQL;
            try
            {
                try
                {
                    conexao = new SqlConnection(@"Data Source = DESKTOP-UTR2P7O\SQLEXPRESS; Initial Catalog = DB_PIZZARIA; Integrated Security = True");

                    SQL = "SELECT P.CD_PEDIDO, P.DT_PEDIDO, C.NM_CLIENTE, C.ENDERECO, C.NR_TELEFONE, P.CD_CLIENTE, P.DS_OBSERVACAO, P.NR_STATUS, P.VL_TOTAL FROM TB_PEDIDO P INNER JOIN TB_CLIENTE C ON P.CD_CLIENTE = C.CD_CLIENTE ORDER BY P.CD_PEDIDO ";


                    SqlCommand comando = new SqlCommand(SQL, conexao);

                    SqlDataReader dr;

                    conexao.Open();

                    dr = comando.ExecuteReader();

                    while (dr.Read())
                    {
                        Pedido pedido = new Pedido();



                        
                        pedido.pedido = Convert.ToInt32(dr["CD_PEDIDO"]);
                        pedido.datapedido = dr["DT_PEDIDO"].ToString();
                        pedido.cd_cliente = Convert.ToInt32(dr["CD_CLIENTE"]);
                        pedido.nm_cliente = dr["NM_CLIENTE"].ToString();
                        pedido.endereco = dr["ENDERECO"].ToString();
                        pedido.telefone = Convert.ToInt32(dr["NR_TELEFONE"]);
                        pedido.observacao = dr["DS_OBSERVACAO"].ToString();
                        pedido.status = dr["NR_STATUS"].ToString();
                        pedido.valortotal = Convert.ToDouble(dr["VL_TOTAL"]);


                        if (pedido.status == "1")
                        {
                            pedido.status = "ABERTO";

                        }
                        else if (pedido.status == "2")
                            pedido.status = "FECHADO";
                        else
                            pedido.status = "CANCELADO";

                        Pedidos.Add(pedido);

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

            return Pedidos;
        }

        public List<Pedido> MostrarPedidos(int codcliente)
        {
            List<Pedido> Pedidos = new List<Pedido>();
            string SQL;
            try
            {
                try
                {
                    conexao = new SqlConnection(@"Data Source = DESKTOP-UTR2P7O\SQLEXPRESS; Initial Catalog = DB_PIZZARIA; Integrated Security = True");
                    
                    SQL = "SELECT P.CD_PEDIDO, P.DT_PEDIDO, C.NM_CLIENTE, C.NR_TELEFONE, P.CD_CLIENTE, P.DS_OBSERVACAO, P.NR_STATUS, P.VL_TOTAL FROM TB_PEDIDO P INNER JOIN TB_CLIENTE C ON P.CD_CLIENTE = C.CD_CLIENTE WHERE P.CD_CLIENTE = '" + codcliente + "' ORDER BY P.CD_PEDIDO ";
                  

                    SqlCommand comando = new SqlCommand(SQL, conexao);

                    SqlDataReader dr;

                    conexao.Open();

                    dr = comando.ExecuteReader();

                    while (dr.Read())
                    {
                        Pedido pedido = new Pedido();
                        

                                             
                        
                        pedido.pedido = Convert.ToInt32(dr["CD_PEDIDO"]);
                        pedido.datapedido = dr["DT_PEDIDO"].ToString();
                        pedido.cd_cliente = Convert.ToInt32(dr["CD_CLIENTE"]);
                        pedido.observacao = dr["DS_OBSERVACAO"].ToString();
                        pedido.status = dr["NR_STATUS"].ToString();
                        pedido.valortotal = Convert.ToDouble(dr["VL_TOTAL"]);

                        if (pedido.status == "1")
                        {
                            pedido.status = "ABERTO";

                        }
                        else if (pedido.status == "2")
                            pedido.status = "FECHADO";
                        else
                            pedido.status = "CANCELADO";

                        Pedidos.Add(pedido);
                                                                  
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

            return Pedidos;
        }

         public int IncluirPedido(Pedido pedido)
         {
             string SQL;
             SqlCommand comando;
            

             try
             {
                conexao = new SqlConnection(@"Data Source = DESKTOP-UTR2P7O\SQLEXPRESS; Initial Catalog = DB_PIZZARIA; Integrated Security = True");


                 conexao.Open();


                SQL = "INSERT TB_PEDIDO(DT_PEDIDO, CD_CLIENTE, DS_OBSERVACAO, NR_STATUS, VL_TOTAL) VALUES ('" + Convert.ToDateTime(pedido.datapedido) + "', '" + pedido.cd_cliente + "', '" + pedido.observacao + "','" + int.Parse(pedido.status) + "', '" + pedido.valortotal + "');" + "Select Scope_Identity()";

                comando = new SqlCommand(SQL, conexao);

                pedido.pedido = Convert.ToInt32(comando.ExecuteScalar());


            }
             catch (Exception)
             {
                 throw;
             }
             finally
             {
                 conexao.Close();
             }

            return pedido.pedido;
         }

        public double FinalizarPedido(int codpedido)
        {
            string SQL;
            SqlCommand comando;
            double valortotal = 0;

            try
            {
                conexao = new SqlConnection(@"Data Source = DESKTOP-UTR2P7O\SQLEXPRESS; Initial Catalog = DB_PIZZARIA; Integrated Security = True");

                SQL = "UPDATE TB_PEDIDO SET VL_TOTAL = (SELECT SUM(PROD.VL_PRODUTO*ITEM.NR_QUANTIDADE) FROM TB_PRODUTO PROD INNER JOIN TB_ITEMPEDIDO ITEM ON PROD.CD_PRODUTO = ITEM.CD_PRODUTO WHERE ITEM.CD_PEDIDO = '"+ codpedido +"');" + "SELECT VL_TOTAL FROM TB_PEDIDO WHERE CD_PEDIDO = '"+codpedido+"'";

                comando = new SqlCommand(SQL, conexao);

                conexao.Open();

                SqlDataReader dr;

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    valortotal = Convert.ToDouble(dr["VL_TOTAL"]);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }
            return valortotal;
        }

        public void ExcluirPedido(int codigopedido)
        {
            string SQL;
            SqlCommand comando;

            try
            {
                conexao = new SqlConnection(@"Data Source = DESKTOP-UTR2P7O\SQLEXPRESS; Initial Catalog = DB_PIZZARIA; Integrated Security = True");

                SQL = "UPDATE TB_PEDIDO SET NR_STATUS = 3 WHERE CD_PEDIDO = '" + codigopedido + "'";
                    

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

