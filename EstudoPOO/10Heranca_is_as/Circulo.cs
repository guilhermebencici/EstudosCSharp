﻿namespace _10Heranca_is_as
{
    public class Circulo : Forma
    {
        public Circulo() { }
        public Circulo(int x, int y) : base(x, y) { }
        public override void Desenhar()
        {
            Console.WriteLine($"Desenhar circulo na posição : ({xpos},{ypos})");
        }
        public void PintarCirculo()
        {
            Console.WriteLine("Pintar o Circulo");
        }
    }
}
