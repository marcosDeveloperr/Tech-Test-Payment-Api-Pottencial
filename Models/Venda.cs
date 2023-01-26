using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tech_Test_Payment_Api_Pottencial.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public string StatusDaVenda { get; set; }
        public string StatusDaVendaAtualizado { get; set; }
        public int IdVendedor { get; set; }

        public string Itens { get; set; }
    }
}