Console.Clear();
Console.Write("ПОжалуйста, введите позицию строки: ");
int PositionRows = int.Parse(Console.ReadLine()!);
Console.Write("ПОжалуйста, введите позицию столбца: ");
int PositionColumns = int.Parse(Console.ReadLine()!);

searchElementsInArrayy(PositionRows, PositionColumns, GetDimensionalArrayOfNumbers(5, 5));


string searchElementsInArrayy(int PositionRows, int PositionColumns, int[,] array) {
    if (PositionRows > array.GetLength(0) || PositionColumns > array.GetLength(1)) {
        Console.WriteLine($"Такого элемента {PositionRows}.{PositionColumns} - нет.");
        return $"Такого элемента {PositionRows}.{PositionColumns} - нет.";
    } else {
        Console.WriteLine(Convert.ToString(array[PositionRows, PositionColumns]));
        return Convert.ToString(array[PositionRows, PositionColumns]);
    }
}



int [,] GetDimensionalArrayOfNumbers (int rows, int columns) {
    int[,] newDimensionalArray = new int[rows,columns];
    Random randomObj = new Random();
    for (int i = 0; i < newDimensionalArray.GetLength(0); i++) {
        for (int j = 0; j < newDimensionalArray.GetLength(1); j++) {
            newDimensionalArray[i,j] = randomObj.Next(10, 99 + 1);
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
