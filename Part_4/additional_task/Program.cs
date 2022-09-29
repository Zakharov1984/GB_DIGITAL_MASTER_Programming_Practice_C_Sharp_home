//Посчитать максимальную длинну вхождений указанного числа.

int[] getBinaryArray(int numberElementsInArray) {
    int[] newBinaryArray = new int[numberElementsInArray];
    for (int i = 0; i < numberElementsInArray; i++) {
        newBinaryArray[i] = new Random().Next(0, 1 + 1);
    }

    printArray(newBinaryArray);
    return newBinaryArray;
}


void printArray(int[] array) {
    string totalString = "[ ";
    for (int i = 0; i < array.Length - 1; i++) {
        totalString += $"{array[i]}, ";
    }

    totalString += $"{array[array.Length - 1]} ]";

    Console.WriteLine(totalString);
}


void maxLength(int[] array, int number) {
    int counter = 0;
    List<int> listForMaxLengths = new List<int>();
    for (int i = 0; i < array.Length; i++) {
        if (array[i] == number) {
            counter++;  
            for (int j = i + 1; j < array.Length; j++) {
                if (array[j] == number) {
                    counter++;
                } else {
                    listForMaxLengths.Add(counter);
                    counter = 0;
                    break;
                }
            }
        } 
    }

    int MaxLength = listForMaxLengths[0];
    for (int k = 1; k < listForMaxLengths.Count; k++) {
            if (MaxLength < listForMaxLengths[k]) {
                MaxLength = listForMaxLengths[k];
            }
    }

    Console.WriteLine(MaxLength);
}

maxLength(getBinaryArray(20), 1);
