using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class ProdutoDAL
    {
        SqlConnection conexao;


        public List<Produto> MostrarProduto()
        {
            List<Produto> produtos = new List<Produto>();

            string SQL;
            try
            {
                try
                {
                    conexao = new SqlConnection(@"Data Source = DESKTOP-UTR2P7O\SQLEXPRESS; Initial Catalog = DB_PIZZARIA; Integrated Security = True");

                    SQL = "SELECT CD_PRODUTO, NM_PRODUTO, VL_PRODUTO FROM TB_PRODUTO";


                    SqlCommand comando = new SqlCommand(SQL, conexao);

                    SqlDataReader dr;

                    conexao.Open();

                    dr = comando.ExecuteReader();

                    while (dr.Read())
                    {
                        Produto produto = new Produto();



                        produto.codigo = Convert.ToInt32(dr["CD_PRODUTO"]);
                        produto.nome = dr["NM_PRODUTO"].ToString();
                        produto.valorproduto = Convert.ToInt32(dr["VL_PRODUTO"]);

                        produtos.Add(produto);



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

            return produtos;
        }

        public int IncluirProduto(Produto produto)
        {
            string SQL;
            SqlCommand comando;

            try
            {
                conexao = new SqlConnection(@"Data Source = DESKTOP-UTR2P7O\SQLEXPRESS; Initial Catalog = DB_PIZZARIA; Integrated Security = True");


                conexao.Open();


                SQL = "INSERT TB_PRODUTO(NM_PRODUTO,VL_PRODUTO) VALUES ('" + produto.nome + "', '" + produto.valorproduto + "');" + "Select Scope_Identity()";

                comando = new SqlCommand(SQL, conexao);
                produto.codigo = Convert.ToInt32(comando.ExecuteScalar());


            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexao.Close();
            }

            return produto.codigo;
        }
        public void AtualizarProduto(Produto produto)
        {
            string SQL;
            SqlCommand comando;

            try
            {
                conexao = new SqlConnection(@"Data Source = DESKTOP-UTR2P7O\SQLEXPRESS; Initial Catalog = DB_PIZZARIA; Integrated Security = True");

                SQL = "UPDATE TB_PRODUTO SET NM_PRODUTO = '" + produto.nome + "', VL_PRODUTO = '" + produto.valorproduto + "' WHERE CD_PRODUTO = " + produto.codigo;

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


        public void ExcluirProduto(int codproduto)
        {
            string SQL;
            SqlCommand comando;

            try
            {
                conexao = new SqlConnection(@"Data Source = DESKTOP-UTR2P7O\SQLEXPRESS; Initial Catalog = DB_PIZZARIA; Integrated Security = True");

                SQL = "DELETE TB_PRODUTO WHERE CD_PRODUTO = " + codproduto.ToString();

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

