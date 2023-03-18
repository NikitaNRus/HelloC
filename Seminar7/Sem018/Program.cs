// задайте двумерный массив размера m на n, каждый элемент массива рандомно определяется
// вывести на экран

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int [rows,cols];

// void FillArray (int [,] array)
// {
//     for (int i=0; i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j]=new Random().Next(-30,31);
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i=0; i<array.GetLength(0);i++)
//         {
//             for (int j=0;j<array.GetLength(1);j++)
//                 Console.Write($"{array[i,j],3} \t");
//         Console.WriteLine();
//         }
// }
// FillArray(array);
// PrintArray(array);








// задайте двумерный массив размера m на n, каждый элемент массива находится по формуле Amn=m+n
// вывести на экран
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int [rows,cols];

// void FillArray (int [,] array)
// {
//     for (int i=0; i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j]=i+j;
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i=0; i<array.GetLength(0);i++)
//         {
//             for (int j=0;j<array.GetLength(1);j++)
//                 Console.Write($"{array[i,j],3} \t");
//         Console.WriteLine();
//         }
// }
// FillArray(array);
// PrintArray(array);

// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные и замените
// их на квартаты этих элементов

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int [rows,cols];

// int[,] FillArray (int [,] array)
// {
//     for (int i=0; i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j]=new Random().Next(1,10);;
//     }
// return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i=0; i<array.GetLength(0);i++)
//         {
//             for (int j=0;j<array.GetLength(1);j++)
//                 Console.Write($"{array[i,j],3} \t");
//         Console.WriteLine();
//         }
// }
// void FillArraySquare(int [,] array)
// {
//     for (int i=0; i<array.GetLength(0);i++)
//         {
//             for (int j=0;j<array.GetLength(1);j++)
//                if (j%2==0 && i%2==0)
//                {
//                 array[i,j]=array[i,j]*array[i,j];
//                }
//         }
// }

// int [,] arrayNew = FillArray(array);
// PrintArray(arrayNew);
// Console.WriteLine();
// FillArraySquare(arrayNew);
// PrintArray(arrayNew);


