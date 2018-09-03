using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class PedidoBLL
    {
        private PedidoDAL pedidoDAL;

        public PedidoBLL()
        {
            pedidoDAL = new PedidoDAL();
        }

        public List<Pedido> MostrarTodosPedidos()
        {
            return pedidoDAL.MostrarTodosPedidos();
        }

        public List<Pedido> MostrarPedidos(int codcliente)
        {
            return  pedidoDAL.MostrarPedidos(codcliente);
        }
       
        public int IncluirPedido(Pedido pedido)
        {   
            
            return pedidoDAL.IncluirPedido(pedido);
        }

        public double FinalizarPedido(int codpedido)
        {

            return pedidoDAL.FinalizarPedido(codpedido);
        }

        public void ExcluirPedido(int codigopedido)
        {
          pedidoDAL.ExcluirPedido(codigopedido);
        }
      
              

    }
}
