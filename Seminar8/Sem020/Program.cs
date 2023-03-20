// Задайте двумерный массив. Прога меняет местами первую и последнюю строку массива
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
//             array[i,j]=new Random().Next(0,10);;
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
// void ChangeRows (int [,] array)
// {
//     int i =0;
//             for (int j=0;j<array.GetLength(1);j++)
//                 {
//                     int temp = array[array.GetLength(0)-1,j];
//                     array[array.GetLength(0)-1,j]=array[i,j];
//                     array[i,j]=temp;
//                 }

// }
// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// ChangeRows(array);
// PrintArray(array);






// Задайте двумерный массив. Прога заменяет строки на столбцы. В случае, если это невозможно, программа выводит сообщение.

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows,cols];

void FillArray (int [,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j]=new Random().Next(0,10);;
    }
}
void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
        {
            for (int j=0;j<array.GetLength(1);j++)
                Console.Write($"{array[i,j],3} \t");
        Console.WriteLine();
        }
}

void Invert(int [,] array)
{ int c =0;
    for (int j=0; j<array.GetLength(1);j++)
        {
            for (int i=1+c;i<array.GetLength(0);i++)
            {
                int temp = array[i,j];
                array[i,j]=array[j,i];
                array[j,i]=temp;
            }
      c++;
        }
}
FillArray(array);
PrintArray(array);
Console.WriteLine();
if(rows==cols)
{
    Invert(array);
    PrintArray(array);
}
else Console.WriteLine("Введите равносторонний массив");