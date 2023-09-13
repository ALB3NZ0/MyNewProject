//сложение
double plus(double a, double b)
{
    return a + b;
}

//вычесть
double minus(double a, double b)
{
    return a - b;
}

//перемножение
double multiply(double a, double b)
{
    return a * b;
}

//деление
double divine(double a, double b)
{
    return a / b;
}

//возведение
double power(double a, double n)
{
    return Math.Pow(a, n);
}

//квадратный корень
double sqrt(double a)
{
    return Math.Sqrt(a);
}

//1 процент от числа
double procent(double a)
{
    return (a / 100);
}

//факториал
double factorial(double a)
{
    double fact = 1;
    for (int i = 1; i < a + 1; i++)
        fact *= i;
    return fact;
}

do
{
    //создание локальных переменных
    double result = 0;
    double a, b;


    //операции
    Console.WriteLine("1) Сложить два числа");
    Console.WriteLine("2) Вычесть первое из второго");
    Console.WriteLine("3) Перемножить два числа");
    Console.WriteLine("4) Разделить первое на второе");
    Console.WriteLine("5) Возвести в степень N первое число");
    Console.WriteLine("6) Найти квадратный корень из числа");
    Console.WriteLine("7) Найти 1 процент от числа");
    Console.WriteLine("8) Найти факториал из числа");
    Console.WriteLine("9) Выйти из программы");

    //ввод номера операции
    Console.Write("Введите номер операции: ");
    string? choice = Console.ReadLine();

    //выход из программы
    if (choice == "9")
        break;

    //ввод переменных a и b
    do
    {
        try
        {
            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());
            break;
        }
        catch
        {
            Console.WriteLine("Ошибка: неккоректное число");
            Console.WriteLine("");
        }
    }
    while (true);

    //операции

    //сложение
    if (choice == "1")
        result = plus(a, b);

    //вычитание
    else if (choice == "2")
        result = minus(a, b);

    //умножение
    else if (choice == "3")
        result = multiply(a, b);

    //деление
    else if (choice == "4")
    {
        if (b != 0)
            result = divine(a, b);
        else
        {
            Console.WriteLine("Ошибка, на ноль делить нельзя");
            Console.WriteLine("");
            continue;
        }
    }

    //возведение в степень
    else if (choice == "5")
        result = power(a, b);

    //квадратный корень
    else if (choice == "6")
        result = sqrt(a);

    //1 процент от числа
    else if (choice == "7")
        result = procent(a);

    //факториал
    else if (choice == "8")
    {
        int a_f = Convert.ToInt32(a);
        if (a >= 0)
            result = factorial(a);
        else
        {
            Console.WriteLine("Ошибка: вы ввели неположительное число в вычислении факториала");
            Console.WriteLine("");
            continue;
        }
    }

    //обработчик неправильного ввода операции
    else
    {
        Console.WriteLine("Ошибка: вы ввели неккоректный номер операции");
        Console.WriteLine("");
        continue;
    }

    //вывод результата
    Console.WriteLine($"Результат: {result}");
    Console.WriteLine("");
}
while (true);
Console.WriteLine("Программа завершена");