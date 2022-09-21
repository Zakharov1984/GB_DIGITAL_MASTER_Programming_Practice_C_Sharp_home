Console.Clear();
Console.Write("Пожалуйста, введите значение: ");
int dayNumber = Convert.ToInt32( Console.ReadLine() );

while (dayNumber < 1 || dayNumber > 7) {
    Console.Clear();
    Console.WriteLine("Пожалуйста введите актуальоне занчение, на этой планете семь дней в неделе:)");
    Console.Write("Пожалуйста, введите значение: ");
    dayNumber = Convert.ToInt32( Console.ReadLine() );
}

if (dayNumber == 6 || dayNumber == 7) {
    Console.WriteLine("ДА, сегодня выходной день");
}else {
    Console.WriteLine("Сегодня рабочий день.");
}