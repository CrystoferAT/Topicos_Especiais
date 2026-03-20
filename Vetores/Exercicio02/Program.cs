
Console.WriteLine("Hello, World!");
int[] num = new int[5];

for(int i = 0; i < num.Length; i++)
{
    Console.WriteLine("Digite 5 numeros inteiros para alimentar o vetor:");
    num[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Numeros do vetor:");
for(int i = 0; i < num.Length; i++)
{
    Console.Write(num [i] + " ");
}