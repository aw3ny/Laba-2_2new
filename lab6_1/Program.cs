using ClassLibrary1;
Random rnd = new Random();
int n = 7;
double[,] mas = new double [n, n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        mas[i, j] = rnd.Next(1,11);
        Console.Write($"{mas[i, j] + " "} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
double result = OurClassLibrary.Max(mas);
Console.WriteLine("Произведение:" + result);