namespace _11Heranca_abstract
{
    public abstract class Forma
    {
        public string? Cor { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }

        // MÉTODOS ABSTRATOS
        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();

        // MÉTODOS COMUM
        public string Descricao()
        {
            return "Sou a classe abstrata Forma";
        }
    }
}
