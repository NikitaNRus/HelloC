// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
double [,] array = new double [rows,cols];

void FillArray (double [,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j]=new Random().NextDouble()+new Random().Next(-10,10);;
    }
}
void PrintArray(double[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
        {
            for (int j=0;j<array.GetLength(1);j++)
                Console.Write($"{Math.Round(array[i,j],2),5} \t");
        Console.WriteLine();
        }
}
FillArray(array);
PrintArray(array);