// string[,] table= new string[2, 5]; // 2 строчки, 5 столбцов. Индекс начинается с ноля

// Srting.Empty - инициализация с помощью константы

// table[0,0]    table[0,1]   table[0,2]   table[0,3]   table[0,4] 
// table[1,0]    table[1,1]   table[1,2]   table[1,3]   table[1,4] 

// table[1, 2] = "cлово"; // обращаемся к нужному нам элементу. Первая строка второй столбец, задаем переменную.

// for (int rows = 0; rows < 2; rows++) // rows < 2 - количество строк не более двух
// {
//   for (int columns = 0; columns < 5; columns++) // columns < 5 - количество столбцов не более пяти
//   {
//     Console.WriteLine($"-{table[rows, columns]}-");
//   }
// }


//  метод PrintArray принимает прямоугольную таблицу чисел и будет печатать её на экран
// void PrintArray(int[,] matr) // передаем прямоугольную таблицу чисел
// {
//    for (int i = 0; i < matr.GetLength(0); i++) // matrix.GetLength(0) - 3 строки
//    { 
//       for (int j = 0; j < matr.GetLength(1); j++) // matrix.GetLength(1) - 4 столбца
//       {
//          Console.Write($"{matr[i,j]} "); // выводим на экран
//       }
//     Console.WriteLine(); // переход на новую строку
//   }
// }

// void FillArray(int[,] matr) // заполняем случайными числами с помощью метода 
// {
//    for (int i = 0; i < matr.GetLength(0); i++)
//    {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//       matr[i,j] = new Random().Next(1,10); // полуинтервал от 1 до 10 - [1, 10)
//     }
//    }
// }

// int[,] matrix = new int[3, 4]; // инициализируем
// PrintArray(matrix); // заполняем нолями
// FillArray(matrix); // в качестве аргумента передаем наш массив
// Console.WriteLine(); // пустая строка
// PrintArray(matrix); // печатаем массив

//  определим метод, который будет принимать число, факториал которого нужно вычислить

// double Factorial (int n)
// {
//   // 1! = 1
//   // 0! = 1
//   if(n == 1) return 1; // если 1 возвращаеи 1
//   else return n * Factorial(n - 1); // если не 1 то n * факториал предыдущего числа
// }

// for (int i = 0; i < 40; i++)
// {
//   Console.WriteLine($"{i}! = {Factorial(i)}");
// }


// числа Фибоначчи

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(b-2)

double Fibonacci(int n)
{
  if(n == 1 || n == 2) return 1;
  else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 40; i++)
{
  Console.WriteLine(Fibonacci(i));
}
