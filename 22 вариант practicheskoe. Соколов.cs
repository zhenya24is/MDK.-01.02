/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int[,,]array = new int[10,10,10]; // создание трехмерного массива размером 10x10x10

    Random rnd = new Random(); // создание объекта датчика случайных чисел

    for (int i = 0; i < array.GetLength(0); i++) // перебор элементов массива по первому измерению
    {
        for (int j = 0; j < array.GetLength(1); j++) // перебор элементов массива по второму измерению
        {
            for (int k = 0; k < array.GetLength(2); k++) // перебор элементов массива по третьему измерению
            {
                
                int value = rnd.Next(1000); // генерация случайного числа от 0 до 999
    
                while (Array.IndexOf(array, value) != -1) // проверка на уникальность элемента
                {
                    value = rnd.Next(1000); // если элемент уже есть в массиве, генерируем новое случайное число
                }
                array[i, j, k] = value; // запись уникального значения в элемент массива
                Console.Write(array[i, j, k] + " ");
            }
              Console.WriteLine();
        }
         Console.WriteLine();
    }
  }
}