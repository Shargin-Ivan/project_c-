Console.Clear();

Console.Write("Введите переменную b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
double x = (b1 - b2) / (k2 - k1);
double y = k1 * ((b1 - b2) / (k2 - k1)) + b1;
Console.WriteLine($"[{x}, {y}]");

// Можно было написать условия, когда прямые не существуют или ещё что-нибудь, 
// но в задаче предполагается, что у нас уже есть прямые, точку пересечения которых мы будем искать, 
// а это означает, что такие прямые существуют и у них точно есть точка пересечения