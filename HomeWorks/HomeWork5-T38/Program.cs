// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double [] array)
{
    for(int i =0;i<array.Length;i++)
    {
        array[i]=new Random().Next(0,100);        
        // Console.WriteLine("Введите число массива под номером {i}");
        // array[i]=Convert.ToDouble(Console.ReadLine());
    }
    for(int i =0;i<array.Length;i++)
    {
        double temp = new Random().Next(0,100);
        array[i]=array[i]+temp/100;
    }
}

void PrintArray(double[]array)
{
    foreach(double i in array)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}
double Max (double[]array)
{
    double max = array[0];
    for (int i =0; i<array.Length;i++)
    {
        if (array[i]>max)
        max = array[i];
    }
    return max;
}

double Min (double[]array)
{
    double min = array[0];
    for (int i =0; i<array.Length;i++)
    {
        if (array[i]<min)
        min = array[i];
    }
    return min;
}

double Sum (double[]array)
{
    double min = array[0];
    for (int i =0; i<array.Length;i++)
    {
        if (array[i]<min)
        min = array[i];
    }
    double max = array[0];
    for (int i =0; i<array.Length;i++)
    {
        if (array[i]>max)
        max = array[i];
    }
    double sum = max-min;
    return sum;
}

Console.WriteLine("Задайте длину массива");
int Length = Convert.ToInt32(Console.ReadLine());
double [] array = new double [Length];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Максимальное число массива: {Max(array)}");
Console.WriteLine($"Минимальное число массива: {Min(array)}");
Console.WriteLine($"Сумма максимального и минимального числа равна ={Sum(array)}");