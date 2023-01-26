using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tech_Test_Payment_Api_Pottencial.Models;

namespace Tech_Test_Payment_Api_Pottencial.Context
{
    public class VendaContext : DbContext
    {
       public  VendaContext(DbContextOptions<VendaContext>options): base(options)
        {

        }
        public DbSet<Vendedor> Vendedor {get;set;}
    }
}