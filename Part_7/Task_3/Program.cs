
AverageColumns(GetDimensionalArrayOfNumbers(3, 3));


void AverageColumns(int[,] array) {
    string totalString = "Среднее арифметическое каждого столбца: ";
    for (int i = 0; i < array.GetLength(1); i++) {
        double averageOneColumns = 0;
        for (int j = 0; j < array.GetLength(0); j++) {
            averageOneColumns += array[j, i];
        }
        totalString += $"{Math.Round(averageOneColumns / array.GetLength(0), 1)}; ";  
    }

    Console.WriteLine(totalString);
}


int [,] GetDimensionalArrayOfNumbers (int rows, int columns) {
    int[,] newDimensionalArray = new int[rows,columns];
    Random randomObj = new Random();
    for (int i = 0; i < newDimensionalArray.GetLength(0); i++) {
        for (int j = 0; j < newDimensionalArray.GetLength(1); j++) {
            newDimensionalArray[i,j] = randomObj.Next(1, 9 + 1);
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
