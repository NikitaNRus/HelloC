// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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
            array[i,j]=new Random().Next(1,10);;
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
void PrintArrayDouble(double[] array)
{
    for (int i=0; i<array.GetLength(0);i++)
        {
        Console.Write($"{array[i],3} \t");
        }
}

double [] MeanCol (int [,] array)
{   double [] newArray = new double[array.GetLength(1)];
    double sum = 0;
    for (int i=0; i<array.GetLength(1);i++)
        {
            for (int j=0;j<array.GetLength(0);j++)
            {
                sum = sum+array[j,i];
            }
        double mean = sum/array.GetLength(0);
        newArray[i]=Math.Round(mean,2);
        sum =0;
        }
return newArray;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
double [] newArray = MeanCol(array);
Console.WriteLine("Средние арифметические каждого столбца:");
PrintArrayDouble(newArray);