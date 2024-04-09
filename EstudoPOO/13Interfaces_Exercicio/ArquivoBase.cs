namespace _13Interfaces_Exercicio
{
    // essa classe é abstrata, por isso, não podera ser instanciada
    public abstract class ArquivoBase
    {
        // o método, poder ser sobrescrito quando for herdado
        public virtual void Nome()
        {
            Console.WriteLine("Definir o nome do arquivo!");
        }
    }
}
