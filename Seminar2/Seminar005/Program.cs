// Напишем прогу, которая принимает на вход два числа и выводит, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления

Console.WriteLine("Введите два числа: ");
int NumA = Convert.ToInt32(Console.ReadLine());
int NumB = Convert.ToInt32(Console.ReadLine());
int div = NumA%NumB;
if (div==0)
{
    Console.WriteLine("Кратно");
}
else 
{
    div = NumA%NumB;
    Console.WriteLine($"Остаток деления = {div}");
}




// // Вводит случайное число и удаляет вторую цифру этого числа

// int num = new Random().Next(100,1000);
// Console.WriteLine($"Было сгенерировано число {num}");
// int x1 = num/100;
// int x2 = num%10; 
// int res = x1*10+x2;
// Console.WriteLine(res);