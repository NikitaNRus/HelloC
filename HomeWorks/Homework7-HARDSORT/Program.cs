// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
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
            array[i,j]=new Random().Next(0,11);;
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
void SortingRows (int [,]array)
{  
   for (int i=0; i<array.GetLength(0);i++)
    {
        for(int c=0;c<array.GetLength(1);c++)
        {
            for (int j=0;j<array.GetLength(1)-c-1;j++)
            {
                if (array[i,j]>array[i,j+1])
                {
                 int temp = array[i,j];
                 array[i,j]=array[i,j+1];
                 array[i,j+1]=temp;
                }
            }
        }
    }  
}
void SortingCol (int [,]array)
{   
    for (int i=1; i<array.GetLength(0);i++)
    {  
        for (int j=0;j<array.GetLength(1);j++)
        {
            for (int c =0; c<array.GetLength(1);c++)
            {
              if (array[i,j]<array[i-1,c])
              {
                int temp = array[i-1,c];
                array[i-1,c]=array[i,j];
                array[i,j]=temp;
                SortingRows(array);
                SortingCol(array);
}}}}}
FillArray(array);
PrintArray(array);
Console.WriteLine();
SortingRows(array);
PrintArray(array);
Console.WriteLine();
SortingCol(array);
PrintArray(array);