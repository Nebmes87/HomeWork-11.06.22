// Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int numberA = new Random().Next(1, 10);
int numberB = new Random().Next(1, 10);
int numberC = new Random().Next(1, 10);
System.Console.WriteLine($"{numberA}{numberB}{numberC} -> {numberA}{numberC}");
