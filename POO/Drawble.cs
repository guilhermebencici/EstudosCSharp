using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    // classe abstrata simulando a interface. Diferente da Interface, podemos usar atributos
    abstract class Drawble
    {
        public abstract void Draw();


        public abstract float Area();

    }
}
