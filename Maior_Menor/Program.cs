
Console.Write("Maior Menor");
int menor = 1;
int maior = 1;

int i;
    for(i = 0; i < 2; i++)
    {
        Console.Write("Digite um numero inteiro:");
        int num = int.Parse(Console.ReadLine());

        if(num <= menor)
        {
            menor = num;
        }
        if(num >= maior)
        {
            maior = num;
        }
    }
    Console.WriteLine("Menor: " + menor);
    Console.WriteLine("Maior: " + maior);

