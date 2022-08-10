Console.Write("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int value = 1;
while (value <= N){
    if(value % 2 == 0){
        Console.Write(value + " ");
    }
    value++;
}
Console.WriteLine();