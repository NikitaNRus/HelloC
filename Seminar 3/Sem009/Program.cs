// Прога получает на вход координаты двух точек и находит расстояние между ними
// векторной расстояние между точками sqrt((x2-x1)^2 + (y2-y1)^2)

// double dist (int x1, int y1,int x2,int y2)
// {
//     double res = 0;
//     res = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
//     return res;
// }

// Console.WriteLine("Введите координату первой точки X");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату первой точки Y");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату второй точки X");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату второй точки Y");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(dist(x1,y1,x2,y2));

// Прога выдает таблицу квадратов чисел от 1 до N. N вводит пользователь.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
void square (int N)
{
    for(int i = 1; i<=N;i++)
    {
        int sqrt = i*i;
        Console.WriteLine(i+"->"+sqrt);
    }
}

square(N);





// Программа, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N

// Console.WriteLine("Введите целое число");
// int x = Convert.ToInt32)Console.ReadLine());

// void table (int x)
// {
//     for (int i =0;i<x;i++)
//     {

//     }
// }