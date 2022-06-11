// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int prompt(string message)
{
    Console.Write(message);  
    string NumberStr = Console.ReadLine();
    int N = int.Parse(NumberStr);
    return N;
}
int N = prompt("Введите число: ");

if (N < 100)  
{
    System.Console.WriteLine($"{N} -> третьей цифры нет");
}
else 
{
    int result = N % 10;
    System.Console.WriteLine($"{N} -> {result}");
}