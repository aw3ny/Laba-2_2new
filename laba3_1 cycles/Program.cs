Console.Write("Введите количество минут:");
int minutes=int.Parse(Console.ReadLine());
int bacteria = 1;
int i = 0;
while(i< minutes)
{
    bacteria *= 2;
    i++;
}
Console.WriteLine($"Количество бактерий: {bacteria} ");
