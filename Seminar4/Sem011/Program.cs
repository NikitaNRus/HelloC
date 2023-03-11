// Прога выводит массив из 8 элементов, заполненный рандомно значениями от 0 до 1 

int[] CreateArray()
{
    int [] array = new int[9];
    for (int i =0; i<array.Length;i++)
    {
        int randomNum = new Random().Next(0,2);
        array[i]=randomNum;
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
bool CompareArray (int[] array)
{
    int CountOne = 0;

    for (int i=0;i<array.Length;i++ )
    {
        if (array[i] !=0)
        CountOne=CountOne+1;
    }
    return CountOne > array.Length/2 ? true: false;
}
int [] array = CreateArray();
PrintArray(array);
Console.WriteLine();
Console.WriteLine(CompareArray(array));

// true, если единиц больше, чем нулей

