Console.Write("Введите число m ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int sum = 0;
if (numM >= numN) Console.WriteLine("число m не может быть больше или равным числу n");
else 
{
    Console.Write("Сумма чисел от {0} до {1} = ",numM,numN);
    Console.WriteLine(getSum(numM,numN));
}

int getSum(int m, int n)
{
    if (m <= n)
    {
        sum = sum + m;
        m++;
        getSum(m,n);
    }
    return sum;
}