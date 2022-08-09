Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine($"Число {num1} кратно числу {num2}");
}
else
{
    Console.WriteLine($"Число {num1} не кратно числу {num2} и остаток равен {num1 % num2}");
}
