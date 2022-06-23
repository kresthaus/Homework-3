// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран.

Console.Clear();
 int[] myArray = new int[8];
         Random rand = new Random();
            
         for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rand.Next(100);
                Console.WriteLine("Значение элемента массива " + i + " = " + myArray[i]);
            }