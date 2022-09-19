Console.Clear();
Console.Write("Пожалуйста, введите число: ");
int numberValue = Convert.ToInt32( Console.ReadLine() );

if (numberValue % 2 == 0) {
    Console.Write("Введенное число является четным!");
}else {
    Console.Write("Введенное число является нечетным!");
}