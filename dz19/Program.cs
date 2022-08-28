Console.Clear();

double[,] arr(int m, int n, int x, int y)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(new Random().Next(x, y + 1) - new Random().NextDouble(), 2);
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
}

int m = new Random().Next(0, 10);
int n = new Random().Next(0, 10);

Console.WriteLine($"m = {m}");
Console.WriteLine($"n = {n}");

double[,] array = arr(m, n, -9, 9);

PrintArray(array);