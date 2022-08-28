Console.Clear();

int[] arr(int M)
{
    int[] array = new int[M];
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        Console.Write($"Введи, пожалуйста, число под номером {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Вы ввели все числа!");
    return array;
}
int Amount(int[] array)
{
    int cnt = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            cnt++;
        }
    }
    return cnt;
}

Console.Write("Введите сколько чисел будет использовано: ");
int M = Convert.ToInt32(Console.ReadLine());

int[] array = arr(M);
int count = Amount(array);

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Чисел больше 0: {count}");