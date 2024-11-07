using System;
using System.Threading;
class Hello
{
    public static void Main()
    {
        Console.WriteLine("task 1");
        double ee = Math.E;
        Console.WriteLine(ee);

        Console.WriteLine("\ntask 2");
        Console.WriteLine("50\n10");

        Console.WriteLine("\ntask 3");
        Console.WriteLine("1\n22\n333\n4444");

        Console.WriteLine("\ntask 4");
        Console.Write("enter the number:");
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("the result :" + (n + 10));

        Console.WriteLine("\ntask 5");
        Console.Write("the side of the square:");
        int n1;
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("perimeter: " + (n1 * 4));

        Console.WriteLine("\ntask 6");
        Console.Write("the radius of the circle:");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("circumference of the circle: " + (n2 * 2 * 3.14));
        Console.WriteLine("the area of the circle: " + (n2 * n2 * 3.14));

        Console.WriteLine("\ntask 7");
        Console.Write("enter x: ");
        int x3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Cos(x3 * 3.14 / 180));

        Console.WriteLine("\ntask 8");
        int n3, n4, n5;
        Console.Write("big base of the trapezoid: ");
        n3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("small base of the trapezoid: ");
        n4 = Convert.ToInt32(Console.ReadLine());
        Console.Write("trapezoid height: ");
        n5 = Convert.ToInt32(Console.ReadLine());
        int a, b;
        double c;
        a = (n3 - n4) / 2;
        b = a * a + n5 * n5;
        c = Math.Sqrt(b);
        Console.WriteLine("perimeter: " + (n3 + n4 + c * 2));

