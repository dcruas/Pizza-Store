using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class ItemPedidoDAL
    {
        SqlConnection conexao;
      

        public List<ItemPedido> MostrarItemPedido(int codpedido)
        {
            List<ItemPedido> ItensPedidos = new List<ItemPedido>();

            string SQL;
            try
            {
                try
                {
                    conexao = new SqlConnection(@"Data Source = DESKTOP-UTR2P7O\SQLEXPRESS; Initial Catalog = DB_PIZZARIA; Integrated Security = True");

                    SQL = "SELECT ITEM.CD_ITEMPEDIDO, ITEM.CD_PRODUTO, ITEM.CD_PEDIDO, PROD.NM_PRODUTO, PROD.VL_PRODUTO, ITEM.NR_QUANTIDADE FROM TB_ITEMPEDIDO ITEM INNER JOIN TB_PRODUTO PROD ON ITEM.CD_PRODUTO = PROD.CD_PRODUTO INNER JOIN TB_PEDIDO PED ON ITEM.CD_PEDIDO = PED.CD_PEDIDO WHERE ITEM.CD_PEDIDO = '" + codpedido + "'ORDER BY CD_ITEMPEDIDO";

                    SqlCommand comando = new SqlCommand(SQL, conexao);

                    SqlDataReader dr;

                    conexao.Open();

                    dr = comando.ExecuteReader();

                    while (dr.Read())
                    {
                        ItemPedido item = new ItemPedido();


                        
                        item.codigo = Convert.ToInt32(dr["CD_ITEMPEDIDO"]);
                        item.codpedido= Convert.ToInt32(dr["CD_PEDIDO"]);
                        item.codproduto = Convert.ToInt32(dr["CD_PRODUTO"]);
                        item.nomeproduto = dr["NM_PRODUTO"].ToString();
                        item.valorproduto = Convert.ToDouble(dr["VL_PRODUTO"]);
                        item.quantidade = Convert.ToDouble(dr["NR_QUANTIDADE"]);
                       
                        
                        ItensPedidos.Add(item);

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

            return ItensPedidos;
        }

      
            public int IncluirItemPedido(ItemPedido item)
         {
             string SQL;
             SqlCommand comando;

             try
             {
                 conexao = new SqlConnection(@"Data Source = DESKTOP-UTR2P7O\SQLEXPRESS; Initial Catalog = DB_PIZZARIA; Integrated Security = True");


                 conexao.Open();

             
                 SQL = "INSERT TB_ITEMPEDIDO (CD_PRODUTO, CD_PEDIDO, NR_QUANTIDADE) VALUES ('" + item.codproduto +" ', '" + item.codpedido + "', '" + item.quantidade + "')";
               
                
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

             return item.codigo;
         }

        /* NÃO VAI USAR public void AtualizarItemPedido(ItemPedido item)
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
        }*/


        public void ExcluirItemPedido(int codigo)
        {
            string SQL;
            SqlCommand comando;

            try
            {
                conexao = new SqlConnection(@"Data Source = DESKTOP-UTR2P7O\SQLEXPRESS; Initial Catalog = DB_PIZZARIA; Integrated Security = True");

                SQL = "DELETE TB_ITEMPEDIDO WHERE CD_PEDIDO = " + codigo.ToString();

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


    }   }
}

