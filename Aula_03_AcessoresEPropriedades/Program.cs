using System;

namespace Aula_03_AcessoresEPropriedades
{
    public class PosicaoClass            //Classes são VALUES REF
    {
        public int X;
        public int Y;

        public override string ToString()
        {
            return "X = " + X.ToString() + " ,Y = " + Y.ToString(); 
        }
    }
    public struct PosicaoStruct         //Struct são VALUES TYPES
    {
        public int X;
        public int Y;

        public string ToString()        //Caso vocÊ escreva um método , sem o uso do override, ele sobrescrve a ação que o método faz, porém para qualquer tipo de uso do mesmo
        {
            return "X = " + X.ToString() + " ,Y = " + Y.ToString(); 
        }
    }
                                        //Enum também são do tipo valor
    public enum Role            
    {
        Arquiteto, Programador, Tester
    }
    public enum Color
    {
        Vermelho = 0, Verde = 1, Azul = 2           //Posso colocar indices assim como nesse exemplo
    }
    public enum FormasPagto
    {
        Boleto, Cartao, Cheque
    }
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoClass pos1 = new PosicaoClass();
            pos1.X = 10;
            pos1.Y = 20;
            
            PosicaoStruct pos2 = new PosicaoStruct();
            pos2.X = 30;
            pos2.Y = 40;
            PosicaoStruct pos3 = pos2;      //Cópia - pois struct são do tipo valor
            pos3.Y = 50;

            //Uso do Enum - que também é do tipo valor
            FormasPagto forma = FormasPagto.Boleto;
            Role role = Role.Programador;
            Color cor = 0;

            Console.WriteLine(forma);
            Console.WriteLine(role);
            Console.WriteLine(cor);

            Console.WriteLine(pos1);
            Console.WriteLine(pos2.ToString());
            Console.WriteLine(pos3.ToString());

            Console.ReadKey();
        }
    }
}
