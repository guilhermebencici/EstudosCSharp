using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Exercicio1
{
    public class ContaPoupanca : ContaCorrente
    {
        public override double Juros { get; set; } = 0.005;

        public override decimal Sacar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                return Saldo;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente...");
                return Saldo;
            }
        }
    }
}
