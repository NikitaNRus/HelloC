// напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите константу для первого уравнения");
int a1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент наклона для первого уравнения");
int b1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите константу для второго уравнения");
int a2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент наклона для второго уравнения");
int b2=Convert.ToInt32(Console.ReadLine());

bool CheckIntercept(int a1, int b1, int a2, int b2)
{   
    if (b1==b2) return true;
    else return false;
}

void PrintArray(int[]array)
{
    foreach(int i in array)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}

void Interception (int a1, int b1, int a2, int b2)
{
    if (CheckIntercept(a1,b1,a2,b2)==false)
    {
    int X = (a1-a2)/(b1-b2);
    int Y = a1 +b1*X;
    int [] array = {X,Y};
    Console.WriteLine("Координаты точки пересечения:");
    PrintArray(array);
    }
    else Console.WriteLine("Линии параллельны, либо овпадают");
}
Interception(a1,b1,a2,b2);