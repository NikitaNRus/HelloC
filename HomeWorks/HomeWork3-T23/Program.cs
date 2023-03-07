Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
void power3 (int N)
{
    for(int i = 1; i<=N;i++)
    {
        int power = i*i*i;
        Console.WriteLine(i+"->"+power);
    }
}

power3(N);
