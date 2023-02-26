// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7");
Console.WriteLine("понедельник - цифра 1");
Console.WriteLine("вторник - цифра 2");
Console.WriteLine("среда - цифра 3");
Console.WriteLine("четверг - цифра 4");
Console.WriteLine("пятница - цифра 5");
Console.WriteLine("суббота - цифра 6");
Console.WriteLine("воскресенье - цифра 7");
Console.WriteLine("Программа подскажет, какой из дней - выходной");
try
{int NumA = Convert.ToInt32(Console.ReadLine());

if ((NumA==6) || (NumA==7))
    Console.WriteLine("это выходной день");
else if((NumA>7)||(NumA<1))
    Console.WriteLine("введено неверное число");
else 
    Console.WriteLine("это рабочий день");
}
catch (System.FormatException)
{
    Console.WriteLine("Ввод некорректный");
}