using System;

namespace Aula_06_Propriedades
{
    public class MensalidadeNegativaException : Exception
    {
        public MensalidadeNegativaException(string message)
            :base(message)
        {

        }
    }
    public enum TipoAluno
    {
        Regular, Especial
    }
    public class Aluno
    {
        private int _matricula;
        private string _nome;
        private double _mensalidade;
        private TipoAluno _tipo;
        public int Matricula
        {
            get { return _matricula; }
            set { _matricula = value; }
        }
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public double Mensalidade
        {
            get { return _mensalidade; }
            set
            {
                if (value < 0)
                {
                    throw new MensalidadeNegativaException("O Valor da mensalidade não pode ser negativo");
                }
                else
                {
                    _mensalidade = value;
                }
            }
        }
        public TipoAluno Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Aluno a = new Aluno();
                a.Matricula = 123;
                a.Nome = "Osmar";
                a.Mensalidade = -500.25;
                //a.Mensalidade = 500.25;
                a.Tipo = TipoAluno.Regular;
            }
            catch (MensalidadeNegativaException E)
            {
                Console.WriteLine(E.Message);
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }

            Console.ReadKey();
        }
    }
}
