/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите трехзначное число");
Console.ReadLine();

int rundomNumber = (100,1000);
Console.WriteLine(rundomNumber);
int numberOne = (rundomNumber / 100) * 10;
int numberTwo = rundomNumber % 10;
Console.WriteLine($"результат{numberOne + numberTwo}");