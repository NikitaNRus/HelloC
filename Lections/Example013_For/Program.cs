// таблица умножения
// for (int i=2; i<=10; i++)
// {
//     for (int j = 2; j <=10; j++)
//     {
//         Console.WriteLine($"{i}*{j}={i*j}");
//     }
//     Console.WriteLine("");
// }

// Дан текст. В тексте все пробелы заменить черточками, маленбкие буквы
// "к" заменить большими "К", а большие "C" заменить маленькими "с".

string text = "Сегодня мы углубимся в тему и выделим 4 основных группы " 
+ "методов, а также будем использовать их на практике. " 
+ "И познакомимся с новыми языковыми конструкциями, в частности, циклом.";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i=0; i <length; i++)
    {
        if (text[i] == oldValue)  result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine(" ");
newText = Replace(newText,'с', 'С');
Console.WriteLine(newText);
Console.WriteLine(" ");
newText = Replace(newText,'к', 'К');
Console.WriteLine(newText);