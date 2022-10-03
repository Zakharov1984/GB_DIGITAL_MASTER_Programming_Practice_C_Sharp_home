void printArray(double[] array) {
    string totalStringOfelementsOfarray = "[ ";
    for (int i = 0; i < array.Length -1 ; i++){
        totalStringOfelementsOfarray += $"{array[i]}, ";
    }

    totalStringOfelementsOfarray += $"{array[array.Length - 1]} ]";

    Console.WriteLine($"Массив из {array.Length}: {totalStringOfelementsOfarray}");
}




void DifferenceMaxMinElements(double[] array) {
    double  minValue = array[0],
            maxValue = array[0];

    for (int i = 1; i < array.Length; i++) {
        if (minValue > array[i]) minValue = array[i];
        if (maxValue < array[i]) maxValue = array[i];
    }

    Console.Clear();
    printArray(array);
    Console.WriteLine($"Разница между минимальным значением {minValue} и масимальным значением {maxValue} = {Math.Round(maxValue - minValue, 1)}");
} 


double[] newArray(int amountOfElements) {
    double[] newArray = new double[amountOfElements];
    Random randomObj = new Random();
    for (int i = 0; i < amountOfElements; i++) {
        newArray[i] = Math.Round(randomObj.Next(-99, 99 + 1) + randomObj.NextDouble(), 1)  ;
    } 
    return newArray;
}





DifferenceMaxMinElements( newArray(10) );
