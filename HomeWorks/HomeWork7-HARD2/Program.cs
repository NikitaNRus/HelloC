// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , причем чтоб количество элементов было четное. 
// Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, причем чтобы каждый элемент 
// гарантированно и только один раз переместился на другое место и выполнить перемешивание за m*n / 2 итераций. 
// То есть если массив три на четыре, то надо выполнить за 6 итераций. И далее в конце опять вывести на экран как таблицу.

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows,cols];

void FillArray (int [,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j]=new Random().Next(0,10);;
    }
}
void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
        {
            for (int j=0;j<array.GetLength(1);j++)
                Console.Write($"{array[i,j],3} \t");
        Console.WriteLine();
        }
}

void Mixing (int[,] array)
{
    
    for (int i=0; i<array.GetLength(0);i++)
        {
            for (int j=0;j<array.GetLength(1)/2;j++)
            {
                int temp = array[i,j];
                array[i,j]=array[i,array.GetLength(1)-j-1];
                array[i,array.GetLength(1)-j-1]=temp;
            }
        }
    if (array.GetLength(1)%2!=0)
    {
         for (int i=0; i<array.GetLength(0)/2;i++)
         {
                int temp = array[array.GetLength(0)-i-1,(array.GetLength(1)-1)/2];
                array[array.GetLength(0)-i-1,(array.GetLength(1)-1)/2]=array[i,(array.GetLength(1)-1)/2];
                array[i,(array.GetLength(1)-1)/2]=temp;
         }
    }
    
}

if (rows*cols%2==0)
{
FillArray(array);
PrintArray(array);
Console.WriteLine();
Mixing(array);
PrintArray(array);
}
else Console.WriteLine("Введите количество столбцов и строк такие, чтобы их произведение было четное");