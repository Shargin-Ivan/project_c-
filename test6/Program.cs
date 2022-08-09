Console.Clear();

int num = new Random().Next(100, 1000);

int a = num / 100;
int b = (num - a * 100) / 10;
int c = num % 10;



Console.WriteLine($"Число: {num}. Первая цифра: {a}. Вторая цифра: {b}. Третья цифра: {c}.");
Console.WriteLine($"{a}{c}");