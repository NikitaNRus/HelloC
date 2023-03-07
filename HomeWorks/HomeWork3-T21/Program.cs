Console.WriteLine("Введите мерность пространства");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте координаты первой точки");
int [] coordA = new int[N];
for (int i =0; i<N;i++)
{
 Console.WriteLine($"Введите {i+1} координату числа");
 coordA[i]=Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Задайте координаты второй точки");
int [] coordB = new int[N];
for (int i =0; i<N;i++)
{
 Console.WriteLine($"Введите {i+1} координату числа");
 coordB[i]=Convert.ToInt32(Console.ReadLine());
}
// Просмотр ваших массивов
Console.WriteLine("координаты первой точки:");
foreach (int i in coordA)
{
    System.Console.Write("{0} ", i);
}
Console.WriteLine(" ");
Console.WriteLine("координаты второй точки:");
foreach (int i in coordB)
{
    System.Console.Write("{0} ", i);
}
// Евклидово расстояние равно корень суммы квадратов разностей координат точек

    void EvclDist (int N, int []coordA, int []coordB)
    {
    double res = 0;
    double distance = 0;
    for(int i=0;i < N;i++)
       {
       res =res + Math.Pow(coordA[i]+coordB[i],2);
       }
    distance = Math.Sqrt(Convert.ToDouble(res));
    Console.WriteLine($"Евклидово расстояние между вашими точками в {N}-мерном пространстве равно:");
    Console.WriteLine(distance);
    }
EvclDist(N, coordA,coordB);