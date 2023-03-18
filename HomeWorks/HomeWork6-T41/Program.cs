// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите размерность массива");
int M = Convert.ToInt32(Console.ReadLine());

int [] array = new int [M];

int [] FillArray(int [] array)
{
    for(int i =0;i<array.Length;i++)
    {
        Console.WriteLine($"Введите {i+1} число массива");
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
return array;
}

int Count (int[] array)
{   int count=0;
    for(int i =0; i<array.Length; i++)
    {
        if (array[i]>0)
        count ++;
    }
    return count;
}

int sum = Count(FillArray(array));
Console.WriteLine($"Количество элементов больше нуля = {sum}");