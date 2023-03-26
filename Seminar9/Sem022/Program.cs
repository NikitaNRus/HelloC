// Прога находит сумму чисел от 1 до N
// Console.WriteLine("Введите цифру");
// int num = Convert.ToInt32(Console.ReadLine());
// int Summa(int num)
// {
//     int sum = 0;
//     while (true)
//     {
//         if (num==0) break;
//         sum = sum+num;
//         num--;
//     }
//     return sum;
// }

// Console.WriteLine($"Сумма чисел равна {SummaRec(num)}");


// int SummaRec(int Num)
// {
//     if (Num==0) return 0;
//     return Num+ SummaRec(Num-1); 
// }



// Задайте значение N. Напишите программу, которая выведет числа от 1 до N.

// Console.WriteLine("Введите цифру");
// int num = Convert.ToInt32(Console.ReadLine());

// string NumPrint (int num)
// {
//     if (num==1) return 
//     Convert.ToString(num);
//     return NumPrint(num-1) +" "+
//     Convert.ToString(num);
// }
// Console.WriteLine(NumPrint(num));


// Задайте значения M и N и выведите значения в этом промежутке

// Console.WriteLine("Введите цифру Большую");
// int numBig = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите цифру Меньшую");
// int numSmall = Convert.ToInt32(Console.ReadLine());



// string NumRec(int N, int M)
// {
//     if (N==M) return Convert.ToString(N);
//     return NumRec(N-1,M) + " " + Convert.ToString(N);
// }
// Console.WriteLine(NumRec(numBig,numSmall));

// Напишите прогу, которая принимает число и считает сумму его цифр
// Console.WriteLine("Введите цифру Большую");
// int numBig = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumDigits(numBig));

// int SumDigits (int numBig)
// {
//     if (numBig==0) return 0;
//     return numBig%10 + SumDigits(numBig/10);
// }

// Принимает два числа и одно возводит в степень другого

Console.WriteLine("Введите цифру степень");
int numPow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите цифру основание");
int numCore = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {numCore} в степени {numPow} равно {Power(numPow, numCore)}");

int Power(int numPow, int numCore)
{
    if (numPow==0) return 1;
    return numCore*Power(numPow-1,numCore);
}