using System.Net.Http.Headers;

int[] numeros = new int[10];
int soma = 0;

for(int i = 0; i < numeros.Length; i++)
{
 Console.Write($"Informe os valores a serem armazenados no vetor: {i + 1}°");
    numeros[i]=int.Parse(Console.ReadLine());
    soma += numeros[i];   
}
double media = (double)soma /numeros.Length;

Console.Write($"Média :{media}");
Console.WriteLine("\nNumeros acima da media:");

foreach( int num in numeros)
{
    if(num > media)
    {
        Console.Write($"{num} ");
    }
}