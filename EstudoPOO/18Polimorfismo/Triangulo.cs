using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Polimorfismo
{
    internal class Triangulo : Figura
    {
        public override void Desnhar()
        {
            Console.WriteLine("Estou sobrescrevendo o método da clase base --Desenhando um Triangulo...");
            base.Desnhar();
        }
    }
}
