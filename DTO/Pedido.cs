using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Pedido
    {
        public int pedido { get; set; }
        public string datapedido { get; set; }
        public int cd_cliente { get; set; }
        public string nm_cliente { get; set; }
        public int telefone { get; set; }
        public string endereco { get; set; }
        public List<ItemPedido> itenspedido { get; set; }
        public string observacao { get; set; }
        public string status { get; set; }
        public double valortotal{get;set; }
        
        
    }
}
