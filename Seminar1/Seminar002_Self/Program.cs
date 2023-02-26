// На вход принимает два числа и проверяет, является ли первое число квадратом второго
// int numA = Convert.ToInt32(Console.ReadLine());
// int numB = Convert.ToInt32(Console.ReadLine());
// int square = numA*numA;
// if (square==numB)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Выдает название недели по заданному номеру
// Console.WriteLine("Введите число, чтобы узнать соответствующее ему название недели: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// if (numA==1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if (numA==2)
// {
//     Console.WriteLine("Вторник");
// }
// else if (numA==3)
// {
//     Console.WriteLine("Среда");
// }
// else if (numA==4)
// {
//     Console.WriteLine("Четверг");
// }
// else if (numA==5)
// {
//     Console.WriteLine("Пятница");
// }
// else if (numA==6)
// {
//     Console.WriteLine("Суббота");
// }
// else if (numA==7)
// {
//     Console.WriteLine("Воскресенье");
// }
// else Console.WriteLine("Введите число от 1 до 7");


Console.WriteLine("Введите число, чтобы узнать соответствующее ему название недели: ");
try
{
int numA = Convert.ToInt32(Console.ReadLine());
switch(numA)
{
    case 1:
    Console.WriteLine("Это понедельник");
    break;
     case 2:
    Console.WriteLine("Это вторник");
    break;
     case 3:
    Console.WriteLine("Это среда");
    break;
     case 4:
    Console.WriteLine("Это чертверг");
    break;
     case 5:
    Console.WriteLine("Это пятница");
    break;
     case 6:
    Console.WriteLine("Это суббота");
    break;
     case 7:
    Console.WriteLine("Это воскресенье");
    break;
    default:
    Console.WriteLine("Введеное число за рамками 1 и 7");
    break;
}
}
catch (System.FormatException)
{
    Console.WriteLine("Введено некорректное число");
}