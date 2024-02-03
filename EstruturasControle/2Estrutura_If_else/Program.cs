Console.WriteLine("## INSTRUÇÃO IF-ELSE ##\n");

Console.WriteLine("Informe a nota do aluno \t");

var nota = Convert.ToInt32(Console.ReadLine());

if(nota > 5)
{
    Console.WriteLine("Aluno APROVADO!");
}
else
{
    Console.WriteLine("Aluno REPROVADO!");
}


Console.ReadKey();