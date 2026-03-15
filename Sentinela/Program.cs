
int num, soma = 0,contador = 0, maior = int.MinValue;
double media = 0;

do{
Console.WriteLine("Digite um numero inteiro ou digite zero para parar e exibir o resultado da soma total media e maior numero digitado:");
    num = int.Parse(Console.ReadLine());
    soma += num;
    ++contador;
    if(num > maior)
    {
        maior = num;
    }
}while(num != 0);

if(contador > 0)
{
    media = (double)soma/(contador-1);
    Console.WriteLine("A soma é: " +soma);
    Console.WriteLine("A media é: " +media);
    Console.WriteLine("O maior valor digitado foi : " +maior);
}