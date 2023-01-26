using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tech_Test_Payment_Api_Pottencial.Models
{
    //O vendedor deve possuir id, cpf, nome, e-mail e telefone;
    public class Vendedor
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}