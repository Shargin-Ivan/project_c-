Console.Clear();

int[] arr(int num, int x, int y)
{
   int[] array = new int[num];
   for(int i = 0; i < num; i++)
   {
      array[i] = new Random().Next(x, y + 1);
   }
   return array;
}
int SumOfOddPositions(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((i % 2) != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

int[] array = arr(10, -100, 100);
int sum = SumOfOddPositions(array);

Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");