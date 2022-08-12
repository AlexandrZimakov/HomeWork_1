Console.Write("Введите число и узнаем,является выходным или нет:");
int day = Convert.ToInt32(Console.ReadLine());
int dayOff = 6;
int dayOff1 = 7;
if (dayOff <= day && day <= dayOff1) {
    Console.Write("Выходной");
} else {
    Console.Write("Рабочий день");
}