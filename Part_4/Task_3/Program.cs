int[] GetArrayOfNumbers(int numberOfElementsInArray) {
    int[] newArray = new int[numberOfElementsInArray];

    for (int i = 0; i < numberOfElementsInArray; i++) {
        newArray[i] = new Random().Next(0, 99 + 1);
    }

    printArray(newArray);
    return newArray;
}


void printArray(int[] array) {
    string totalStringOfelementsOfarray = "[ ";
    for (int i = 0; i < array.Length - 1; i++){
        totalStringOfelementsOfarray += $"{array[i]}, ";
    }

    totalStringOfelementsOfarray += $"{array[array.Length - 1]} ]";

    Console.WriteLine($"Массив из {array.Length}: {totalStringOfelementsOfarray}");
}

GetArrayOfNumbers(20);