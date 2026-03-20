
int[] num = {1,2,3,4,5,6,7,8,9,10};
int maior = num[0];

foreach(int big in num)
{
    if(maior < big)
    {
        maior = big;
    }
}
Console.WriteLine("O maior valor do vetor é:" + maior);