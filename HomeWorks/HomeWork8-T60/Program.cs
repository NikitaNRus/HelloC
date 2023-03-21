// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("Введите длину первого измерения матрицы");
int dim1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину второго измерения матрицы");
int dim2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину третьего измерения матрицы");
int dim3 = Convert.ToInt32(Console.ReadLine());

int [, ,] array = new int [dim1,dim2,dim3];

void FillArray (int [,,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            for (int k=0;k<array.GetLength(2);k++)
            {
                array[i,j,k]=new Random().Next(10,100);
            }
            
}}}

void PrintArray(int[,,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
        {
            for (int j=0;j<array.GetLength(1);j++)
               {
               for (int k=0;k<array.GetLength(2);k++)
                {
                Console.Write($"{array[j,k,i],2}({j},{k},{i}) \t");
                }
                Console.WriteLine();
}}}

FillArray(array);
PrintArray(array);