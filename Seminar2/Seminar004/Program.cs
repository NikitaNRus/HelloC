﻿// Выводит случ число из диапазона от 10 до 99, и показывает наибольшую цифру

int num = new Random().Next(10,100);
Console.WriteLine($"Было сгенерировано число {num}");
int x1 = num/10;
int x2 = num%10;
if (x1>x2)
    Console.WriteLine($"Наибольшая цифра - это {x1}");
else if (x1==x2)
    Console.WriteLine("Все цифры этого числа равны");
else 
    Console.WriteLine($"Наибольшая цифра - это {x2}");