using System.Text.RegularExpressions;

Console.WriteLine("Введите строку:");
string x = Console.ReadLine();
if (Regex.IsMatch(x," "))
    Console.WriteLine("Да, в строку входит пробел");
else Console.WriteLine("Нет, в строку не входит пробел");