namespace _12Interfaces
{
    internal interface IControle
    {
        // INTERFACE NÃO PODE TER CONSTRUTORES
        //public IControle() { }

        // PODE TER UMA PROPRIEDADE, quando tiver, também precisa ser implementado
        string Nome { get; set; }
        void Desenhar();
        public void Exibir()
        {
            Console.WriteLine("Teste...");
        }
    }
}
