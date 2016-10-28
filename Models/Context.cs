using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _0001_DemonstracaoMVC.Models
{
    public class Context : DbContext
    {
        public Context():base("conexao"){}

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}