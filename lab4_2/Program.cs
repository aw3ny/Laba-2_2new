Random rnd = new Random();
int[,] mas = new int[rnd.Next(5, 5), rnd.Next(5, 5)];
for (int i = 0; i < mas.GetLength(0); i++)
{
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        mas[i, j] = rnd.Next(-5, 10);
        Console.Write($"{mas[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int j = 0; j < mas.GetLength(0); j++)
{
    if (mas[0, j] <= 0) mas[0, j] = 0;
    Console.Write($"{mas[0, j]} ");
}
Console.WriteLine();