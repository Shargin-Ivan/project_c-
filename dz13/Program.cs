int[] arr(int num, int x, int y)
{
   int[] array = new int[num];
   for(int i = 0; i < num; i++)
   {
      array[i] = new Random().Next(x, y + 1);
   }
   return array;
}
int[] array = arr(8, -9, 9);
Console.WriteLine(string.Join(", ", array));
// Можно было сделать вывод в методе, либо создать ещё один метод,
// но мне лень