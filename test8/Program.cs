Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int a = 7;
int b = 23;

if (((num % a) == 0) && ((num % b) == 0))
{
    Console.WriteLine($"Число {num} кратно одновременно {a} и {b}");
}
else
{
    Console.WriteLine($"Число {num} не кратно одновременно {a} и {b}");
}