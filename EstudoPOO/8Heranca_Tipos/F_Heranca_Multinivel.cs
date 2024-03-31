using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Heranca_Tipos
{
    internal class F_Heranca_Multinivel : E_Heranca_Multinivel // TIPO MULTINIVEL, PORQUE HERDA DE UMA HERDEIRA
    {
        public void Apresentar()
        {
            Console.WriteLine("Método da classe F - Multiniveis");
        }
    }
}
