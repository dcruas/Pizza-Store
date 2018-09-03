using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ItemPedidoBLL
    {
        private ItemPedidoDAL ItemPedidoDAL;

        public ItemPedidoBLL()
        {
            ItemPedidoDAL = new ItemPedidoDAL();
        }

    
        public List<ItemPedido> MostrarItemPedido(int codpedido)
        {
            return ItemPedidoDAL.MostrarItemPedido(codpedido);
        }

        public int IncluirItemPedido(ItemPedido item)
        {
            return ItemPedidoDAL.IncluirItemPedido(item);
        }


        /*  public void AtualizarItemPedido(ItemPedido item)
          {
              ItemPedidoDAL.AtualizarItemPedido(item);
          } */


        public void ExcluirItemPedido(int codigo)
           {
              ItemPedidoDAL.ExcluirItemPedido(codigo);
           }
          

    }
}
