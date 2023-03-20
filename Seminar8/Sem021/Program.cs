// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows,cols];
Console.WriteLine("Введите самое маленькое число массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите самое большое число массива");
int max = Convert.ToInt32(Console.ReadLine());
int[] arrayline=new int [max-min];

void FillArray (int [,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j]=new Random().Next(0,10);;
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
void Proverka (int[,] array, int[]arrayline)
{
    for(int i =0; i<array.GetLength(0);i++)
    {
        for (int j =0; j<array.GetLength(1);j++)
        {
            arrayline[array[i,j]]++;
        }
    }
}
void Print (int[]arrayline)
{
    for (int i=0; i<arrayline.Length;i++)
    {
        if (arrayline[i]!=0)
        {
            Console.WriteLine($"Элемент {i} встречается {arrayline[i]} раз");
        }
    }
}








FillArray(array);
PrintArray(array);
Console.WriteLine();
Proverka(array, arrayline);
Print(arrayline);




// int[] UniqNumbers (int [,] array)
// {   int count =0;
//     int go = 1;
//     int [] newArray = new int [10];
//     newArray[0]=array[0,0];
//     for (int i=0; i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//         {
//             for (int c =0;c<go;c++)
//             {
//                 if (newArray[c]==array[i,j])
//                 {
//                 count++;
//                 } 
//             }
//                 if(count==0)
//                 {
//                 newArray[go]=array[i,j];
//                 go++;
//                 }
//                 count=0;
//         }
//     }
// return newArray;
// }
