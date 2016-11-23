using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02_ValueRef
{
    public class Cliente : Object    //Reference Type
    {
        public int Codigo;
        public string Nome;
        public string Telefone;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();     //Faz Concatenações de string
            sb.AppendLine("Codigo: " + Codigo);
            sb.AppendLine("Nome: " + Nome);
            sb.AppendLine("Telefone: " + Telefone);

            return sb.ToString();
        }
    }
    class Program
    {
        public static void MostrarValeuType()
        {
            /*Values Types por padrão quando chamada para ser apresentada ela mostra o valor dela*/
            int x = 10;
            string s = "OJ";
            bool b = false;

            Console.WriteLine(x);
            Console.WriteLine(s);
            Console.WriteLine(b);
        }
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente();
            c1.Codigo = 123;
            c1.Nome = "Osj";
            c1.Telefone = "99999999";

            Cliente c2 = c1;     //Assim é alocação dinâmica, diz que em algum momento eu vou utilizar o c2
                                 //Aponta para a mesma posição de memória c1

            c2.Nome = "JJ";
            Console.WriteLine(c2);
            Console.WriteLine(c1);   //Assim ele mostrar o tipo - no caso - valueRef.Cliente

            if (c1.Equals(c2))      //Ele vai entrar porque eles estão apontando para o mesmo local da memória
            {
                Console.WriteLine("c1 e c2 são os mesmos objetos");
            }
            else
            {
                Console.WriteLine("c1 e c2 não são os mesmos objetos");
            }

            //Console.WriteLine(c.Codigo);
            //Console.WriteLine(c.Nome);
            //Console.WriteLine(c.Telefone);            

            Console.ReadKey();
        }
    }
}
