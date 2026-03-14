
Console.WriteLine("Tabuada");
Console.Write("Digite um numero inteiro para gerar uma tabuada :");
int num = int.Parse(Console.ReadLine());
int i, resultado;

for(i=1; i <= 10; i++)
{
    Console.WriteLine($"{i} x {num} =" + i*num);
}
