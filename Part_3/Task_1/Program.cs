Console.Clear();
Console.Write("Пожалуйста, введите пятизначное значение: ");
int numberFromUser = Convert.ToInt32( Console.ReadLine() );
int changedValue = numberFromUser;
string reverseNumber = "";

while (numberFromUser >= 100000 || numberFromUser < 10000) {
    Console.Clear();
    Console.WriteLine("Пожалуйста введите корректное число.");
    Console.Write("Пожалуйста, введите пятизначное значение: ");
    numberFromUser = Convert.ToInt32( Console.ReadLine() );
    changedValue = numberFromUser;
}

for (int count = 0; count < 5; count++) { // or 0 < changedValue
    reverseNumber += changedValue % 10;
    changedValue /= 10;
}

if ( numberFromUser == int.Parse(reverseNumber) ) {
    Console.WriteLine($"число {numberFromUser} - является палиндромом");
}else {
    Console.WriteLine($"число {numberFromUser} - не является палиндромом");
}