        Console.WriteLine("\ntask 9");
        int n6, n7, n8;
        Console.Write("the cost of 1 kg of sweets: ");
        n6 = Convert.ToInt32(Console.ReadLine());
        Console.Write("the cost of 1 kg of cookies: ");
        n7 = Convert.ToInt32(Console.ReadLine());
        Console.Write("the cost of 1 kg of apples: ");
        n8 = Convert.ToInt32(Console.ReadLine());
        int x, y, z;
        Console.Write("\nhow many kg of sweets: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("how many kg of cookies: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.Write("how many kg of apples: ");
        z = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("total cost:" + (n6 * x + n7 * y + n8 * z));

        Console.WriteLine("\ntask 10");
        Console.WriteLine("Мир Труд Май");
        Console.WriteLine("Мир");
        Console.WriteLine("    Труд");
        Console.WriteLine("         Май");

        Console.WriteLine("\ntask 11");

        Console.WriteLine("\ntask 12");
        Console.Write("выберите фигуру: треугольник/четырехугольник/круг: ");
        string f = Console.ReadLine();
        Console.Write("что будем вычислять? площадь/периметр: ");
        string l = Console.ReadLine();
        if (l == "периметр")
        {
            if (f == "треугольник")
            {
                Console.Write("введите длину первой стороны треугольника:");
                int t1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("введите длину второй стороны треугольника:");
                int t2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("введите длину третьей стороны треугольника:");
                int t3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"периметр треугольника: {t1 + t2 + t3}");
            }
            else if (f == "четырехугольник")
            {
                Console.Write("введите длину первой стороны четырехугольника:");
                int t4 = Convert.ToInt32(Console.ReadLine());
                Console.Write("введите длину второй стороны четырехугольника:");
                int t5 = Convert.ToInt32(Console.ReadLine());
                Console.Write("введите длину третьей стороны четырехугольника:");
                int t6 = Convert.ToInt32(Console.ReadLine());
                Console.Write("введите длину четвертой стороны четырехугольника:");
                int t7 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"периметр четырехугольника: {t4 + t5 + t6 + t7}");
            }
            else if (f == "круг")
            {
                Console.Write("введите радиус круга: ");
                int t8 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"периметр круга: {2 * 3.14 * t8}");
            }
            else
            {
                Console.WriteLine("вы ошиблись в написании слова");
            }
        }
        else if (l == "площадь")
        {
            if (f == "треугольник")
            {
                Console.Write("введите высоту треугольника:");
                int t9 = Convert.ToInt32(Console.ReadLine());
                Console.Write("введите длину стороны треугольника:");
                int t10 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"площадь треугольника: {0.5 * t9 * t10}");
            }
            else if (f == "четырехугольник")
            {
                Console.Write("введите длину стороны четырехугольника:");
                int t11 = Convert.ToInt32(Console.ReadLine());
                Console.Write("введите высоту четырехугольника:");
                int t12 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"площадь четырехугольника: {t11 * t12}");
            }
            else if (f == "круг")
            {
                Console.Write("введите радиус круга: ");
                int t13 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"площадь круга: {3.14 * t13 * t13}");
            }
            else
            {
                Console.WriteLine("вы ошиблись в написании слова");
            }
        }
        else
        {
            Console.WriteLine("вы ошиблись в написании слова");
        }

        Console.WriteLine("\ntask 13");
        int num;
        Console.Write("Введите число: ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Вы ввели число: " + num);

        Console.WriteLine("\ntask 14");
        Console.WriteLine("2 кг\n13 17");

        Console.WriteLine("\ntask 15");
        Random random = new Random();
        int m, m1, m2, m3;
        m = random.Next(100);
        m1 = random.Next(100);
        m2 = random.Next(100);
        m3 = random.Next(100);
        Console.WriteLine($"{m}\n{m1}\n{m2}\n{m3}");

        Console.WriteLine("\ntask 16");
        int a1, b1, c1, xx, d;
        double xx1, xx2;
        Console.Write("enter a: ");
        a1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter b: ");
        b1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter c: ");
        c1 = Convert.ToInt32(Console.ReadLine());
        d = (b1 * b1) - (4 * c1 * a1);
        if (d < 0)
        {
            Console.WriteLine("no roots:(");
        }
        else
        {
            if (d > 0)
            {
                xx1 = (-b1 + (Math.Sqrt(d))) / (2 * a1);
                xx2 = (-b1 - (Math.Sqrt(d))) / (2 * a1);
                Console.WriteLine($"roots:{xx1},{xx2}");
            }
            else
            {
                xx = -b1 / 2 * a1;
                Console.WriteLine($"the only root: {xx}");
            }
        }

        Console.WriteLine("\ntask 17");
        int q = 1234, w = 5678;
        double e;
        e = q * w;
        Console.WriteLine($"среднее арифметическое {(q + w) / 2}");
        Console.WriteLine($"среднее геометрическое {Math.Sqrt(e)}");

        Console.WriteLine("\ntask 18");
        int x1 = 2, x2 = 6, y1 = 2, y2 = 5;
        double r;
        r = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
        Console.WriteLine(Math.Sqrt(r));


        Console.WriteLine("\ntask 19.a");
        int a2 = 333, b2 = 22, c2 = 1;
        b2 = c2;
        a2 = b2;
        c2 = a2;
        Console.WriteLine($"answer: {a2},{b2},{c2}");
        Console.WriteLine("\ntask 19.b");
        int a3 = 333, b3 = 22, c3 = 1;
        b3 = a3;
        c3 = b3;
        a3 = c3;
        Console.WriteLine($"answer: {a3},{b3},{c3}");

        Console.WriteLine("\ntask 20");
        int nn;
        Console.Write("введите количество секунд:");
        nn = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("полных часов:" + nn / 60 / 60);
        Console.WriteLine("полных минут с очередного часа:" + nn % (60 * 60) / 60);
        Console.WriteLine("полных секунд с очередной минуты:" + nn % 60);

        Console.WriteLine("\ntask 21");
        Console.WriteLine($"количество квадратов: {(130 * 543) / (130 * 130)}");

        Console.WriteLine("\ntask 22");
        int t;
        Console.Write("введите трехзначное число: ");
        t = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"полученное число: {t % 10}{t / 10}");

        Console.WriteLine("\ntask 23");
        int nn1;
        Console.Write("enter the number >999: ");
        nn1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"the number of hundreds: {nn1 / 100}");
        Console.WriteLine($"the number of thousands: {nn1 / 1000}");

        Console.WriteLine("\ntask 24");
        Console.Write("enter a four-digit number: ");
        int ch;
        ch = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"a) {ch % 10}{ch / 10 % 10}{ch / 100 % 10}{ch / 1000}");
        Console.WriteLine($"b) {ch / 100 % 10}{ch / 1000}{ch % 10}{ch / 10 % 10}");
        Console.WriteLine($"c) {ch / 1000}{ch / 10 % 10}{ch / 100 % 10}{ch % 10}");
        Console.WriteLine($"d) {ch / 10 % 10}{ch % 10}{ch / 1000}{ch / 100 % 10}");

        Console.WriteLine("\ntask 25");
        Console.Write("enter number 100<=n<=999: ");
        int o, p;
        o = Convert.ToInt32(Console.ReadLine());
        if (o >= 100)
        {
            if (o <= 999)
            {
                p = (o - o % 10) / 10;
                Console.WriteLine($"number x: {o % 10}{p}");
            }
            else
            {
                Console.WriteLine("wrong number");
            }
        }

        Console.WriteLine("\ntask 26");

        Console.WriteLine("\ntask 27");
        Console.Write("Введите угол (в радианах, от 0 до 2π): ");
        double yy = Convert.ToDouble(Console.ReadLine());
        if (yy < 0 || yy > 2 * 3.14)
        {
            Console.WriteLine("Угол должен быть в диапазоне от 0 до 2π радиан.");
            return;
        }
        double hh = yy / (2 * 3.14 / 12); // Перевод радиан в час
        double rg = yy * (180 / 3.14); // Радианы в градусы
        double mm = (rg % 30) * (60.0 / 30); // Остаток времени до следующего часа
        double am = mm * 6; // Каждая минута - 6 градусов
        Console.WriteLine($"Количество полных часов: {hh}");
        Console.WriteLine($"Количество полных минут: {mm}");
        Console.WriteLine($"Угол для минутной стрелки: {am} градусов");

        Console.WriteLine("\ntask 28");
        int numb1, numb2, numb3;
        Console.Write("enter first number: ");
        numb1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        Console.Write("enter first number: ");
        numb2 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        Console.Write("enter first number: ");
        numb3 = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        if (numb1 <= numb2 && numb1 <= numb3)
        {
            Console.WriteLine(numb1);
        }
        else
        {
            if (numb2 <= numb3 && numb2 <= numb1)
            {
                Console.WriteLine(numb2);
            }
            else
            {
                Console.WriteLine(numb3);
            }
        }

        Console.WriteLine("\ntask 29");
        int numb11, numb22, numb33;
        Console.Write("enter first number: ");
        numb11 = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter first number: ");
        numb22 = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter first number: ");
        numb33 = Convert.ToInt32(Console.ReadLine());
        if (numb11 <= numb22 && numb22 <= numb33)
        {
            Console.WriteLine(numb11 + numb33);
        }
        else
        {
            if (numb22 <= numb33 && numb33 <= numb11)
            {
                Console.WriteLine(numb22 + numb11);
            }
            else
            {
                Console.WriteLine(numb33 + numb22);
            }
        }

        Console.WriteLine("\ntask 30");

        Console.WriteLine("\ntask 31");

        Console.WriteLine("\ntask 32");

        Console.WriteLine("\ntask 33");
        Console.WriteLine("напишите кто вы? студент/пенсионер/другое: ");
        string v = Console.ReadLine();
        Console.WriteLine("вы трудоустроены? да/нет: ");
        string u = Console.ReadLine();

        if (u == "нет" && (v == "студент" || v == "пенсионер"))
        {
            Console.WriteLine("Кредит выдается.");
        }
        else
        {
            Console.WriteLine("Кредит не выдается.");
        }

        Console.WriteLine("\ntask 34");
        Console.Write("enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"you name: {name}");
        Console.WriteLine($"Hello, {name}!");

        Console.WriteLine("\ntask 35");
        Console.WriteLine("Привет");
        Console.Write("Как вас зовут? ");
        string name1 = Console.ReadLine();
        Console.WriteLine($"Привет, {name1}!");
        Console.WriteLine($"{name1}: Знаете что-нибудь о тайной комнате?");
        Console.WriteLine("Да");
        Console.WriteLine($"{name1}: Можете рассказать?");
        Console.WriteLine("Нет");
        Thread.Sleep(5000);
        Console.WriteLine("Но могу показать.");
        Console.ForegroundColor = (ConsoleColor)new Random().Next(1, 16);
        Console.WriteLine("Это таинственная комната!");
        Console.ResetColor();

        Console.WriteLine("\ntask 36");
    }
}