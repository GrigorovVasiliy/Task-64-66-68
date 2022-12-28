Console.Clear();

Console.Write("Введите число начало: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число конец: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел равна {Summa(n)}");
int Summa(int n)
{
    if (n == 0) return 0;
    else return n + Summa(n - 1);
}
