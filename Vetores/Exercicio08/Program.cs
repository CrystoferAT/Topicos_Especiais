
using System.Globalization;

int[] numeros = new int[12];
int[] pares = new int[12];
int[] impares = new int[12];

int cont1 = 0;
int cont2 = 0;

for(int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite 12 numeros inteiros para alimentar o vetor: {i + 1}");
    numeros[i] = int.Parse(Console.ReadLine());

    if( numeros[i] % 2 == 0)
    {
        pares[cont1]= numeros[i];
        cont1++;
    }
    else
    {
        impares[cont2]= numeros[i];
        cont2++;
    }
}
Console.WriteLine("Vetor de pares");
for(int i = 0; i < cont1; i++)
{
    Console.Write($"{pares[i]} ");
}

Console.WriteLine("\nVetor de impares");
for(int j = 0; j < cont2; j++)
{
    Console.Write($"{impares[j]} ");
}

