Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "Mari")
{
    Console.WriteLine("Ура, это же Марина!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}