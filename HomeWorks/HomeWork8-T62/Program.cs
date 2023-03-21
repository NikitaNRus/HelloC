// Напишите программу, которая заполнит спирально массив 4 на 4.
// На входе - натуральное число от пользователя, например 4.
Console.WriteLine("Введите размерность симметричной матрицы");
int dim = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [dim,dim];

int[,] FillArray (int [,] array)
{   int s = 1;
    for (int i =0; i<array.GetLength(0);i++)
    {
        array[0,i]=s;
        s++;
    }
    for (int j =1;j<array.GetLength(0);j++)
    {
        array[j,array.GetLength(0)-1]=s;
        s++;
    }
    for (int i =array.GetLength(0)-2; i>=0;i--)
    {
        array[array.GetLength(0)-1,i]=s;
        s++;
    }
    for (int j =array.GetLength(0)-2;j>0;j--)
    {
        array[j,0]=s;
        s++;
    }
int row =1;
int col =1;
while(s<array.GetLength(0)*array.GetLength(1))
{   //Вправо
    while (array[row,col+1]==0)
    {
        array[row,col]=s;
        s++;
        col++;
    }
    //Вниз
    while (array[row+1,col]==0)
    {
        array[row,col]=s;
        s++;
        row++;
    }
    //Влево
    while (array[row,col-1]==0)
    {
        array[row,col]=s;
        s++;
        col--;
    }
    //Вверх
    while (array[row-1,col]==0)
    {
        array[row,col]=s;
        s++;
        row--;
    }
}
for (int n =0; n<array.GetLength(0);n++)
{
    for (int m =0; m<array.GetLength(1);m++)
    {
        if (array[n,m]==0)
            array[n,m]=s;
 }}
    return array;
}
void PrintArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0);i++)
        {
            for (int j=0;j<array.GetLength(1);j++)
                
                Console.Write($"{array[i,j],3} \t");
        Console.WriteLine();
}}

array = FillArray(array);
PrintArray(array);
