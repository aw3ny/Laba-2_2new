try
{
    Console.Write("Ведите число от 1 до 99:");
    int n = int.Parse(Console.ReadLine());
    if (n == 1 || n == 21 || n == 31 || n == 41 || n == 51 || n == 61 || n == 71 || n == 81 || n == 91)
        Console.WriteLine($"{n} Копейка");
    else if (n == 2 || n == 3 || n == 22 || n == 23 || n == 24 || n == 32 || n == 33 || n == 34 || n == 42 || n == 43 || n == 44 || n == 52 || n == 53 || n == 54 || n == 62 || n == 63 || n == 64 || n == 72 || n == 73 || n == 74 || n == 82 || n == 83 || n == 84 || n == 92 || n == 93 || n == 94)
        Console.WriteLine($"{n} Копейки");
    else Console.WriteLine($"{n} Копеек");
}

catch (Exception e)
{
    Console.WriteLine(e.Message);
}