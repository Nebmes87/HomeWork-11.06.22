// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

int prompt(string message)
{
    Console.Write(message);  
    string NumberStr = Console.ReadLine();
    int number = int.Parse(NumberStr);
    return number;
}
int number = prompt("Введите число соответствующее дню недели: ");
if (number == 6 || number == 7)
{
    System.Console.WriteLine($"{number} -> да");
}
else
{
    System.Console.WriteLine($"{number} -> нет");
}

// или

int promt(string message)
{
    Console.Write(message);  
    string NumberStr = Console.ReadLine();
    int N = int.Parse(NumberStr);
    return N;
}
int N = promt("Введите число соответствующее дню недели: ");
if (number < 1 || number > 7)
{
    System.Console.WriteLine("Вы ввели не правильное число, попробуйте еще раз");
}
if (N==1) System.Console.WriteLine($"{N} - нет, понедельник не является выходным");
if (N==2) System.Console.WriteLine($"{N} - нет, вторник не является выходным");
if (N==3) System.Console.WriteLine($"{N} - нет, среда не является выходным");
if (N==4) System.Console.WriteLine($"{N} - нет, четверг не является выходным");
if (N==5) System.Console.WriteLine($"{N} - нет, пятница не является выходным");
if (N==6) System.Console.WriteLine($"{N} - да, суббота является выходным");
if (N==7) System.Console.WriteLine($"{N} - да, воскресенье является выходным");