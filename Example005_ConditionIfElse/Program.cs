Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Nastya")
{
    Console.WriteLine("Здравствуйте, Анастасия!"); 
}

else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}


