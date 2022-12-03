Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (a > b && a > c) max = a;

if (b > a && b > c) max = b;

if (c > a && c > b) max = c;
Console.Write("Максимальное число: ");
Console.WriteLine(max);