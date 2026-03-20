int[] cpf = {2,6,5,4,8,5,6,4,1};
int dv1 = 0;
int dv2 = 0;

int soma1 = 0;
for(int i = 0; i < 9; i++)
{
 soma1 += cpf[i] * (10-i);
}
int resto1 = soma1 % 11;
dv1 = (resto1 < 2) ? 0 : 11 - resto1; 
Console.WriteLine(dv1);

int soma2 =0;
for(int i = 0; i < 9; i++)
{
    soma2 = cpf[i] *(11-i);
}
soma2 += dv1 *2;
int resto2 = soma2 % 11;
dv2 = (resto2 < 2) ? 0 : 11 -resto2;

Console.WriteLine($"Cpf {cpf[0]}{cpf[1]}{cpf[2]}{cpf[3]}{cpf[4]}{cpf[5]}{cpf[6]}{cpf[7]}{cpf[8]}{dv1}{dv2}");