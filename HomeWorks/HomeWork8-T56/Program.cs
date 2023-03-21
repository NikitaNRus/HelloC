// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

void MinSumRow (int[,] array)
{   
    int [] sums = new int [array.GetLength(0)];
    for (int i=0; i<array.GetLength(0);i++)
        {
            for (int j=0;j<array.GetLength(1);j++)
            {
                sums[i] = sums[i]+ array[i,j];
            }
            Console.WriteLine($"Сумма элементов {i+1} строчки равна {sums[i]}");
        }
    int min = sums[0];
    int minIndex = 0;
    for (int i=0; i<sums.Length;i++)
    {
        if (sums[i]<min)
        {
        min = sums [i];
        minIndex = i;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов в строке {minIndex+1}");
}
FillArray(array);
PrintArray(array);
Console.WriteLine();
MinSumRow(array);