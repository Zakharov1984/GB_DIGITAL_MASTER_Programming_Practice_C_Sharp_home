int[,] newArray = new int[,] {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
arrangeItems(newArray);

void arrangeItems(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1) - 1; j++){
            for (int k = 0 ; k < array.GetLength(1) - 1 - j; k++) {
                if (array[i,k] < array[i,k + 1]) {
                    int temp = array[i,k];
                    array[i,k] = array[i,k + 1];
                    array[i,k + 1] = temp; 
                }
            }
        }
    }
    multidimensionalArrayPrint(array);
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