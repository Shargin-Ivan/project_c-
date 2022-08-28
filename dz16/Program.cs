Console.Clear();

double[] arr(int num, int x, int y)
{
   double[] array = new double[num];
   for(int i = 0; i < num; i++)
   {
      array[i] = Math.Round(new Random().Next(x, y + 1) - new Random().NextDouble(), 2);
   }
   return array;
}
double DifferenceMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    return  Math.Round(max - min, 2);
}

double[] array = arr(10, 0, 100);
double difference =  DifferenceMaxMin(array);

Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Разница между максимальным и минимальным: {difference}");