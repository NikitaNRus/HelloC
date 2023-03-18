// Фибоначии не используя рекурсию

// Console.WriteLine("Введите число N");
// int N = Convert.ToInt32(Console.ReadLine());
// int [] array = new int[N];

// void FillArray(int [] array)
// {
//     array[0]=0;
//     array [1]=1;
//     for (int i =2; i<N;i++)
//     array[i]=array[i-1]+array[i-2];
// }
// FillArray(array);

// foreach (int i in array)
// {
//     Console.Write(" " +i);
// }

// НегаФибоначчи
Console.WriteLine("Введите число k");
int k = Convert.ToInt32(Console.ReadLine());
int len = k+k-1;
int [] array = new int [len];
void FillArray(int[]array)
{
    array[len/2] = 0;
    array[len/2+1]=1;
    array[len/2-1]=-1;
    for (int i=len/2+2;i<len;i++)
        array [i]=array[i-1]+array[i-2];
    for (int i=len/2-2;i>=0;i--)
        array [i]=array[i+1]+array[i+2];
}
FillArray(array);

foreach (int i in array)
{
    Console.Write(" " +i);
}
