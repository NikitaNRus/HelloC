//Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.Через строку решать нельзя.

Console.Write("Введите целое число: ");
double NumA = Convert.ToDouble(Console.ReadLine());
int div =10;
if (NumA<100)
{
    Console.WriteLine("Такой цифры нет");
}
else
{
    while (NumA>=1000)
    {
    NumA=NumA/div;
    }
}
double ost = NumA*10%10/10; //Находим остаток, который неизбежно остается при делении вещ числа
// Вычитаем остаток из числа с округлением к целому
Console.WriteLine("Третье число слева: "+ Math.Round(NumA%10-ost));
