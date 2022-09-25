Console.Clear();
Console.Write("Пожалуйста, введите число: ");
int numberFromUser = Convert.ToInt32( Console.ReadLine() );
string rowOfCubesOfNumbers = "";

for (int i = 1; i <= numberFromUser; i++) {

    if (i == numberFromUser) {
        rowOfCubesOfNumbers += i * i * i;
        break;
    }

    rowOfCubesOfNumbers += i * i * i + ", ";
}

Console.WriteLine($"Таблица кубов чисел от 1 до {numberFromUser}:  {rowOfCubesOfNumbers}");

