void printArray(int[] array) {
    string totalStringOfelementsOfarray = "[ ";
    for (int i = 0; i < array.Length -1 ; i++){
        totalStringOfelementsOfarray += $"{array[i]}, ";
    }

    totalStringOfelementsOfarray += $"{array[array.Length - 1]} ]";

    Console.WriteLine($"Массив из {array.Length}: {totalStringOfelementsOfarray}");
}

void sumOfOddElements(int[] array) {
    int totalValue = 0;

    for (int i = 1; i < array.Length; i++) {
        totalValue += i % 2 == 1 ? array[i] : 0;
    }

    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {totalValue}");
}


int[] newArray(int amountOfElements) {
    int[] newArray = new int[amountOfElements];
    for (int i = 0; i < amountOfElements; i++) {
        newArray[i] = new Random().Next(-99, 99 + 1);
    }
    Console.Clear();
    printArray(newArray); 
    sumOfOddElements(newArray);
    return newArray;
}




newArray(10);
