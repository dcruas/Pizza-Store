using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ItemPedido
    {
        public int codigo { get; set; }
        public int codproduto { get; set; }
        public int codpedido { get; set; }
        public string nomeproduto { get; set; }
        public double quantidade { get; set; }
        public double valorproduto { get; set; }
        

    }
}
