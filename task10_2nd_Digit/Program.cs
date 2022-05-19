/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

//      Первый вариант. 
//          Ответ: numberTwo
//          NumberOne - для себя 
Console.Clear();
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int numberOne = number % 100;
int numberTwo = (number / 10) % 10;
Console.WriteLine($"Не поверите! Вторая цифра {numberTwo}");

//      Второй вариант. 
// Console.Clear();
// Console.Write("Введи трёхзначное число: ");
// int NumberTwo = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(NumberTwo);
// Console.WriteLine("Не поверите! Вторая цифра  "+stringNumber[1]);
