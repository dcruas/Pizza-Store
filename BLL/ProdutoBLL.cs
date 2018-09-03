using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ProdutoBLL
    {
        private ProdutoDAL produtoDAL;

        public ProdutoBLL()
        {
            produtoDAL = new ProdutoDAL();
        }

        public List<Produto> MostrarProduto()
        {
            return  produtoDAL.MostrarProduto();
        }
       
       public int IncluirProduto(Produto produto)
        {   

            return produtoDAL.IncluirProduto(produto);
        }

        
       public void AtualizarProduto(Produto produto)
       {

          produtoDAL.AtualizarProduto(produto);
       }

        public void ExcluirProduto(int codigopedido)
        {
            produtoDAL.ExcluirProduto(codigopedido);
        }

    }
}
