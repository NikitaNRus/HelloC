// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Через функцию
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

Console.WriteLine("Введите три числа ");
int NumA = Convert.ToInt32(Console.ReadLine());
int NumB = Convert.ToInt32(Console.ReadLine());
int NumC = Convert.ToInt32(Console.ReadLine());

int max = Max(NumA, NumB, NumC);
Console.WriteLine("Максимальное число: " + max);

// Через if
Console.WriteLine("Введите три числа ");
int Num1 = Convert.ToInt32(Console.ReadLine());
int Num2 = Convert.ToInt32(Console.ReadLine());
int Num3 = Convert.ToInt32(Console.ReadLine());
int maximum = Num1;
if (Num2>maximum)
{
    maximum = Num2;
}
if (Num3>maximum)
{
    maximum = Num3;
}
Console.WriteLine("Максимальное число: " + maximum);