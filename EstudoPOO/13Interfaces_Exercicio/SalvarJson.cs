﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Interfaces_Exercicio
{
    public class SalvarJson : ArquivoBase, ISalvar
    {
        public void Salvar()
        {
            Console.WriteLine("Salvar arquivo Json");
        }

        public override void Nome()
        {
            Console.WriteLine("Definir nome Json");
        }
    }
}
