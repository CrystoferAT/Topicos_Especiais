
Console.WriteLine("Conversor de Moedas");

Console.Write("Digite o valor em Brl: R$");
double Brl = double.Parse(Console.ReadLine());

double Dolar = Brl / 5.17;
double Euro = Brl / 6.14;
double Peso = Brl * 0.05;

Console.WriteLine($"O valor em Brl:{Brl},00 convertido para Dolar é ${Dolar:F2}");
Console.WriteLine($"O valor em Brl:{Brl},00 convertido para Euro é ${Euro:F2}");
Console.WriteLine($"O valor em Brl:{Brl},00 convertido para Peso é ${Peso:F2}");

