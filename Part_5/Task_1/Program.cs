void printArray(int[] array) {
    string totalStringOfelementsOfarray = "[ ";
    for (int i = 0; i < array.Length -1 ; i++){
        totalStringOfelementsOfarray += $"{array[i]}, ";
    }

    totalStringOfelementsOfarray += $"{array[array.Length - 1]} ]";

    Console.WriteLine($"Массив из {array.Length}: {totalStringOfelementsOfarray}");
}

void NumberOfEven(int[] array) {
    int counter = 0;
    foreach (int item in array) {
        if (item % 2 == 0) {
            counter++;
        }
    }

    Console.WriteLine($"Количество четных чисел в массиве: {counter}");
}


int[] newArray(int amountOfElements) {
    int[] newArray = new int[amountOfElements];
    for (int i = 0; i < amountOfElements; i++) {
        newArray[i] = new Random().Next(100, 999 + 1);
    }
    Console.Clear();
    printArray(newArray); 
    NumberOfEven(newArray);
    return newArray;
}




newArray(10);
