// 
// double Factorial (int Num)
// {
//     if (Num==1 || Num==0) return 1;
//     else return Num*Factorial(Num-1);
// }


// for (int i=0;i<40;i++)
// {
// Console.WriteLine($"{i}!={Factorial(i)}");
// }


// ФИБОНАЧЧИ
//f(1) = 1
//f(2) = 1
//f(n) = f(n-1) + f(n-2)

double Fibonacci (int n)
{
    if (n==1 || n ==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i=1; i<40;i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}