//char ch = new char();
//ch = 'в';
//bool p2 = char.IsDigit(ch);
//if (p2) Console.WriteLine(" Цифра ");
//else Console.WriteLine("Не цифра");

//char ch1 = '1';
//bool p1 = char.IsLetter(ch1);
//if (p1) Console.WriteLine("Буква ");
//else Console.WriteLine("Не буква");

//char ch3 = '\x99';
//bool p3 = char.IsControl(ch3);
//if (p3)
//    Console.WriteLine(" Управляющий");
//else
//    Console.WriteLine("Не управляющий");

//string s1 = "ABC", s2 = "CDE";
//bool b1 = (s1 == s2);
//Console.WriteLine("s1=s2 {0}", b1);

//string s1 = "huy";
//chch1 = s1[0]; ch2 = s1[1]; ch3 = s1[2];
//Console.WriteLine("s1[0]={0}, s1[1]={1}, s1[2]={2}", ch1, ch2, ch3);

//ar ch1, ch2, ch3;

//string s1 = "ABC", s2 = "CDEFG";
//int L1, L2;
//L1 = s1.Length; L2 = s2.Length;
//Console.WriteLine($"Длина строки {s1}={L1}");
//Console.WriteLine($"Длина строки {s2}={L2}");

//string s1, s2;
//s1 = Console.ReadLine();
//s2 = "";
//// i параметр цикла, L длина строки s1
//int i, L;
//L = s1.Length;
////накопление строки s2
//for (i = 0; i < L; i++)
//    s2 = s2 + s1[L - i - 1];
//Console.WriteLine($"s1={s1}, s2={s2}"); 
//Console.ReadKey();

//char c = 'A';
//Console.WriteLine((int)c);
//for(int i = 35; i < 100; i++)
//    Console.Write((char)i + " 
//Console.WriteLine();
//Console.WriteLine(char.IsDigit('5'));
//Console.WriteLine(char.IsLetter('X'));

//базовый
//char[,] matrix = new char[5, 7];
//Random random = new Random();
//for(int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        matrix[i, j] = (char)random.Next(40, 70);
//        Console.Write(matrix[i,j]+" ");
//    }
//    Console.WriteLine();
//}
//int summ = 0;
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    for (int j = 0; j < matrix.GetLength(1); j++)
//    {
//        if (char.IsDigit(matrix[i, j])) 
//            summ += int.Parse(matrix[i, j].ToString());
//    }
//    Console.WriteLine();
//}
//Console.WriteLine($"summ={summ}");

//средний

//char[] mas = new char[15];
//Console.Write("Введите стркоу:");
//string stroka = Console.ReadLine()!;
//mas = stroka.ToArray();
//Console.WriteLine("Введите строку поиска:");
//string word=Console.ReadLine()!;
//int count = 0;
//int wordlenght = word.Length;
//for(int i = 0;i < mas.Length-word.Length;i++)
//{
//    bool match = true;
//    for(int j = 0;j < wordlenght;j++)
//    {
//        if (mas[i+j] != word[j])
//        {
//            match = false;
//            break;
//        }
//    }
//    if (match) count++;
//}
//Console.WriteLine($"Слово: {word}, встречается в массиве: {count}");

//высокий

