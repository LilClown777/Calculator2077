// See https://aka.ms/new-console-template for more information
int a = 0;
int b = 0;
int c = 0;
bool proverka = true;

do
{
    Console.WriteLine("Меню калькулятора: ");
    Console.WriteLine("1. Сложить 2 числа\n2. Вычесть первое из второго\n3. Перемножить два числа\n4. Разделить первое на второе\n5. Возвести первое числов в степень N\n6. Найти квадратный корень из числа\n7. Найти 1 процент от числа\n8. Найти факториал из числа\n9. Выйти из программы ");
    Console.WriteLine("Введите номер функции и получите предварительное решение: ");
    c = Convert.ToInt32(Console.ReadLine());


    if (c == 1)
    {
        Console.WriteLine("Введите первое число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат сложения: " + (a + b));
    }

    else if (c == 2)
    {
        Console.WriteLine("Введите первое число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат вычитания: " + (b - a));
    }

    else if (c == 3)
    {
        Console.WriteLine("Введите первое число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат умножения: " + (a * b));
    }

    else if (c == 4)
    {
        Console.WriteLine("Введите первое число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат деления: " + (a / b));
    }

    else if (c == 5)
    {
        Console.WriteLine("Введите первое число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень числа: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат возведения в степень: " + (Math.Pow(a, b)));
    }

    else if (c == 6)
    {
        Console.WriteLine("Введите число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат квадратного корня: " + (Math.Sqrt(a)));
    }

    else if (c == 7)
    {
        Console.WriteLine("Введите число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат: " + (a / 100));
    }

    else if (c == 8)
    {
        Console.WriteLine("Введите число: ");
        a = Convert.ToInt32(Console.ReadLine());
        int a1 = 0;
        int b1 = 1;
        while (b1 < a)
        {
            a1++;
            b1 = b1 * a1;

        }

        Console.WriteLine("Результат: " + a1);
    }

    else if (c == 9)
    {
        Console.WriteLine("Спасибо за использование");
        proverka = false;
    }

    else
    {
        Console.WriteLine("Такой команды нету, попробуй ещё раз, ввести операцию ");
    }
}
while (proverka);