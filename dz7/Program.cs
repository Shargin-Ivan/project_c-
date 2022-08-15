Console.Write("Введите порядковый номер дня недели(от 1 до 7): ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Теперь произойдёт магия и я отвечу является ли этот день выходным: ");
if ((num > 0) && (num < 8))
{
    if (num > 5)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("ОТ 1 ДО 7");
}