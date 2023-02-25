// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
Console.WriteLine("Введите два числа ");
int NumA = Convert.ToInt32(Console.ReadLine());
int NumB = Convert.ToInt32(Console.ReadLine());
int max = NumA;
int min = NumB;
if (NumA<NumB)
{
   max = NumB;
   min = NumA;
}
Console.WriteLine("Максимальное число: "+ max);
Console.WriteLine("Минимальное число: "+ min);
