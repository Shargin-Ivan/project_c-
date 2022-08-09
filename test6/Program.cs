Console.Clear();

int num = new Random().Next(100, 1000);

int a = num / 100;
int b = num / 10;
int c = num % 10;



Console.WriteLine(num);
Console.WriteLine($"{a}{c}");