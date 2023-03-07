// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// Через строку решать нельзя.


int reverse (int x, int rev)
{
    while (x >0)
    {
        int dig = x%10;
        rev = rev*10+dig;
        x = x/10;
    }
    return rev;
}
void pallindrom (int x, int y)
{
    if (x==y)
    Console.WriteLine("Это паллиндром");
    else
    {
    Console.WriteLine("Это не паллиндром");
    }
}


Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int rev = 0;
pallindrom(reverse(num, rev), temp);