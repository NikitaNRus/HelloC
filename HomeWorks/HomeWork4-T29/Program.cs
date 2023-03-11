// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateArray(int Length, int minValue, int maxValue)
{
    int [] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i< Length; i++)
    {
        array[i] = random.Next(minValue, maxValue+1);
    }
    return array;
}
void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write($"{array[i]}");
    }
}
Console.WriteLine("Введите длину массива");
int Length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число элемента массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число элемента массива");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArray(Length, min, max);
PrintArray(array);
