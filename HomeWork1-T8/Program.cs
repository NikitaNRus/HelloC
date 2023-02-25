// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите целое число ");
int NumA = Convert.ToInt32(Console.ReadLine());
int start =1;
while(start<=(NumA))
{
    if((start%2==0))
    {Console.Write(start+" ");
    start++;
    }
    else
    start++;
}