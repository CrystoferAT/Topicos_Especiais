
Console.WriteLine("Fibonacci");
Console.Write("Digite um numero inteiro:");
int contador = int.Parse(Console.ReadLine());
int i , n1 = 0 ,n2 = 1;

for(i = 0; i < contador; i++)
{
    Console.Write(n1 +(n1 + n2 <= contador ? "," : "."));
    int proximo = n1 + n2;
    n1 = n2;
    n2 = proximo;
}