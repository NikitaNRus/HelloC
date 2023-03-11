// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

int Sum (int N)
{
    int result = 0;
    while (N>0)
    {
        result += N%10;
        N = N/10;
    }
    return result;
}
Console.WriteLine($"Сумма цифр числа равна {Sum(N)}");