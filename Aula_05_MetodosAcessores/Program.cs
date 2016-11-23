using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_MetodosAcessores
{
    public class Conta
    {
        private string _cliente;     //Encapsulei 
        private double _valor;

        public Conta()
        {
        }
        public Conta(string nomeCliente) 
        {
            this._cliente = nomeCliente;
        }
        public void Sacar(double valor)
        {
            this._valor = this._valor - valor;
        }
        public void Depositar(double valor)
        {
            this._valor = this._valor + valor;
        }
        //Métodos Acessores
        public double getValor()              //Vou obter, para ler
        {
            return this._valor;
        }
        public string getCliente()
        {
            return this._cliente;
        }
        public void setCliente(string value)
        {
            //if value...   -> para setar podemos criar regras aqui, e monitorar oque tá acontecendo com essa propriedade
            this._cliente = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta("Osmar");
            c.Depositar(1000);
            c.Sacar(500);

            Console.WriteLine("O Cliente : " + c.getCliente());
            Console.WriteLine("O Saldo é igual: " + c.getValor());

            Conta c2 = new Conta();
            c2.setCliente("Junior");
            c2.Depositar(750);

            Console.WriteLine("O Cliente 2: " + c2.getCliente() + " tem de Saldo: " + c2.getValor());

            Console.ReadKey();
        }
    }
}
