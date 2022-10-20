Console.Clear();
Console.Write("Введите начальоне число: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное число: ");
int finishNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetSumNaturalsNumbersInInterim(startNumber, finishNumber));

int GetSumNaturalsNumbersInInterim(int m, int n) {
    if (m == n) return m;
    else return n + GetSumNaturalsNumbersInInterim(m, n - 1);
}


