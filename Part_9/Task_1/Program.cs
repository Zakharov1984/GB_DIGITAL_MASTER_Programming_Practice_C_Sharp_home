Console.Clear();
Console.Write("Введите число: ");
int finishNumber = Convert.ToInt32(Console.ReadLine());
string totalString = "";

void printNaturalsNumbers(int num) {
    if (num != 0){
        totalString += num + " ";
        printNaturalsNumbers(num - 1);
    }
    else Console.WriteLine(totalString);
}

printNaturalsNumbers(finishNumber);