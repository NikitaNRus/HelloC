// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B, на которое будем возваодить число А в степень");
int B = Convert.ToInt32(Console.ReadLine());
int powerA = 1;
for (int i=0; i<B;i++)
{
    powerA=powerA*A;
}
Console.WriteLine($"Число {A} в степени {B} равно {powerA}");
