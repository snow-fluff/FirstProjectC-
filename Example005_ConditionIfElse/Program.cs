Console.Write("Введите ваше имя: ");
string UserName = Console.ReadLine();
if(UserName.ToLower() == "саша")
{  
    Console.WriteLine("Ура, это же Саша!");
}
else
{
        Console.Write("Привет, ");
        Console.WriteLine(UserName);
}