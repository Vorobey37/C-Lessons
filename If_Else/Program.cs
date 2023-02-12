Console.WriteLine("Введите имя пользователя:");
string u_n = Console.ReadLine();
if (u_n.ToLower() == "алексей")
{
    Console.WriteLine("Чё, как дела, Лёхич?");
}
else 
{
    Console.Write("Привет,");
    Console.WriteLine(u_n);
}