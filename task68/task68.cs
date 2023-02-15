Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

int Afunction(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Afunction(n - 1, 1);
    if (n > 0 && m > 0) return Afunction(n - 1, Afunction(n, m - 1));
    return Afunction(n,m);
}
Console.WriteLine(Afunction(n,m));