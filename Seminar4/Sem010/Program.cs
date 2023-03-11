// Прога принимает число A и выдает сумму чисел от 1 до А
// int Summa(int N)
// {
//     int sum =0;
//     for(int i =1; i<=N;i++)
//     sum+=i; // sum = sum + i
//     return sum;
// }

// Console.WriteLine("Введите целое число");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма всех чисел от 1 до {N} равна {Summa(N)}");

//  Прога принимает на вход число и выдает количество цифр в числе

void CountNumbers(double N)
{
int temp = 0;
N = Math.Abs(N);
if (N%1==0)
{
    while (N>=1)
    {
        N=N/10;
        temp++;
    }
Console.WriteLine($"количество цифр в числе {N} равна {temp}");    
}
else
    {
    while (N%1!=0)
    {
        N=N*10;
        temp++;
    }    
Console.WriteLine($"количество цифр в числе 0,{N} равна {temp+1}");
    }   
}

Console.WriteLine("Введите целое число любой разрядности");
double N = Convert.ToDouble(Console.ReadLine());
CountNumbers(N);


// Через логарифм для целых чисел неотрицательных

// int d = Convert.ToInt32(Math.Log10(N));
// Console.WriteLine($"количество цифр в числе равна {d+1}");