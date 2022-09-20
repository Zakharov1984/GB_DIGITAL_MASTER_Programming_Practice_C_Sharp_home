void SecondDigitOf(int number) {
    Console.WriteLine( ( (number % 100) - (number % 10) )  / 10 );
}

Console.Write("ПОжалуйста, введите трехзначное число: ");
int number = Convert.ToInt32( Console.ReadLine() );
SecondDigitOf(number);
