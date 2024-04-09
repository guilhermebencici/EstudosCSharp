namespace _12Interfaces
{
    internal class Demo : IControle, IGrafico
    {
        public string Nome { get; set; } = string.Empty;

        public void Desenhar()
        {
            Console.WriteLine("Desenhando...");
        }

        public void Pintar()
        {
            Console.WriteLine("Pintando...");
        }
    }
}
