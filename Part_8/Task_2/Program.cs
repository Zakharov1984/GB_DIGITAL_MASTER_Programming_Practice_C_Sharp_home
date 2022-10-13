int[,] newArray = GetDimensionalArrayOfRealNumbers(4, 2);
getLineWithSmallestSumOfElements(newArray);

void getLineWithSmallestSumOfElements(int[,] array) {
    int[] arrayTotalSumInLine = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++){
        int totalSumInLine = 0;
        for (int j = 0; j < array.GetLength(1); j++){
            totalSumInLine += array[i,j];
        }

        arrayTotalSumInLine[i] = totalSumInLine;
    }

    int lineWithMinSum = 1;
    int minElement = arrayTotalSumInLine[0];
    for (int i = 1; i < arrayTotalSumInLine.Length; i++){
        if (minElement > arrayTotalSumInLine[i]) {
            minElement = arrayTotalSumInLine[i];
            lineWithMinSum = i + 1;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов - {lineWithMinSum}");
}






int [,] GetDimensionalArrayOfRealNumbers (int rows, int columns) {
    int[,] newDimensionalArray = new int[rows,columns];
    Random randomObj = new Random();
    for (int i = 0; i < newDimensionalArray.GetLength(0); i++) {
        for (int j = 0; j < newDimensionalArray.GetLength(1); j++) {
            newDimensionalArray[i,j] = randomObj.Next(10, 30 + 1);
        }    
    }
    multidimensionalArrayPrint(newDimensionalArray);
    return newDimensionalArray;
} 

void multidimensionalArrayPrint(int[,] array) {
    string totalString = "[ \n";

    for (int i = 0; i < array.GetLength(0); i++) {
        totalString += "[ ";
        for (int j = 0; j < array.GetLength(1); j++) {
            totalString += array[i,j] + " ";
        }
        totalString += "],\n";
    }

    totalString += "]";

    Console.WriteLine(totalString);
}