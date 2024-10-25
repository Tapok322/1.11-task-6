using System.Threading.Tasks;

Console.WriteLine("Введите a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите количество разбиений интеграла на прямоугольники (n): ");
int n = Convert.ToInt32(Console.ReadLine());
double h = (b - a) / n;

StreamWriter sw = new StreamWriter("C:\\Users\\prdb\\source\\repos\\Task_6\\task_6.txt");

if (b < a)
{
    Console.WriteLine("Ошибка заданных значений. a должно быть меньше b.");
    return;
}

//static double func(double x)
//{
//    x = 2 * Math.Pow(x, 2) + 3 * x;
//    return x;
//}
static double integral(double a, double h, int n, double integral_sum)
{
    for (int i = 0; i <= n; i++)
    {
        integral_sum += a + i * (h / 2);
    }
    return integral_sum * h;
}
double integral_returned = integral(a, h, n, 0);
//double given_integral = func(x);
sw.WriteLine($"Интеграл при значениях a = {a} и b = {b} и n = {n} равен: {integral_returned:F3}");
Console.WriteLine($"Интеграл при значениях a = {a} и b = {b} и n = {n} равен: {integral_returned:F3}");
//sw.WriteLine($"Заданный интеграл равен: {given_integral:F3}");
//Console.WriteLine($"Заданный интеграл равен: {given_integral:F3}");
sw.Close();