using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Quad : IDrawable // a classe line, respeita o contrato da interface
    {
        public float Area() 
        { 
               return 20;
        }

    public void Draw()
    {
        Console.WriteLine("Lógica para a quadrado");
    }
}
}
