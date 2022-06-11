// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int prompt(string message)
{
    Console.Write(message);  
    string NumberStr = Console.ReadLine();
    int number = int.Parse(NumberStr);
    return number;
}
int number = prompt("Введите трехзначное число: ");
int result = number % 100 / 10;

if ((number > 99) && (number < 1000))
{
    System.Console.WriteLine($"{number} -> {result}");
}
else 
{
    System.Console.WriteLine("Вы ввели не правильное число");
}