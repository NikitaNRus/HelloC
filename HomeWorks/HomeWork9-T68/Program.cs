// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// if n=0 => m+1
// if n!=0, m=0 => A(n-1,1)
// if n>0, m>0 => A(n-1, A(n,m-1))


Console.WriteLine("Введите цифру Большую");
int numBig = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите цифру Меньшую");
int numSmall = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akkerman(numBig, numSmall));

int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

