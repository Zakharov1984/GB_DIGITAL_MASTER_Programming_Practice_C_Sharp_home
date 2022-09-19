Console.Clear();
Console.Write("Пожалуйста, введите первое число для сравнения: ");
int number1 = Convert.ToInt32( Console.ReadLine() );
Console.Write("Пожалуйста, введите второе число для сравнения: ");
int number2 = Convert.ToInt32( Console.ReadLine() );
Console.Write("Пожалуйста, введите третье число для сравнения: ");
int number3 = Convert.ToInt32( Console.ReadLine() );
int[] array1 = {number1, number2, number3};
int maxValue = array1[0];

for (int i = 1; i <= 2; i++) {
    if (maxValue < array1[i]) {
        maxValue = array1[i];
    }
}

Console.WriteLine($"Наибольшее число из трех введенных - {maxValue}");

/* 
or
int maxValue = number1;

if (maxValue < number2) {
    maxValue = number2;
}

if (maxValue < number3) {
    maxValue = number3;
}
Console.WriteLine($"Наибольшее число из трех введенных - {maxValue}");
 */