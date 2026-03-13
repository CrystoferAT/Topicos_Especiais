
Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

if(idade <= 13)
{
    Console.WriteLine("Criança");
}
if(idade > 13 && idade < 18){
    Console.WriteLine("Adolescente");
}
if(idade > 18 && idade < 60){
    Console.WriteLine("Adulto");
}
else
{
    Console.WriteLine("Idoso");
    
}
