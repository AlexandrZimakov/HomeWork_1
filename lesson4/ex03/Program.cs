void AllArray(int[] massiv){
    int index = 0;
    while (index < massiv.Length){
        massiv[index] = new Random().Next(0,10);
        index++;
    }
}

void ArrayWrite(int[] massiv){
    int index = 0;
    Console.Write("[ ");
    while (index < massiv.Length){
        Console.Write($"{massiv[index]}");
        index++;
        if(index < massiv.Length) {
            Console.Write(", ");
        }
    }
    Console.Write(" ]");
    Console.WriteLine();
}


int[] array = new int[8];

AllArray(array);
ArrayWrite(array);