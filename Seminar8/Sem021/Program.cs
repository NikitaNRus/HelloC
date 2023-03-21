// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int [rows,cols];
// Console.WriteLine("Введите самое маленькое число массива");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите самое большое число массива");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] arrayline=new int [max-min];

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
// void Proverka (int[,] array, int[]arrayline)
// {
//     for(int i =0; i<array.GetLength(0);i++)
//     {
//         for (int j =0; j<array.GetLength(1);j++)
//         {
//             arrayline[array[i,j]]++;
//         }
//     }
// }
// void Print (int[]arrayline)
// {
//     for (int i=0; i<arrayline.Length;i++)
//     {
//         if (arrayline[i]!=0)
//         {
//             Console.WriteLine($"Элемент {i} встречается {arrayline[i]} раз");
//         }
//     }
// }

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// Proverka(array, arrayline);
// Print(arrayline);



Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows,cols];
Console.WriteLine("Введите самое маленькое число массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите самое большое число массива");
int max = Convert.ToInt32(Console.ReadLine());
int[] arrayline=new int [max-min-1];

void FillArray (int [,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j]=new Random().Next(min,max);;
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

int Minimum (int[,] array)
{
    int min =array[0,0];
     for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            if (array[i,j]<min)
            {
                min = array[i,j];
            }
    }
    return min;
}
int[,] Deleter(int[,] array, int min)
{   
// считаем сколько будет строчек и столбиков в новом массиве newArray и создаем его
    int [] rows = new int [array.GetLength(0)];
    int [] cols = new int [array.GetLength(1)];
    int rowsCount =0;
    int colsCount=0;
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            if (array[i,j]==min)
            {
                rows [i]++;
                cols [j]++;
            }
        }
    }
    for (int i=0; i<rows.Length;i++)
        {
        if (rows[i]==0)
        rowsCount++;
        }
    for (int i=0; i<rows.Length;i++)
        {
        if (cols[i]==0)
        colsCount++;
        }
int [,] newArray = new int [rowsCount,colsCount];
// Заполняем все строки и столбики array, где есть min значениями min.
     for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            if (array[i,j]==min)
            {
                for (int c=0;c<array.GetLength(1);c++)
                {if(array[i,c]!=0)
                array[i,c]=min-1;}
                for (int r=0;r<array.GetLength(0);r++)
                {if(array[r,j]!=0)
                array[r,j]=min-1;}
            }
        }
    }
// Кладем в новый массив из array значение не равные min в массив newArray
int [] temp = new int [rowsCount*colsCount];
int t = 0;
for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
        {
            if (array[i,j]!=min && array[i,j]!=min-1)
            {
                temp[t]=array[i,j];
                t++;
            }
        }
    }
t=0;
for (int i=0; i<newArray.GetLength(0);i++)
    {
        for (int j=0;j<newArray.GetLength(1);j++)
        {
            newArray[i,j]=temp[t];
            t++;
        }
    }
return newArray;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Минимальное значение = {Minimum(array)}");
int [,] newArray = Deleter(array,Minimum(array));
PrintArray(newArray);
