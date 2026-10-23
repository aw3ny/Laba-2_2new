//using System.Xml;
//using System.Xml.Linq;

//int[] mas1 = new int[5];
//int[] mas2 = { 1, 4, 2, 9, 3 };
////int[] mas3 = mas2;
//mas3[3] = 12;
//Console.WriteLine(mas3[3]);
//Console.WriteLine(mas2[3]);

//ввод вручную
//int[] mas4= new int[5];
//for (int i = 0; i < mas4.Length; i++) 
//    mas4[i] = int.Parse(Console.ReadLine());
//for (int i = 0; i < mas4.Length; i++)
//    Console.Write($"{mas4[i]}");

//ввод по формуле
//int[] mas5 = new int[5];
//for (int i = 0; i < mas5.Length; i++)
//{
//    mas5[i] = 2 * i + 1;
//    Console.Write($"{mas5[i]}");
//}
//Console.WriteLine();

//использование генератора случайных чисел
//Random rnd = new Random();
//int[] mas6 = new int[rnd.Next(5,15)];
//for (int i = 0; i < mas6.Length; i++)
//{
//    mas6[i] = rnd.Next(1,100);
//    Console.Write($"{mas6[i]}");
//}

//Дан целочисленный массив состоящий из 10 элементов.
//Элементы массива принимают значения в интервале [-7; 7].
//Найдите последнее вхождение в массив элемента n (n вводится с клавиатуры).
//Подсчитайте количество элементов массива меньших n. 

//int[] mas = new int[10];
//Random rnd = new Random();
//try
//{
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-7, 8);
//        Console.Write($"{mas[i]}");
//    }
//    Console.WriteLine();
//    Console.Write("Введите n:");
//    int n = int.Parse(Console.ReadLine());
//    int index = -1;
//    int less_n = 0;
//    for (int i = 0;i< mas.Length; i++)
//    {
//        if (mas[i]==n) index = 1;
//        if (mas[i] < n) less_n++;
//    }
//    Console.WriteLine($"Индекс последнего вхожджения: {n}={index}");
//    Console.WriteLine($"Количество элементов меньших: {n}={less_n}");
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//Дан целочисленный массив состоящий из n элементов.
//Элементы массива принимают значения в интервале [-10; 10].
//Найдите максимальный элемент массива 

//try
//{
//    Console.Write("Введите n: ");
//    int n = int.Parse(Console.ReadLine());
//    Random rnd = new Random();
//    int[] mas = new int[n];
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-10 , 11);
//        Console.WriteLine($"{mas[i]}");
//    }
//    Console.WriteLine();
//    int max = mas[0];
//    for (int i = 1; i < mas.Length; i++)
//    {
//        if( mas[i] > max ) max = mas[i];
//    }
//    Console.WriteLine($"max={max}");
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//отсортировать элементы массива по возрастанию
//try
//{
//    Random rnd = new Random();
//    int[] mas = new int[rnd.Next(10, 20)];
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(10, 100);
//        Console.Write($"{mas[i]} ");
//    }
//    Console.WriteLine();
//    for (int i = 0;i < mas.Length-1; i++)
//    {
//        for(int j = i+1; j< mas.Length; j++)
//        {
//            if (mas[i] > mas[j])
//            {
//                int temp = mas[i];
//                mas[i] = mas[j];
//                mas[j] = temp;
//            }
//        }
//    }
//    foreach (int i in mas) Console.Write($"{i} ");
//    Console.WriteLine();
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите размер массива:");
//    int n = int.Parse(Console.ReadLine());
//    int[] mas = new int[n];
//    Random rnd = new Random();
//    int s = 0;
//    for(int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-13, 12);
//        Console.Write($"{mas[i]} ");
//        s += mas[i];
//    }
//    Console.Write($"s={s} ");
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Console.Write("Введите размер массива:");
//    int n = int.Parse(Console.ReadLine());
//    int[] mas = new int[n];
//    Random rnd = new Random();
//    int p = 0;
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-19, 26);
//        Console.Write($"{mas[i]} ");
//        if (i % 2 != 0) p *= mas[i];
//    }

//    Console.Write($"s={p} ");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//try
//{
//    Random rnd = new Random();
//    int[] mas = new int[rnd.Next(10,30)];
//    int count = 0;
//    for (int i = 0; i < mas1.Length; i++)
//    {
//        mas[i] = rnd.Next(-5,5);
//    }

//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//string? name = null;
//Console.WriteLine(name);
//int n = int.Parse(Console.ReadLine()!);

