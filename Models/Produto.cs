using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0002_RotasMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QtdEstoque { get; set; }
        public string Cor { get; set; }
        public string Categoria { get; set; }
        public double Valor { get; set; }
    }
}