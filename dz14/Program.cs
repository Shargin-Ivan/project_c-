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
int EvenNumberCounter(int[] arr)
{
    int cnt = 0;
    for (int i = 0; i < arr.Length;i++)
    {
        if (arr[i] % 2 == 0)
        {
            cnt++;
        }
    }
    return cnt;
}
int[] array = arr(10, 100,999);
int count = EvenNumberCounter(array);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Колличество чётных чисел: {count}");