//string? text="Sam";
//string name = text ?? "Tom";
//Console.WriteLine(name);

//int? id = null;
//int personId = id ?? 1;
//Console.WriteLine(personId);

// базовый

//Random random = new Random();
//double[] mas = new double[12];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.NextDouble() * 100;
//    Console.Write($"{mas[i]:F2} ");
//}
//Console.WriteLine();
//double min = mas[0];
//int index = 0;
//for (int i = 1; i < mas.Length; i++)
//{
//    if (mas[i] < min)
//    {
//        min = mas[i]; index = i;
//    }
//}
//Console.WriteLine($"Сумма мин.элемента {min:f2} и его индекса {index}:" +
//    $" {min + index:f2} ");

// средний

//Random random = new Random();
//double[] mas1 = new double[random.Next(10,20)];
//double[] mas2 = new double[random.Next(10, 20)];
//for (int i = 0; i < mas1.Length; i++)
//{
//    mas1[i] = random.NextDouble() * 100;
//    Console.Write($"{mas1[i]:F2} ");
//}
//for (int i = 0; i < mas1.Length; i++)
//{
//    mas2[i] = random.NextDouble() * 100;
//    Console.Write($"{mas2[i]:F2} ");
//}
//    Console.WriteLine();
//double min1 = mas1[0];
//int index1 = 0;
//for (int i = 1; i < mas1.Length; i++)
//{
//    if (mas1[i] < min1)
//    {
//        min1 = mas1[i]; index1 = i;
//    }

//}
//double min2 = mas2[0];
//int index2 = 0;
//for (int i = 1; i < mas2.Length; i++)
//{
//    if (mas2[i] < min2)
//    {
//        min2 = mas2[i]; index2 = i;
//    }
//}
//mas1[index1] = min2;
//mas2[index2] = min1;
//Console.WriteLine($"{min1}-{index1}");
//Console.WriteLine($"{min2}-{index2}");
//Console.WriteLine($"Сумма мин.элемента {min:f2} и его индекса {index}:" +
//    $" {min + index:f2}

// высокий

//Random random = new Random();
//int[] mas = new int[3];
//for (int i = 0; i < 3; i++)
//{
//    mas[i] = random.Next(10, 100);
//    Console.Write($"{mas[i]} ");
//}
//Console.WriteLine();
//string[] str = new string[3];
//for(int i = 0;i < str.Length;i++)
//{
//    str[i] = Convert.ToString(mas[i], 2);
//    Console.Write($"{str[i]} ");
//}
//Console.WriteLine();

// двумерный массив

//Random rnd = new Random();
//int[,] mas = new int[4, 4];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = rnd.Next(-5, 6);
//        Console.Write($"{mas[i, j]} ");
//    }
//    Console.WriteLine();
//}
//int min = mas[0, 0];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        if (mas[i, j] < min) min = mas[i, j];
//    }
//}
//Console.WriteLine();
//Console.WriteLine($"min={min} ");
//Console.WriteLine();
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        if (mas[i, j] % 2 == 0) mas[i, j] *= 2;
//        else mas[i, j] *= 3;
//        Console.Write($"{mas[i, j]} ");
//    }
//    Console.WriteLine();
//}

//Random rnd=new Random();
//int n = rnd.Next(3, 10);
//int[,] mas = new int[n, n];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = rnd.Next(-3, 4);
//        Console.Write($"{mas[i,j]} ");
//    }
//    Console.WriteLine();
//}
//double S = 0;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        if(i==j) S+= mas[i, j];
//    }
//}
//Console.WriteLine($"{S / mas.GetLength(0):f2}");
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        if (mas[i, j] < 0) mas[i, j] = Math.Abs(mas[i, j]);
//        Console.Write($"{mas[i,j]} ");
//    }
//    Console.WriteLine();
//}
//S = 0;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        if (i == j) S += mas[i, j];
//    }
//}
//Console.WriteLine($"{S/mas.GetLength(0):f2}");

// базовый

//Random rnd = new Random();
//int[,] mas = new int[rnd.Next(4, 9), rnd.Next(4, 9)];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = rnd.Next(-3, 4);
//        Console.Write($"{mas[i, j]} ");
//    }
//    Console.WriteLine();
//}
//int count = 0;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    if (mas[i, 1] >= 0) count++;
//}
//Console.WriteLine($"Количество не отрицательных элементов во втором столбце: {count}");

// средний

/*Random rnd = new Random();
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
    if (mas[0, j] <= 0) mas[0,j]=0 ;
    Console.Write($"{mas[0,j]} ");
}
Console.WriteLine();*/