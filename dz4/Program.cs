Console.Write("До какого числа вывести чётные от 1? До: ");
int num = Convert.ToInt32(Console.ReadLine());
int cnt = 2;
while (cnt <= num)
{
    Console.Write($"{cnt} ");
    cnt = cnt + 2;
}