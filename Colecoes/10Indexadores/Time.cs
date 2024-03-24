namespace _10Indexadores
{
    public class Time
    {
        // definindo os limtes do array
        string[] valor = new string[10];

        public string this[int i]
        {
            get
            {
                if(i >= 0 && i < valor.Length)
                {
                    return valor[i]; //retorna o valor
                }
                return "erro";
            }
            set
            {
                if(i >=0 && i < valor.Length)
                {
                    valor[i] = value; // atribui valor
                }
            }
        }
    }
}
