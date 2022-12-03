Console.Clear();
Console.Write("Введите число: ");

int year = Convert.ToInt32(Console.ReadLine());

if (year % 2 == 0)
    Console.WriteLine("четное");
else
    Console.WriteLine("нечетное");