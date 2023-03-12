//  Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, 
// минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями.
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

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
int MaxIndex (int[]array)
{
    int max = array[0];
    for (int i =0; i<array.Length;i++)
    {
        if (array[i]>max)
        max=array[i];
    }
    return max;
}
int MinIndex (int[]array)
{
    int min = array[0];
    for (int i =0; i<array.Length;i++)
    {
        if (array[i]<min)
        min=array[i];
    }
    return min;
}
int Mean(int [] array)
{   int sum = 0;
    for(int i=0;i<array.Length;i++)
    {
        sum+=array[i];
    }
return sum/array.Length;
}
int[] Sort (int []array)
{   
    int size = array.Length;
    int i = 0;
    while (size!=0)
    {
        while (i<size-1)
        {
           if (array[i+1]<array[i])
        {
            int temp = array[i];
            array[i]=array[i+1];
            array[i+1]=temp; 
            i++;
        }
        else i++;
        }
    size=size-1;
    i=0;
    }
return array;
}
int Median (int [] array)
{   int median = 0;
    if (array.Length%2==0)
        {
            median = (array[array.Length/2-1] + array[array.Length/2])/2;
        }
    else
        median = array[array.Length/2];
return median;
}


Console.WriteLine("Задайте длину массива");
int Length = Convert.ToInt32(Console.ReadLine());
int [] array = new int [Length];
FillArray(array);
Console.WriteLine("Получился следующий массив: ");
PrintArray(array);
Console.WriteLine($"Максимальное число в массиве = {MaxIndex(array)}");
Console.WriteLine($"Минимальное число в массиве = {MinIndex(array)}");
Console.WriteLine($"Среднее арифмитическое всех значений массива = {Mean(array)}");
int [] rez =new int[]{MaxIndex(array),MinIndex(array),Mean(array)};
Console.WriteLine("Положили значения максимального, минимально числа и среднее арифмитическое в массив: ");
PrintArray(rez);
Console.WriteLine("Новый отсортированный массив: ");
int [] sorted = Sort(array);
PrintArray(sorted);
Console.WriteLine($"Медиана значений массива = {Median(sorted)}");