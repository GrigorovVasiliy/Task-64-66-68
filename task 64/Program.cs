Console.Clear();

Console.Write("Введите число начало: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число конец: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(Number(n, m));

int Number(int n, int m)
{
    if (n == m)
        return n;
    else if (n < m)
        Console.Write($"{Number(n, m - 1)}, ");
    else
        Console.Write($"{Number(n, m + 1)}, ");
    return m;
}