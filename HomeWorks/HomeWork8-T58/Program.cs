// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Введите количество строк для первой матрицы");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов для первой матрицы");
int cols1 = Convert.ToInt32(Console.ReadLine());
int [,] array1 = new int [rows1,cols1];
Console.WriteLine("Введите количество строк для второй матрицы");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов для второй матрицы");
int cols2 = Convert.ToInt32(Console.ReadLine());
int [,] array2 = new int [rows2,cols2];

void FillArray (int [,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j]=new Random().Next(1,10);;
}}
void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
        {
            for (int j=0;j<array.GetLength(1);j++)
                Console.Write($"{array[i,j],3} \t");
        Console.WriteLine();
}}

int [] RowExtractor (int [,] array, int rowNum)
{
    int [] Row = new int[array.GetLength(1)];
            for (int j=0;j<array.GetLength(1);j++)
            {
                Row[j]=array[rowNum,j];
            }
    return Row;
}
int [] ColExtractor (int [,] array, int colNum)
{
    int [] Col = new int[array.GetLength(0)];
            for (int i=0;i<array.GetLength(0);i++)
            {
                Col[i]=array[i,colNum];
            }
    return Col;
}
int ArrayMulti (int[]array1, int [] array2)
{   // Работает только для равновеликих array
    int multi = 0;
    for (int i=0;i<array1.Length;i++)
    {
        multi =multi + array1[i]*array2[i];
    }
    return multi;
}
int [,] MatrixMulti(int[,] array1, int [,] array2)
{   int [,] matrix = new int [0,0];
    // Проверка умножаемости матриц
    if (array1.GetLength(1)!=array2.GetLength(0))
    {
        Console.WriteLine("Эти матрицы нельзя умножать");
    }
    else 
    { // Создаем матрицу размера rows1,cols2 и заполняем её скалярными произведениями
        matrix = new int [array1.GetLength(0),array2.GetLength(1)];
        for (int i=0; i<matrix.GetLength(0);i++)
        {
            for (int j=0;j<matrix.GetLength(1);j++)
            {
                matrix[i,j] = ArrayMulti(RowExtractor(array1,i),ColExtractor(array2,j));
            }
        }
    }
    return matrix;
}

FillArray(array1);
FillArray(array2);
Console.WriteLine("Первая матрица");
PrintArray(array1);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
PrintArray(array2);
Console.WriteLine();
Console.WriteLine("Результат после умножения первой и второй матриц");
PrintArray(MatrixMulti(array1,array2));
