// 0 - закраш, 1 - незакраш
int[,] pic = new int[,]
{
    {0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,1,1,1,1,1,1,1,1,0,0},
    {0,0,1,0,0,0,0,0,0,1,0,0},
    {0,0,1,1,0,0,0,0,0,1,0,0},
    {0,0,0,1,0,0,0,0,0,1,0,0},
    {0,0,0,1,0,0,0,1,1,1,0,0},
    {0,0,0,1,1,1,0,0,0,1,0,0},
    {0,0,0,0,0,1,0,0,0,1,0,0},
    {0,0,0,0,0,1,0,0,0,1,0,0},
    {0,0,0,0,0,1,1,1,1,1,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0},
    {0,0,0,0,0,0,0,0,0,0,0,0}
};


void ImageMatrix(int [,] matrix)
{
for (int i =0; i<matrix.GetLength(0);i++) //GetLength(0) -возвращает строки
{
    for (int j =0;j<matrix.GetLength(1);j++) //GetLength(1) -возвращает столбцы
    {
        // Console.Write($"{matrix[i,j]} ");
        if (matrix[i,j]==0) Console.Write($" ");
        else Console.Write($"+");
    }
Console.WriteLine();
}
}


void FillImage(int row, int col)
{
    if (pic[row,col]==0)
    {
        pic[row,col]=1;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    }
}


FillImage(5,5);
ImageMatrix(pic);