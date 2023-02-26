// робот, когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".
// Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.

Console.WriteLine("Введите целое неотрицательное число ");
int NumA = Convert.ToInt32(Console.ReadLine());
if ((NumA<=20)&&(NumA>=5))
{
    Console.WriteLine($"{NumA} программистов");
}
else if ((NumA%10>=2)&&(NumA%10<=4))
{
    Console.WriteLine($"{NumA} программиста");
}
else if (NumA%100==11)
{
    Console.WriteLine($"{NumA} программистов");
}
else if (NumA%10==1)
{
    Console.WriteLine($"{NumA} программист");
}
else 
Console.WriteLine($"{NumA} программистов");