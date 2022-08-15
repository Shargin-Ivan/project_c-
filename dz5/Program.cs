Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = (num - (num / 100) * 100) / 10;
Console.WriteLine($"Вторая цифра: {result}");