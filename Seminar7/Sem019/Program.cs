// задать двумерный массив, найти сумму элементов, находящейся на главной диагонали и обратной диагонали

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

int SumDiag (int [,] array )
{
    int sum1 = 0;
    for (int i=0; i<array.GetLength(0);i++)
        {
            for (int j=0;j<array.GetLength(1);j++)
            if (i==j)
            {
                sum1 += array[i,j];
            }
        }
    return sum1;
}
int SumDiagInv (int [,] array )
{
    int sum2 = 0;
    for (int i=0; i<array.GetLength(0);i++)
        {
            for (int j=0;j<array.GetLength(1);j++)
            if (i==array.GetLength(1)-j-1)
            {
                sum2 += array[i,j];
            }
        }
    return sum2;
}

FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма диагонали ={SumDiag(array)}");
Console.WriteLine($"Сумма обратной диагонали= {SumDiagInv(array)}");
