Console.Clear();
Console.Write("ПОжалуйста, введите число: ");
int number = Convert.ToInt32( Console.ReadLine() );

while (number < 100) {
    Console.WriteLine("ПОжалуйста, введите значение, которое больше или равно 100, в этом числе нет третьей цифры!");
    Console.Write("ПОжалуйста, введите число: ");
    number = Convert.ToInt32( Console.ReadLine() );
}

Console.WriteLine( (number / 100) % 10 );

