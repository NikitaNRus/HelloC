Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "никита")
{
    Console.WriteLine("Ура, это же Никита!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}