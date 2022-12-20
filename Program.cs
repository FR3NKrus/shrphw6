// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

    void CreateArray(int size){
      int [] array = new int [size]; 
      int count = 0;
      for (int i = 0; i < size; i++){
        Console.Write($"Введите {i+1}-ое число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0) count++;
      }
      Console.WriteLine($"Вы ввели {count} числа больше 0");
    }
    Console.WriteLine("Введите кол-во чисел: ");
    int size = Convert.ToInt32(Console.ReadLine());
    CreateArray(size);
    
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
 

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

    // double [] Intersection (double b1,double k1,double b2,double k2){
    //   double [] array = new double [2];
    //   array[0] = (b2 + b1*-1) / (k1 + k2*-1); // Нашли X
    //   array[1] = k1 * array[0] + b1; // Нашли Y
    // return array;  
    // }
    
    // Console.WriteLine("Введите координат b1: ");
    // double b1 = Convert.ToDouble(Console.ReadLine());
    // Console.WriteLine("Введите координат k1: ");
    // double k1 = Convert.ToDouble(Console.ReadLine());
    // Console.WriteLine("Введите координат b2: ");
    // double b2 = Convert.ToDouble(Console.ReadLine());
    // Console.WriteLine("Введите координат k2: ");
    // double k2 = Convert.ToDouble(Console.ReadLine());
    
    // double [] array = Intersection(b1,k1,b2,k2); // Запускаем Фунцкию 
    // Console.WriteLine($"Точки пересечения прямых: X:{array[0]} Y:{array[1]}"); // Выводим
    
    // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    // b1 = 7, k1 = 4, b2 = 9, k2 = 2 -> (1; 11)
   // b1 = 3, k1 = 7, b2 = 1, k2 = 5 -> (-1; -4)  
