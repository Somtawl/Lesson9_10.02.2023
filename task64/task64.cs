Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

PrintNums(num);

void PrintNums(int n)
{
    if (n > 0)
    {
        Console.Write(n + " ");
        n--;
        PrintNums(n);
    }
}