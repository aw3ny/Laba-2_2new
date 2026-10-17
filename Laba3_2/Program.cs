try
{
    Console.Write("Введите k: ");
    int k=int.Parse(Console.ReadLine());
    double A = 1;
    for (int j = 1; j < k; j++)
    {
        if (j == k || Math.Pow(j, 2) == 4) continue ;
        double s = 0;
        for (int i = j; i <= k; i++) 
        {
            if (i == 9) continue;
            s += (i - 3) / (i - 7);
        }
        A *= (Math.Pow(j, 2) - 4) / (j - k + 1) * s;
    }
    Console.WriteLine($"s={A:F2}");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}