// Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
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

void NumbCheck (int [,] array)
{   
    Console.WriteLine("Введите число, которое хотите найти");
    int N = Convert.ToInt32(Console.ReadLine());
    int temp = 0;
    for (int i=0; i<array.GetLength(0);i++)
        {
            for (int j=0;j<array.GetLength(1);j++)
            {
                if (array[i,j]==N)
                {
                    Console.WriteLine($"Координаты вашего числа ({i},{j})");
                    temp++;
                }
            }
        }
    if (temp==0) Console.WriteLine("Такого числа нет в массиве");
}
FillArray(array);
PrintArray(array);
Console.WriteLine();
NumbCheck(array);