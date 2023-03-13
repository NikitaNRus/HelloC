// string [,] table = new string [2,5];
// // сначала строки, потом столбцы
// table[1,2] = "word";
// for (int rows =0; rows<2;rows++)
// {
//     for (int columns = 0; columns<5; columns++)
//     {
//         Console.WriteLine($"-{table[rows,columns]}-");
//     }
// }

//печатаем массив


void PrintMatrix(int [,] matrix)
{
for (int i =0; i<matrix.GetLength(0);i++) //GetLength(0) -возвращает строки
{
    for (int j =0;j<matrix.GetLength(1);j++) //GetLength(1) -возвращает столбцы
    {
        Console.Write($"{matrix[i,j]} ");
    }
Console.WriteLine();
}
}
void FillMatrix(int [,] matrix)
{
    for (int i =0; i<matrix.GetLength(0);i++)
    {
        for (int j =0;j<matrix.GetLength(1);j++)
        {
            matrix[i,j] = new Random().Next(1,10);
        }
    }

}

int[,] matrix = new int[3,4];
PrintMatrix(matrix);
FillMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);