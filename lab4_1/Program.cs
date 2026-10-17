Random rnd=new Random();
int[] mas=new int[10];
int p = 0;
int j = 0;
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = rnd.Next(-10,10);
    Console.Write($"{mas[i]} ");
    if (mas[i] >= 0) p += mas[i];
    else break;
    j++;
}
Console.WriteLine();
Console.WriteLine($"Сумма массива: {p} Количество элементов: {j}");