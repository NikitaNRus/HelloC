﻿// void Method1()
// {
//     Console.WriteLine("Автор");
// }

// Method1();

//Вид 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i =0;
//     while (i<count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(msg:"Текст сообщения",count: 4);

// Вид 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// Вид 4 Что-то принимает, что-то возвращает
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while(i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "Hi, ");
// Console.WriteLine(res);


string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i =0; i<count;i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "Hi, ");
Console.WriteLine(res);