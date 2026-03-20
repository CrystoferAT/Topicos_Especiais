using System.Net.Http.Headers;

int[] notas = {1,2,3,4,5,6,7,8,9,10};
int soma = 0;

foreach(int nota in notas)
{
    soma += nota;
}
double media = (double)soma /notas.Length;

Console.Write($"Média :{media}");