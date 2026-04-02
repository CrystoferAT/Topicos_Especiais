int[] numeros = new int[8];
int[] rosnume = new int[8];

for(int i = 0; i < numeros.Length; i++)
{
    Console.Write
    ($"Digite 8 numeros inteiros para alimentar o vetor: {i + 1}° ");
    numeros[i]= int.Parse(Console.ReadLine());
}
for(int i = 0; i < numeros.Length; i++)
{
    rosnume[i] = numeros[numeros.Length - 1 - i];
}
Console.Write("Vetor ");
foreach(int num in numeros)
{
    Console.Write($"{num} ") ; 
}
Console.Write("\nVetor invertido ");
foreach(int num in rosnume)
{
    Console.Write($"{num} ") ; 
    
}