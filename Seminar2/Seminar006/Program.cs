// принимает на вход число и проверяет, кратно ли оно 23 и 7 одновременно

// Console.WriteLine("Введите число для проверки ");
// int NumA = Convert.ToInt32(Console.ReadLine());
// int x1 = NumA%23;
// int x2 = NumA%7;
// if ((x1==0)&&(x2==0)) // если поставить "||", то или-или
// {
//     Console.WriteLine("Число делится и на 23, и на 7");
// }
// else
// Console.WriteLine("Число не делится и на 23, и на 7");



// принимает два числа и проверяет ни является ли одно число квадратом другого
Console.WriteLine("Введите два числа для проверки ");
double NumA = Convert.ToDouble(Console.ReadLine());
int NumB = Convert.ToInt32(Console.ReadLine());
double sqA=NumA*NumA; // можно задать через Math.Sqrt(NumA)
int sqB=NumB*NumB; // можно задать через Math.Sqrt(NumB)
if (NumA==sqB)
{
    Console.WriteLine("Первое число - квадрат второго ");
}
else if (NumB==sqA)
{
    Console.WriteLine("Второе число - квадрат первого ");
}
else
    Console.WriteLine("Числа не являются квадратами друг друга ");