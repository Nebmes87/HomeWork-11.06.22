// Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int numberA = new Random().Next(1, 10);
int numberB = new Random().Next(1, 10);
int numberC = new Random().Next(1, 10);
System.Console.WriteLine($"{numberA}{numberB}{numberC} -> {numberA}{numberC}");

//или

int number = new Random().Next(100, 1000);
int A = number / 100;
int B = number % 10;
System.Console.WriteLine($"{number} -> {A}{B}");

// или

int randomInt = new Random().Next(100,1000);
int result = (randomInt - randomInt%100)/10+(randomInt%10);
Console.WriteLine($"{randomInt} -> {result}"); 