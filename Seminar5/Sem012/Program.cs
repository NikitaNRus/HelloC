// Задать массив из 12 элементов, заполненных случайными числами от -9 до 9. Найти сумму отрицательных и положительных элементов массива.



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

void SumNumbers(int []array)
{
    int sump = 0;
    int sumn = 0;
    for(int i =0;i<array.Length;i++)
    
        if (array[i]>0) sump+=array[i];
        else sumn+=array[i];
    Console.WriteLine($"Сумма положительных элементов равна {sump}");
    Console.WriteLine($"Сумма отрицательных элементов равна {sumn}");
}

int[] SumAll(int []array)
{
int sump = 0;
    int sumn = 0;
    for(int i =0;i<array.Length;i++)
    
        if (array[i]>0) sump+=array[i];
        else sumn+=array[i];
int [] results = {sump,sumn};
return results;
}

int [] array = new int [12];
FillArray(array);
PrintArray(array);
SumNumbers(array);
int [] rez = SumAll(array);
PrintArray(rez);
Console.WriteLine($"Сумма положительных элементов равна {rez[0]}");
Console.WriteLine($"Сумма отрицательных элементов равна {rez[1]}");