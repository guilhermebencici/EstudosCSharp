using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary; // para conseguir trabalhar com formatadores!

namespace EscritaBinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream stream  = new FileStream("meuarquivo.gui", FileMode.OpenOrCreate);

            BinaryFormatter enconder = new BinaryFormatter();

            enconder.Serialize(stream, 120);
            enconder.Serialize(stream, "Bencici");

            stream.Close();
        }
    }
}
