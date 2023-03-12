// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int [] array)
{
    for(int i =0;i<array.Length;i++)
    {
        array[i]=new Random().Next(100,1000);
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
int OddNumSum (int [] array)
{   int sum =0;
    for (int i =0; i<array.Length;i=i+2)
    {
    sum=sum+array[i];
    }
    return sum;
}

Console.WriteLine("Задайте длину массива");
int Length = Convert.ToInt32(Console.ReadLine());
int [] array = new int [Length];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма чисел на нечетных номерах (не индексах!!!) = {OddNumSum(array)}");
