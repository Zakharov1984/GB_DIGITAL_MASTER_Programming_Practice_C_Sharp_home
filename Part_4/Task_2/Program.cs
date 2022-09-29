int GetSumDigits(int number) {
    int totalValue = 0;

    while (number > 0) {
        totalValue += number % 10;
        number /= 10;
    }

    Console.WriteLine(totalValue);
    return totalValue;
}

GetSumDigits(555); // => 15
GetSumDigits(123); // => 6
GetSumDigits(123456789); // => 45