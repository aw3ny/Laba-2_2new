//DayTime dayTime = DayTime.Morning;
//if (dayTime == DayTime.Morning)
//    Console.WriteLine("Доброе утро!");
//else
//    Console.WriteLine("Привет!");

//DoOperation(10, 5, Operation.Add);          // 15
//DoOperation(10, 5, Operation.Sub);     // 5
//DoOperation(10, 5, Operation.Mult);     // 50
//DoOperation(10, 5, Operation.Div);       // 2
//void DoOperation(double x, double y, Operation op)
//{
//    double result = op switch
//    {
//        Operation.Add => x + y,
//        Operation.Sub => x - y,
//        Operation.Mult => x * y,
//        Operation.Div => x / y
//    };
//    Console.WriteLine(result);
//}
//enum DayTime
//{
//    Morning,
//    Afternoon,
//    Evening,
//    Night
//}

//enum Operation
//{
//    Add,
//    Sub,
//    Mult,
//    Div
//}

//Person tom = new Person();
//tom.name = "vasya";
//tom.age = 18;
//Console.WriteLine(tom.name);
//Console.WriteLine(tom.age);
//struct Person
//{
//    public string name;
//    public int age;
//}

//Базовый

using System.Threading.Channels;

Comp[] comps = new Comp[1];
for (int i = 0; i < comps.Length; i++)
{
    Console.Write("Введите название ПК: ");
    comps[i].name = Console.ReadLine()!;
    Console.Write("Введите частоту CPU: ");
    comps[i].frequancy = int.Parse(Console.ReadLine())!;
    Console.Write("Введите количество ОЗУ: ");
    comps[i].memory = int.Parse(Console.ReadLine())!;
    Console.Write("Введите наличие DVD: Да/Нет? ");
    string dvd = Console.ReadLine()!;
    if (dvd == "Да") comps[i].DVD = true;
    else comps[i].DVD = false;
    Console.Write("Введите цену: ");
    comps[i].price = decimal.Parse(Console.ReadLine())!;
    Console.WriteLine();
}
for (int i = 0;i < comps.Length;i++)
{
    if (comps[i].DVD) comps[i].Print();
}
struct Comp
{
    public string name;
    public int frequancy;
    public int memory;
    public bool DVD;
    public decimal price;
    public void Print()
    {
        Console.WriteLine($"Название: {name}, Частота: {frequancy}," +
            $" Память: {memory}, {((DVD)?"DVD":"")}, Цена: {price}");
    }
}