Console.Write("Введите числовое значение: ");
int num = Convert.ToInt32(Console.ReadLine());
int num0 = 0 - num;
while (num0 <= num)
{
    Console.Write(num0);
    Console.Write(" ");
    num0++;
}