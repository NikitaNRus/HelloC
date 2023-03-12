// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// void FillArray(int [] array)
// {
//     for(int i =0;i<array.Length;i++)
//     {
//         array[i]=new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[]array)
// {
//     foreach(int i in array)
//     {
//         Console.Write($"{i} ");
//     }
//     Console.WriteLine();
// }
// int EvenNum (int [] array)
// {   int sum =0;
//     for (int i =0; i<array.Length;i++)
//     {
//         if (array[i]%2==0)
//         {
//         sum=sum+1;
//         }
//     }
//     return sum;
// }

// Console.WriteLine("Задайте длину массива");
// int Length = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [Length];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine($"Количество четных чисел в массиве = {EvenNum(array)}");
