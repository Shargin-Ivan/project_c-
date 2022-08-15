Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int cnt = 1;
while (cnt <= num)
{
    Console.Write($"{Math.Pow(cnt, 3)} ");
    cnt++;
}