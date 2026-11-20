train[] trains = new train[2];
for (int i = 0; i < trains.Length; i++)
{
    
    Console.Write("Введите номер поезда: ");
    trains[i].number = int.Parse(Console.ReadLine())!;
    Console.Write("Введите направление: ");
    trains[i].way = Console.ReadLine()!;
    Console.Write("Введите время прибытия(Дата и время): ");
    trains[i].arrive = DateTime.Parse(Console.ReadLine())!;
    Console.Write("Введите время отбытия(Дата и время): ");
    trains[i].leave = DateTime.Parse(Console.ReadLine())!;
    Console.Write("Введите расстояние: ");
    trains[i].distance = double.Parse(Console.ReadLine())!;
}
Console.WriteLine("Поезда, находящиеся в пути более суток: ");
for(int i = 0;i < trains.Length;i++)
{
    TimeSpan travelTime = trains[i].arrive - trains[i].leave;
    if(travelTime.TotalHours>24)
    {
        Console.WriteLine($"Поезд номер: {trains[i].number}," +
            $" Направление: {trains[i].way}, " +
            $"Отбытие: {trains[i].leave}, Прибытие: {trains[i].arrive}," +
            $"Расстояние: {trains[i].distance}");
    }
}
struct train
{
    public int number;
    public string way;
    public DateTime arrive;
    public DateTime leave;
    public double distance;
}