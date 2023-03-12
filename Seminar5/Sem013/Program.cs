// прога по замене элементов массива: положительные элементы замените на соовтетствующие отрицательные

// void FillArray(int [] array)
// {
//     for(int i =0;i<array.Length;i++)
//     {
//         array[i]=new Random().Next(-9,10);
//     }
// }
// void PrintArray(int[] array)
// {
//     foreach (int el in array)
//     {
//         Console.Write($"{el} ");
//     }
//     Console.WriteLine();
// }

// void MakeNegative (int [] array)
// {
//     for(int i=0; i<array.Length; i++)
//     {
//         array[i]*=-1;
//     }
// }

// Console.WriteLine("Задайте длину массива");
// int Length = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [Length];
// FillArray(array);
// PrintArray(array);
// MakeNegative(array);
// PrintArray(array);





// Задайте массив. Прога, которая определяет, присутствует ли заданное число в массиве

 void FillArray(int [] array)
{
    for(int i =0;i<array.Length;i++)
    {
        array[i]=new Random().Next(-9,10);
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

void CheckNum (int[]array, int Num)
{
    int sum =0;
    for(int i =0;i<array.Length;i++)
    {
        if (array[i] == Num ||array[i] == -Num )
        sum++;
        break;
    }
    if(sum>0)
        Console.WriteLine("Такое число есть");
    else
        Console.WriteLine("Такого числа нет");
}

Console.WriteLine("Задайте длину массива");
int Length = Convert.ToInt32(Console.ReadLine());
int [] array = new int [Length];
Console.WriteLine("Наличие какого числа проверяем?");
int Num = Convert.ToInt32(Console.ReadLine());
FillArray(array);
PrintArray(array);
CheckNum(array,Num);