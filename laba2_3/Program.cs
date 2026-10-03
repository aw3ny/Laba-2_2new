//try
//{
//    Console.Write("Введите номер дня недели:");
//    int n = int.Parse(Console.ReadLine());
//    switch (n)
//    {
//        case 1:
//            Console.WriteLine("Понедельник");
//            break;
//        case 2:
//            Console.WriteLine("Вторник");
//            break;
//        case 3:
//            Console.WriteLine("Среда");
//            break;
//        case 4:
//            Console.WriteLine("Четверг");
//            break;
//        case 5:
//            Console.WriteLine("Пятница");
//            break;
//        case 6:
//            Console.WriteLine("Суббота");
//            break;
//        case 7:
//            Console.WriteLine("Воскресенье");
//            break;
//        default:
//            Console.WriteLine("Нет такого дня недели");
//            break;

//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}



//try
//{
//    Console.Write("Введите номер месяца:");
//    int n = int.Parse(Console.ReadLine());
//    switch (n)
//    {
//        case 12:case 1:case 2:
//            Console.WriteLine("Зима");
//            break;
//        case 3:
//        case 4:
//        case 5:
//            Console.WriteLine("Весна");
//            break;
//        case 6:
//        case 7:
//        case 8:
//            Console.WriteLine("Лето");
//            break;
//        case 9:case 10:case 11:
//            Console.WriteLine("осень");
//            break;
//        default:
//            Console.WriteLine("Нет такого месяца");
//            break;
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}


//try
//{
//    Console.Write("Введите номер карты");
//    int n = int.Parse(Console.ReadLine());
//    Console.Write("Введите номер масти");
//    int m = int.Parse(Console.ReadLine());
//    switch (n)
//    {
//        case 6:
//            Console.WriteLine("Шестерка");
//            break;
//        case 7:
//            Console.WriteLine("Семерка");
//            break;
//        case 8:
//            Console.WriteLine("Восьмерка");
//            break;
//        case 9:
//            Console.WriteLine("Девятка");
//            break;
//        case 10:
//            Console.WriteLine("Десятка");
//            break;
//        case 11:
//            Console.WriteLine("Валет");
//            break;
//        case 12:
//            Console.WriteLine("Дама");
//            break;
//        case 13:
//            Console.WriteLine("Король");
//            break;
//        case 14:
//            Console.WriteLine("Туз");
//            break;
//        default:
//            Console.WriteLine("Нет такой карты");
//            break;
//    }
//    switch(m)
//    {
//        case 1:
//            Console.WriteLine("Буби");
//            break;
//        case 2:
//            Console.WriteLine("Пики");
//            break;
//        case 3:
//            Console.WriteLine("Черви");
//            break;
//        case 4:
//            Console.WriteLine("Крести");
//            break;
//        default:
//            Console.WriteLine("Нет такой масти");
//            break;
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}как правильно рубль от 1 до 99


//try
//{
//    Console.Write("Введите сумму:");
//    double n = double.Parse(Console.ReadLine());
//    if (x % 100 >== 11 && x % 100 <== 14) Console.WriteLine($"{x} рублей");
//    else
//    {
//        switch(x%10)
//        {
//            case 1:
//                Console.WriteLine($"{x} рубль");
//                break;
//            case 2: case 3: case 4:
//                Console.WriteLine($"{x} рубля");
//                break;
//            default:
//                Console.WriteLine($"{x} рублей");
//                break;
//        }
//    }

//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}


using System.ComponentModel.Design;

try
{
    Console.WriteLine("Введите число");
    double n = double.Parse(Console.ReadLine());
    switch (n)
    {
        case 1:
            {
                double A = 3, b = 3.5, C = -2.1;
                if ((A * A) + (b * b) == (C * C)) Console.WriteLine("Прямоугольный треуголник");
                else
                {
                    Console.WriteLine("Треугольник не прямоугольный");
                }
                    break;
            }
        case 2:
            {
                double A = 21, b = -6.55, C = 0.1;
                if ((A * A) + (b * b) == (C * C)) Console.WriteLine("Прямоугольный треуголник");
                else
                {
                    Console.WriteLine("Треугольник не прямоугольный");
                }
                break;
            }
        case 3:
            {
                double A = -9, b = -3.7, C = -0.1;
                if ((A * A) + (b * b) == (C * C)) Console.WriteLine("Прямоугольный треуголник");
                else
                {
                    Console.WriteLine("Треугольник не прямоугольный");
                }
                break;
            }
    }
}

catch (Exception e)
{
    Console.WriteLine(e.Message);
}