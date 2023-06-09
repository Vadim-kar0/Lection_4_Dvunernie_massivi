﻿// Двумерные массивы 


// СИНТАКСИС ДВУМЕРНЫХ МАССИВОВ

// string[,]table = new string[1,2];
// //запятая говорит о том что будет две размерности стороки и столбцы
// int[,] matrix = new int[5,8]; //5 - строки 8 - столбцы

// string[,] table = new string[2,5];
// table[1,2] = "slovo";

// string[0,0]  string[0,1]  string[0,2]  string[0,3]
// string[1,0]  string[1,1]  string[1,2]  string[1,3]

// table[1,2] = "slovo";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"={table[rows, columns]}=");
//     }
// }

// int[,] matrix = new int[3,4];
// for (int i = 0; i < matrix.GetLength(0); i++) //matrix.GetLength(0) 0 - берёт количество строк массива
// {
//     for (int j = 0; j < matrix.GetLength(1); j++) //matrix.GetLength(1) 1 - берёт количество столбцов массива
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
// Console.WriteLine();
// }

// МЕТОДЫ ДЛЯ ЗАПОЛНЕНИЯ И ВЫВОДА В КОНСОЛЬ ДВУМЕРНЫХ МАССИВОВ


// void PrintArray(int[,] matr) // Метод позволяет вывести массив в консоль
// {
// for (int i = 0; i < matr.GetLength(0); i++)
// {
//     for (int j = 0; j < matr.GetLength(1); j++) 
//     {
//         Console.Write($"{matr[i, j]} ");
//     }
// Console.WriteLine();
// }
// }

// void FillArray(int[,] matr) // Метод позволяет заполнить случайными числами массив 
// {
// for (int i = 0; i < matr.GetLength(0); i++)
// {
//     for (int j = 0; j < matr.GetLength(1); j++) 
//     {
//         matr[i,j] = new Random().Next(1,10); // Случайные числа от 1 до 9 [1;10)
//     }
// Console.WriteLine();
// }
// }


// int[,] matrix = new int[3,4];

// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


//string[,]table = new string[1,2]; - Двумерный массив со строками и столбцами
//string[] table = new string[8]; - Обычный массив 

// ЗАКРАШИВАНИЕ ТАБЛИЦЫ (ДВУМЕРНОГО МАССИВА)

//int[,] pic = new int[23,25] - необязательно указывать количество строчек  и столбцов если есть 
//фиксированные данные как записано снизу в двумерном массиве

// 0 - прозрачный
// 1 - надо закрасить

// int[,] pic = new int[,]
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// void PrintImage(int[,] image) // Метод позволяет вывести картинку из единиц в консоль
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             //Console.Write($"{image[i, j]} ");
//             if (image[i, j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }

// void FillImage(int row, int col) // Метод позволяет заполнить картинку из единиц числами 
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }

// PrintImage(pic);
// FillImage(13, 13);
// PrintImage(pic);


// РЕКУРСИЯ - ФУНКЦИЯ ВЫЗЫВАЕТ САМА СЕБЯ

// 5! = 5*4*3*2*1 - факториал
//      5*4!
//        4*3!
//          3*2!


// double Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }

// Console.WriteLine(Factorial(5));

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i} = {Factorial(i)}");
// }

// ФИБОНАЧИ

// F(1) = 1
// F(2) = 1
// F(N) = F(N-1) + F(N-2)

// double Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i} = {Fibonacci(i)}");
// }

// РЕКУРСИЯ ДЛЯ ОБХОДА ДИРРЕКТОРИИ
// зайти в дирректорию обойти все дирректории
