// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран.

Console.Clear();
 int[] myArray = new int[8];
         Random rand = new Random();
            
         for (int x = 0; x < myArray.Length; x++)
            {
                myArray[x] = rand.Next(100);
                Console.WriteLine("Значение элемента массива " + x + " = " + myArray[x]);
            }