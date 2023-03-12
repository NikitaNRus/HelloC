// Задайте одномерный массив из 12 случайных чисел от -100 до 100
// найти кол-во элементов, значения которых лежат в отрезке от 10 до 99

// void FillArray(int [] array)
// {
//     for(int i =0;i<array.Length;i++)
//     {
//         array[i]=new Random().Next(-100,101);
//     }
// }
// void PrintArray(int[]array)
// {
//     foreach(int i in array)
//     {
//         Console.Write($"{i} ");
//     }
//     Console.WriteLine();
// }

// int Count (int[]array)
// {
// Console.WriteLine("Задайте верхнюю границу диапазона");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задайте нижнюю границу диапазона");
// int min = Convert.ToInt32(Console.ReadLine());
// int sum =0;
//         for (int i=0;i<array.Length;i++)
//     {
//         if (array[i]<=max && array[i]>=min)
//         sum++;
//     }
// return sum;
// }

// Console.WriteLine("Задайте длину массива");
// int Length = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [Length];
// FillArray(array);
// PrintArray(array);
// Console.WriteLine(Count(array));


// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент и тд.

void FillArray(int [] array)
{
    for(int i =0;i<array.Length;i++)
    {
        array[i]=new Random().Next(1,10);
    }
}
void PrintArray(int[]array)
{
    foreach(int i in array)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}

int[] Mult(int[] array)
{
    int [] res = new int[array.Length/2+array.Length%2];
    for (int i=0; i<array.Length/2;i++)
    {
        res[i] = array[i]*array[array.Length-1-i];
    }
    if (array.Length%2 !=0)
    {
        res[array.Length/2] = array[array.Length/2];
    }
return res;
}




Console.WriteLine("Задайте длину массива");
int Length = Convert.ToInt32(Console.ReadLine());
int [] array = new int [Length];
FillArray(array);
PrintArray(array);
int [] res = Mult(array);
PrintArray(res);