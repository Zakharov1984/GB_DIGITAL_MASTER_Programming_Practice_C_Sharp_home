Console.Clear();

Console.WriteLine("ПОжалуйста, введитче набор чисел через пробел.");

string[] arrayValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

positiveNumberCounter(arrayValues);

void positiveNumberCounter(string[] array) {
    int counter = 0;
    for (int i = 0; i < array.Length; i++) {
        if (int.Parse(array[i]) > 0) counter++;
    }
    Console.WriteLine($"Положительных чисел: {counter}");
}


