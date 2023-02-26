// Пример цикла
// int start =1;
// int finish =30;
// while (start<=finish)
// {
//     Console.Write(start+" ");
//     start++;
// }

// На вход одно число N, а на выходе показывает все целые числа в промежутке от -N до N.
// Console.Write("Введите целое число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// N = Math.Abs(N);
// int start = -N;
// while (start<=N)
// {
//     Console.Write(" {0} ",start+" ");
//     start++;
// }

// На вход принимает трехзначное число и на выходе показывает последнюю цифру этого числа
Console.Write("Введите трехзначное число: ");
int Num = Convert.ToInt32(Console.ReadLine());
int div = Num %10;
Console.Write("Последняя цифра числа = {0}", div);

