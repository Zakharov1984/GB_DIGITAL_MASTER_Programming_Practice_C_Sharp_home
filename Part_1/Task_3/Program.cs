Console.Clear();
Console.Write("Пожалуйста, введите число: ");
int numberValue = Convert.ToInt32( Console.ReadLine() );
string StringValue = "";

for (int i = 1; i <= numberValue; i++) {
    if (i % 2 == 0) {
        StringValue = StringValue + " " + i;
    }
}

Console.WriteLine(StringValue);