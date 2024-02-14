Console.WriteLine("## CAMPOS ESTÁTICOS ##\n");

// INSTANCIANDO A CLASSE, EU CONSIGO UTILIZAR O CAMPO QUE NÃO É ESTÁTICO
A a1 = new A();
// a1 é criado na memória stack com um point de referencia na Heap
a1.x = 10;

// AQUI EU CHAMO UN MÉTODO ESTÁTICO SEM PRECISAR INSTANCIAR UM OBJETO

// A.y, por ser estática, é criado direto na memória Heap
A.y = 20;

Console.WriteLine($"Campo do objeto {a1.x}\nCampo da classe {A.y}");


Console.ReadKey();

public class A
{
    // CAMPO NÃO ESTATICO
    public int x;

    // CAMPO ESTATICO
    public static int y;

    //... construtores, props, métodos
}