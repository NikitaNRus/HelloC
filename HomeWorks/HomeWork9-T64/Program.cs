// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.WriteLine("Введите цифру");
int num = Convert.ToInt32(Console.ReadLine());

string NumPrint (int num)
{   
    if (num==1) return Convert.ToString(num);
    return  NumPrint(num-1) + " " +Convert.ToString(num) ;
}
Console.WriteLine(NumPrint(num));
