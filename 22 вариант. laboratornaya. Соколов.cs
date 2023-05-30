/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    double[] array = { 2.5, -3.7, 1.8, 4.2, -5.6 };
double maxSinus = double.MinValue; // переменная для хранения максимального синуса
foreach (double number in array)
{
    if (Math.Sin(number) < 0 && number > maxSinus)
    {
        maxSinus = number; // если синус отрицателен и число больше текущего максимального, обновляем значение максимального синуса
    }
}
if (maxSinus != double.MinValue)
{
    Console.WriteLine($"Максимальное число с отрицательным синусом: {maxSinus}");
}
else
{
    Console.WriteLine("В массиве нет чисел с отрицательным синусом");
}
  }
}