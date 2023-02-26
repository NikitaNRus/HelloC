// Программа принимает на вход целое число и возводит его в квадрат
Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int result = num*num;
Console.WriteLine("Квадрат числа равен: "+result);

//Проверка, что число равно определенному значению
if (num==5)
{
    Console.WriteLine("Пятерочка!");
}
else if(num==3)
{
    Console.WriteLine("Троечка!");
}
else
{
    Console.WriteLine("Не троечка и не пятерочка");
}