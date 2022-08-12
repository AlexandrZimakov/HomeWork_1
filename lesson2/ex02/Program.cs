Console.Write("Введите число:");
string userInput = Console.ReadLine();
if (userInput.Length < 3) {
    Console.Write("третьей цифры нет");
}
else {
    Console.Write(userInput[2]);
}