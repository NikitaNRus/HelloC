//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
}}
void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
        {
            for (int j=0;j<array.GetLength(1);j++)
                Console.Write($"{array[i,j],3} \t");
        Console.WriteLine();
}}
void InvertSort (int[,] array)
{   int max = 0;
    int j =0;
    int size =array.GetLength(1);
    for (int i=0; i<array.GetLength(0);i++)
        {
            while (size!=0)
            {
                while(j<size-1)
                {
                    if (array[i,j+1]>array[i,j])
                    {
                        max = array[i,j+1];
                        array[i,j+1]=array[i,j];
                        array[i,j]=max;
                        j++;
                    }
                    else j++;
                }
                size=size-1;
                j=0;
            }
        size =array.GetLength(1);
        j=0;
}}
FillArray(array);
PrintArray(array);
Console.WriteLine();
InvertSort(array);
PrintArray(array);