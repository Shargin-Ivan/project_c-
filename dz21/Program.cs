Console.Clear();

int[,] arr(int x, int y)
{
    int m = new Random().Next(0, 10);
    int n = new Random().Next(0, 10);
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(x, y + 1);
        }
    }
    return array;
}
void PrintArrayInt(int[,] arrayInt)
{
    for (int i = 0; i < arrayInt.GetLength(0); i++)
    {
        for (int j = 0; j < arrayInt.GetLength(1); j++)
        {
            if (j != (arrayInt.GetLength(1) - 1))
            {
                Console.Write($"{arrayInt[i, j]}, ");
            }
            else
            {
                Console.Write($"{arrayInt[i, j]}");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
double[] Average(int[,] array)
{
    double[] average = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        average[i] = sum / array.GetLength(1);
    }
    return average;
}

int[,] array = arr(0, 9);
double[] average = Average(array);

PrintArrayInt(array);
Console.WriteLine(string.Join("; ", average));