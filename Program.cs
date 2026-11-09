a();
Console.WriteLine(Gcd(48, 18));
Console.WriteLine(Lcm(4, 6));
// Задания 1
PrintLine();
Console.WriteLine("Отчет");
PrintLine();

static void PrintLine()
{
    Console.WriteLine("^_^");
}
static void PrintHeader(string title)
{
    PrintLine();
    Console.WriteLine(title);
    PrintLine();
}
// Задания 2
static int Max(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}
// Задание 2.2
static bool IsEven(int n)
{
    return (n % 2 == 0);
}
// Задания 3
static double Average(int[] arr)
{
    int sum = 0;
    foreach (int i in arr)
    {
        sum += i;
    }
    return (Double)sum / arr.Length;
}
static int CountGreater(int[] arr, int limit)
{
    int c = 0;
    foreach (int ar in arr)
    {
        if (ar > limit)
        {
            c++;
        }
    }
    return c;
}
// Задание 4
    static double ToFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }
        double c1 = 0;
        double f1 = ToFahrenheit(c1);
        Console.WriteLine($"{c1} °C = {f1} °F");
        double c2 = 100;
        double f2 = ToFahrenheit(c2);
        Console.WriteLine($"{c2} °C = {f2} °F");
        double c3 = 37;
        double f3 = ToFahrenheit(c3);
        Console.WriteLine($"{c3} °C = {f3} °F");
    
// Задания 5
static long Factorial(int n)
{
    int f = 1;
    for (int i = 1; i <= n; i++)
    {
        f *= i;
    }
    return f;
}
static bool IsPrime(int n)
{
    int c = 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            c++;
        }
    }
    return (c == 2);
}
// Задание 6
static int ReadPositive(string message)
{
    int a;
    do
    {
        Console.Write(message);
        a = Convert.ToInt32(Console.ReadLine());
    }
    while (a <= 0);
    return a;
}
// Итоговая задача
static void a()
{
    static int sum(int n1, int n2)
{
    return n1 + n2;
}
    int z;
    do
    {
        Console.WriteLine("     ~МЕНЮ~ ");
        Console.WriteLine("1 - cумма из двух");
        Console.WriteLine("2 - большее из двух");
        Console.WriteLine("3 - факториал");
        Console.WriteLine("0 - выход");
        z = Convert.ToInt32(Console.ReadLine());
        switch (z)
        {
            case 0:
                break;
            case 1:
                Console.Write("Введите первое число: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Сумма: " + sum(num1, num2));
                break;
            case 2:
                Console.Write("Введите первое число: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Большее число: " + Max(n1, n2));
                break;
            case 3:
                int num = ReadPositive("Введите положительное число: ");
                Console.WriteLine($"Факториал числа {num}: " + Factorial(num));
                break;
            default:
                Console.WriteLine("Такой функции нет");
                break;
        }
    }
    while (z != 0);
}
// Дополнительное задание
static int Gcd(int a, int b)
{
    while (b != 0)
    {
        int b1 = b;
        b = a % b;
        a = b1;
    }
    return a;
}
static int Lcm(int a, int b)
{
    return a / Gcd(a, b) * b;
}