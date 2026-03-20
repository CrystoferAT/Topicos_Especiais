
int[] numeros = {10,20,30,40,50};
int soma = 0;
for(int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros [i]);
    soma += numeros[i]; 
}
Console.WriteLine("A soma dos valores do vetor é: " + soma);

