Console.Write("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = b;
if (max < min) {
    max = b;
    min = a;   
}

Console.WriteLine($"большее число: {max} меньшее число: {min} ");
