int[] GetCubes(int number){
  int [] cubes = new int[number];
  for (int i = 0; i < cubes.Length; i++) {
    cubes [i] = Convert.ToInt32(Math.Pow(i + 1, 3));
  }
  return cubes;
}

void PrintArry(int[] array){
  foreach(int x in array)
    Console.Write($"{x} ");
} 

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] cubes = GetCubes(number);
PrintArry(cubes);
