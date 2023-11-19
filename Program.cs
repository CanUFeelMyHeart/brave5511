// Напишите программу, которая 
// выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

// Например:
// 78 -> 8 
// 12-> 2
// 85 -> 8

// [0, 3) => 0,1,2
// int number = new Random().Next(10, 100);
// // [10,99] или [10,100)
// // "/" - деление, "%" - взятие остатка
// int firstDigit = number / 10; // 78 / 10 = 7
// int secondDigit = number % 10; // 78 % 10 = 8
// // max = 7
// int max = firstDigit; // Пусть максимум - 1 цифра числа
// if (secondDigit > max) // secondDigit(8) > max(7)
// {
//     max = secondDigit; // max = 8
// }
// Console.WriteLine($"Максимальная цифра в числе {number}: {max}");

// Напишите программу, которая выводит случайное 
// трехзначное число и 
// удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// [100, 999]: Next(100,1000)
int number = new Random().Next(100, 1000);
int firstDigit = number / 100; // 456 / 100 = 4
int thirdDigit = number % 10; // 456 % 10 = 6
// 4 * 10 + 6
int result = firstDigit * 10 + thirdDigit;
Console.WriteLine($"{number} -> {result}");