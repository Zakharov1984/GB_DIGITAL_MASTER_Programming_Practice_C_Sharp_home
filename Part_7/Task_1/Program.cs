Console.Clear();
Console.Write("ПОжалуйста, введите число строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("ПОжалуйста, введите число столбцов: ");
int columns = int.Parse(Console.ReadLine());

GetDimensionalArrayOfRealNumbers(rows, columns);






double [,] GetDimensionalArrayOfRealNumbers (int rows, int columns) {
    double[,] newDimensionalArray = new double[rows,columns];
    Random randomObj = new Random();
    for (int i = 0; i < newDimensionalArray.GetLength(0); i++) {
        for (int j = 0; j < newDimensionalArray.GetLength(1); j++) {
            newDimensionalArray[i,j] = Math.Round(randomObj.Next(-99, 99 + 1) + randomObj.NextDouble(), 1);
        }    
    }
    multidimensionalArrayPrint(newDimensionalArray);
    return newDimensionalArray;
} 






void multidimensionalArrayPrint(double[,] array) {
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