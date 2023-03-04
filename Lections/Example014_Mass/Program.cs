// Алгоритм сортировки выбором (мин, макс)

int[] arr = {1,5,2,7,9,6,3,2,1};

// Метод, который выводит значения массива
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i<count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine(" ");
}
// Метод, который упорядочивает массив

void SelectionSort(int[] array)
{
    for (int i =0; i <array.Length -1;i++)
    {
        int minPosition = i;

        for(int j = i+1; j < array.Length;j++)
        {
            if (array[j]< array[minPosition]) minPosition = j;
        }
        int temporary =array[i];
        array [i]=array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);