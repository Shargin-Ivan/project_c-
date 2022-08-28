Console.Clear();

double[,] arr(int x, int y)
{
    int m = new Random().Next(0, 10);
    int n = new Random().Next(0, 10);
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
void PrintElement(double[,] array, int coord1, int coord2)
{
    if ((coord1 < array.GetLength(0) && coord1 > -1) && (coord2 < array.GetLength(1) && coord1 > -1))
    {
        Console.WriteLine(array[coord1, coord2]);
    }
    else
    {
        Console.WriteLine("Такого элемента не существует");
    }
}

double[,] array = arr(-9, 9);

PrintArray(array);

Console.Write("Какой эллемент вы бы хотели увидеть? ");
int coordinatesInt = Convert.ToInt32(Console.ReadLine());
int[] coordinatesArr = { coordinatesInt / 10, coordinatesInt % 10 };

PrintElement(array, coordinatesArr[0], coordinatesArr[1]);