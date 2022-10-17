int [,] newMultidimensionalArray1 = GetDimensionalArrayNumbers(3,3);
int [,] newMultidimensionalArray2 = GetDimensionalArrayNumbers(3,3);
multiplicationMatrix(newMultidimensionalArray1, newMultidimensionalArray2);

void multiplicationMatrix(int[,] array1, int[,] array2) {
    if (array1.GetLength(1) != array2.GetLength(0)) {
        Console.WriteLine("Это не возможно") ;
        return;
    }

    int[,] totalMAtrix = new int[array1.GetLength(0), array2.GetLength(1)];
    int totalSumOnePosition = 0;

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(1); k++)
            {
                totalSumOnePosition += array1[i,k] * array2[k,j];
            }

            totalMAtrix[i,j] = totalSumOnePosition;
            totalSumOnePosition = 0;
        }  
    }

    

    multidimensionalArrayPrint(totalMAtrix);
}

int [,] GetDimensionalArrayNumbers (int rows, int columns) {
    int[,] newDimensionalArray = new int[rows,columns];
    Random randomObj = new Random();
    for (int i = 0; i < newDimensionalArray.GetLength(0); i++) {
        for (int j = 0; j < newDimensionalArray.GetLength(1); j++) {
            newDimensionalArray[i,j] = randomObj.Next(1, 5 + 1);
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





/* 

 for (int k = 0; k < array1.GetLength(0) * array2.GetLength(1); k++) {
        for (int i = 0; i < array2.GetLength(0); i++){
            int totalMultiplicationOneElement = 0;
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                totalMultiplicationOneElement += array1[i,j] * array2[j,i];
            }
            totalMAtrix[i, totalMatrixPositionColumns] = totalMultiplicationOneElement;
            totalMatrixPositionColumns++;

        }
    }


 */