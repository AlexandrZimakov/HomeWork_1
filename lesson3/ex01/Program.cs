bool isPolindrom(int number) {
    int[] array = new int[6];
    for (int i = 0; i < 6; i++){
        array[i] = number % 10;
        number = number / 10;
    }
    if (   array[0] == array[5] 
        && array[1] == array[4] 
        && array[2] == array[3]
        )
        return true;
        else return false;
}

Console.Write("Введите шестизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (isPolindrom(number)) {
    Console.WriteLine($"Ваше число - палиндром.");
}
else {
    Console.WriteLine($"Ваше число - НЕ палиндром.");
}
