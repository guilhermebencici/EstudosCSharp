using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Exercicio1
{
    public class ContaCorrente
    {
        public int Numero { get; set; }
        public String? Titular { get; set; }
        public decimal Saldo { get; set; } = 0.00m;
        public virtual double Juros { get; set; } = 0.00;

        private decimal CalculaRemuneracao(double juros)
        {
            return Saldo * (decimal)Juros;
        }

        public virtual decimal Sacar(decimal valor)
        {
            Saldo -= valor;
            return Saldo;
        }

        public decimal Depositar(decimal valor)
        {
            Saldo += valor;
            Saldo = Saldo + CalculaRemuneracao(Juros);
            return Saldo;
        }
    }
}
