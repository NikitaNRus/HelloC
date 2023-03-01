// Зададим кол-во периодов
Console.WriteLine("Сколько периодов используется, включая момент инвестиций");
var n = Convert.ToInt32(Console.ReadLine());
// Зададим инвестиции в t0
Console.WriteLine("Сколько инвестиций осуществлено");
var inv = Convert.ToInt32(Console.ReadLine());
// Определим кол-во нодов для n-ого периода
var nodes = Math.Pow(2,n-1);

// Внесли в массив инвестиции
    double [,] mass = new double [n, (int)nodes];
    int rows = mass.GetUpperBound(0) + 1;    // количество строк
    int columns = mass.Length / rows;        // количество столбцов
    for (int i = 0; i < columns; i++)
    {
        mass[0,i]=-inv;
    }
    for (int i = 0; i < columns; i++)


//просмотр массива
{
    for (int j = 0; j < rows; j++)
    {
        Console.Write($"{mass[j, i]} \t");
    }
    Console.WriteLine();
}