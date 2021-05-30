using System;

namespace ЗаданиеИТ
{
    class Program
    {public static void HelloWorld()
        {
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3) != 0 && (i % 5) != 0)
                    Console.Write(i);
                else if ((i % 3) == 0 && (i % 5) != 0)
                    Console.Write("World");
                else if ((i % 3) != 0 && (i % 5) == 0)
                    Console.Write("Hello");
                else if ((i % 3) == 0 && (i % 5) == 0)
                    Console.Write("HelloWorld");
              
            }
            Console.WriteLine();
        }
        public static void skob()
        {
            string temp = "";
            for (int i = 1; i <= 30; i++)
            {
                temp += "(" + i + ")";
            }
            Console.WriteLine(temp);
        }
        public static void Arefm()
        {
            Random ran = new Random();
            int[] aref = new int[10];
            var Ezaref = 0;
            for (int i = 0; i < 10; i++)
            {
                aref[i] = ran.Next(10, 21);
                Ezaref += aref[i];
            }
            Console.WriteLine(Ezaref / 10);
        }
        public static void Matrix(int m, int n)
        {
            Random rand = new Random();
            int[,] matr = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    matr[i, k] = rand.Next();
                    Console.Write(matr[i, k] + " ");

                }
                Console.WriteLine();
            }
        }
        public static string RecMet(string x, string recp = "")
        {
            char l = ' ';
            char[] cha = new char[x.Length];
            for (int i = 0; i < x.Length; ++i)
                cha[i] = x[i];
            for (int i = 0; i < x.Length - 1; i++)
            {
                l = cha[i + 1];
                cha[i + 1] = cha[i];
                cha[i] = l;
                string inf = String.Concat<char>(cha);
                Console.WriteLine(inf);
            }
            string prov = String.Concat<char>(cha);
            if (recp != "")
            {
                if (prov != recp) return RecMet(prov, recp);
                else
                    return null;
            }
            if (prov != recp) return RecMet(prov, x);
            else
                return null;
        }
        public static void Prostc(int n)
        {
            int del = 0;
            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        del++;
                        break;
                    }
                }
                if (del > 0)
                {
                    Console.Write("Делители:");
                    for (var i = 1u; i <= n; i++)
                    {
                        if (n % i == 0)
                        {
                            Console.Write(i + " ");

                        }
                    }
                }
                else Console.WriteLine("Число простое");
            }



        }


        static void Main(string[] args)
        {
            #region
            //            Добрый вечер!
            //1.Вывести числа от 1 до 100 в одну строку со следующими изменениями:
            //            -если число кратно 5 то вместо него вывести Hello
            //            - если число кратно 3 то вместо него вывести World
            //            - если число кратно и 3 и 5 то вместо него вывести HelloWorld
            //            2.Заполнить массив из 10 элементов случайными целыми числами от 10(включительно) до 20(включительно).
            //            Вывести среднее арифметическое.
            //            3.Написать метод который проверяет число простое или нет.Если нет вывести все его делители.
            //            4.Написать рекурсивный(!!!) метод который выводит все перестановки строки. Например для строки abc:
            //            abc, acb, bac, bca, cab, cba
            //            5.Сформировать строку которая представляет собой числа от 1 до 30.Каждое число при этом взять в круглые скобки()
            //            6.Создать 2мерный массив(матрица) M* N  и заполнить его случайными числами.
            //            Отсортировать числа по возрастанию, чтобы с левом верхнем углу было самое маленькое число, справа от него следующее по значению,
            //            итд, в правом нижнем углу самое большое.
            //            7.Задан текстовый файл. Вывести сколько в нём:
            //            a) строк
            //            b) слов
            //            c) символов
            //            9.Задана строка с датой вида "22.01.2019 19:15:00".Написать метод который преобразовывает ее в формат "22 Jan, 7:15 PM".
            //            Предусмотреть обработку ситуации если входящая дата в недопустимом формате.
            //            10.Написать пример для демонстрации модификатра доступа `protected`.
            //            11. Есть List объектов у каждого из которых 2 поля: int и String.
            //            Удалить те у которых значения int повторяются(оставить по одному из дубликатов).
            #endregion
            Console.WriteLine("Задание №1:");
            HelloWorld();
            Console.WriteLine("Задание №2:");
            Arefm();
            Console.WriteLine("Задание №3:");
            Prostc(7);
            Console.WriteLine("Задание №4:");
            RecMet("0123");
            Console.WriteLine("Задание №5:");
            skob();
            Console.WriteLine("Задание №6:");
            Matrix(4, 5);
            Console.WriteLine("Задание №7:");
            Файл fl = new Файл();
            fl.Fil();
            Console.WriteLine("Задание №9:");
            Дата дата = new Дата();
            дата.Dat("22.01.2019 19:15:00");
            Console.WriteLine("Задание №10:");
            Protec pro = new Protec();
            ProtNasled protNasled = new ProtNasled();
            protNasled.TestProtec();
            Console.WriteLine("Задание №11:");
            Лист lis = new Лист();
            lis.MetList();


        }
    }
}
