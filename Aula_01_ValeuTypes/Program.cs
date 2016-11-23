using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_01_ValeuTypes
{
    class Program
    {
        public class PosicaoClasses
        {
            //Aqui é onde fica alocado na memória esse objeto
            public int X;
            public int Y;
        }
        public static void DobrarRef(ref int valor)
        {
            valor = valor * 2;
        }
        public static void DobrarValue(int valor)
        {
            valor = valor * 2;
        }
        public static void Dobrar(PosicaoClasses valor)
        {
            valor.X = valor.X * 2;
            valor.Y = valor.Y * 2;
        }
        static void Main(string[] args)
        {
            //ValueTypeInt();
            //RefTypeInt();
            //DobrarValorRefType();
            
            PosicaoClasses pos1 = new PosicaoClasses();    
            pos1.X = 10;
            pos1.Y = 20;

            PosicaoClasses pos2 = new PosicaoClasses();
            pos2.X = 30;
            pos2.Y = 40;

            /*Nesse caso dobrou por que uma classe já é uma referência, então não vai como cópia*/
            Dobrar(pos1);
            Dobrar(pos2);

            Console.WriteLine("Posição 1: " + pos1.X + " => " + pos1.Y);
            Console.WriteLine("Posição 2: " + pos2.X + " => " + pos2.Y);

            Console.ReadKey();
        }
        private static void DobrarValorValueType()
        {
            /*Dessa maneira o x não Dobra, mesmo ele tendo entrado no método, para isso, pois quando fazemos dessa maneira, oque acontece
             * é que quando passamos um método por tipo valor, ele gera uma cópia para ser usado lá dentro, então não mexe na variável 
             * original, então quando damos um Console.Writeline ele retorna o valor original, dessa forma nos certificamos que não
             * modificará o valor original, protegendo a variável
             */
            int x = 10;

            DobrarValue(x);

            Console.WriteLine(x);
        }
        private static void DobrarValorRefType()
        {
            /*Dessa maneira o x dobra, por conta do ref, ai ele sim vai para a posição na memória, então sim dessa forma o valor desse objeto é 
             * modificado sim, lembre-se que aponta para o local da memória
             */
            int x = 10;

            DobrarRef(ref x);

            Console.WriteLine(x);
        }     

        private static void RefTypeInt()
        {
            PosicaoClasses pos1 = new PosicaoClasses();     //Aqui exite a posição de ponteiro, você utiliza das duas referencias de memória, esse ponteiro está pontado para o local daquela 
            pos1.X = 10;
            pos1.Y = 20;
            PosicaoClasses pos2 = new PosicaoClasses();
            pos2.X = 30;
            pos2.Y = 40;
            Console.WriteLine("Posição 1: " + pos1.X + " => " + pos1.Y);
            Console.WriteLine("Posição 2: " + pos2.X + " => " + pos2.Y);

            pos2 = pos1;    //Agora não faz cópia, agora aponta para a mesma posição de memória
            //Agora qualquer modificação, vai ser colocada na mesmaalocação de memória
            pos2.X = 200;   //Desta maneira afeta o pos1 também esse valor vai para esse local da memória
            //E como os dois estão lá, eles ficam com o mesmo valor, (Ambos estão apontando para o mesmo local de memória) 

            Console.WriteLine("(ref)Posição 1 - " + pos2.X);
            Console.WriteLine("(ref)Posição 2 - " + pos1.X);
        }

        private static void ValueTypeInt()
        {

            //Tipo Valor
            int x = 10;
            int y = 20;
            y = x;  //Cópia do valor

            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
