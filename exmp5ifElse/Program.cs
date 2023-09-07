Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "маша") //ToLower переводит все символы в строке в нижний регистр
{
    Console.WriteLine("ОМГ Маша привеееет!!!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
