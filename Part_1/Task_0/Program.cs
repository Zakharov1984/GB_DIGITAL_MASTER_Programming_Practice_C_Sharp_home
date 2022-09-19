Console.Clear();
Console.Write("Пожалуйста, введите первое число для сравнения: ");
int number1 = Convert.ToInt32( Console.ReadLine() );
Console.Write("Пожалуйста, введите второе число для сравнения: ");
int number2 = Convert.ToInt32( Console.ReadLine() );

if (number1 < number2) {
    Console.WriteLine($"В этом случае число {number1} меньше, чем число {number2}");
}else {
    Console.WriteLine($"В этом случае число {number2} меньше, чем число {number1}");
}