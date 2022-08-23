int Exponentiation(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
    return result;
}

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите в какую степень нужно возвести число: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = Exponentiation(A, B);
Console.Write($"Число {A} в степени {B} равно {result}");