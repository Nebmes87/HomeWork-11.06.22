// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void thirdNumber(string number)
{
    if (number.Length < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        Console.WriteLine(number[2]);
    }
}

Console.Write("Введите цифру: ");
string UserStr = Console.ReadLine();
thirdNumber(UserStr);