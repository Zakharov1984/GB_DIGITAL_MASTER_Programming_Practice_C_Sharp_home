int getNumberToDegree(int number, int degree) {
    int totalNumber = 1;
    while (degree > 0) {
        totalNumber *= number;
        degree--;
    }

    Console.WriteLine(totalNumber);
    return totalNumber;
}

getNumberToDegree(3, 3); // => 27
getNumberToDegree(5, 3); // =>  125
getNumberToDegree(5, 0); // => 1
