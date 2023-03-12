// Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.

int CountDigits(double N)
{
    
    int sum = 0;
    if (N%1==0)
    {
    while (N>=1)
    {
        N =N/10;
        sum++;
    }
    }
    else 
        while (N%1!=0)
        {
            N =N*10;
        }
        while (N>=1)
    {
        N =N/10;
        sum++;
    }
   
    return(sum);
}

Console.WriteLine("Введите число");
double N = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(CountDigits(N));