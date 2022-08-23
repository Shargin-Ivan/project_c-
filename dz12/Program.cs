int TheSumOfTheDigitsInANumber(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = TheSumOfTheDigitsInANumber(num);
Console.Write($"Сумма цифр в числе {num} равно {result}");