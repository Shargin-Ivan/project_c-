Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
{
    while (num > 999)
    {
        num /= 10;
    }
    Console.WriteLine($"Третья цифра числа: {num % 10}");
}
else
{
    Console.WriteLine("Третьей цифры нет.");
}