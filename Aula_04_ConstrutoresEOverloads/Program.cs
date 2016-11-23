using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_ConstrutoresEOverloads
{
    public class Contato
    {
        public string Tipo;
        public string Descricao;
    }
    public class Cliente
    {
        public int Codigo;
        public string Nome;
        public Contato Contato;

        /*Valores padrão*/
        public Cliente()
        {
            this.Codigo = 0;
            this.Nome = "Sem Nome";
            /*Instanciado aqui dentro para não dar erro na chamada das propriedades*/
            this.Contato = new Contato();
        }

        //Overloads
        public Cliente(int Codigo)
        {
            this.Codigo = Codigo;
            this.Nome = "Sem Nome";
            this.Contato = new Contato();
        }
        public Cliente(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Contato = new Contato();
        }

        public override string ToString()
        {
            return "Codigo: " + Codigo + " , Nome: " + Nome;
        }
    }
    public class ClienteVip : Cliente
    {
        public int Tempo;

        public ClienteVip(int codigo, string nome)
            :base(codigo,nome)                          //Chamando o construtor da classe base
        {
            this.Tempo = 10;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli1 = new Cliente();
            cli1.Codigo = 123;
            cli1.Nome = "Osmar Junior";
            cli1.Contato.Tipo = "Telefone";
            cli1.Contato.Descricao = "9999999";

            Cliente cli2 = new Cliente(456);
            cli2.Nome = "Joao";

            Cliente cli3 = new Cliente(789, "Zézao");

            Cliente cli4 = new ClienteVip(200, "Tonhão");

            Console.WriteLine(cli1);
            Console.WriteLine(cli2);
            Console.WriteLine(cli3);
            Console.WriteLine(cli4);

            Console.ReadKey();
        }
    }
}
