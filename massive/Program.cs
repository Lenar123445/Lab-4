namespace dynamic_massive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 6];
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    matrix[i, j] = rand.Next(-100, 101);
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }
            DynamicArray positive = new DynamicArray();
            DynamicArray negative = new DynamicArray();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        positive.Add_End(matrix[i, j]);
                    }
                    else
                    {
                        negative.Add_End(matrix[i, j]);
                    }
                }
            }
            Console.WriteLine("\nМассив с положительными элементами:");
            for (int i = 0; i < positive.size; i++)
            {
                Console.Write(positive[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\nМассив с отрицательными элементами: ");
            for (int i = 0; i < negative.size; i++)
            {
                Console.Write(negative[i] + " ");
            }
            Console.WriteLine("\nМассив без последнего элемента: ");
            negative.Delete_End();
            negative.Print();
            Console.WriteLine("\nМассив без пятого элемента: ");
            negative.Remove(4);
            negative.Print();
            Console.WriteLine("\nМассив с 10 в конце: ");
            negative.Add_End(10);
            negative.Print();
            Console.WriteLine("\nМассив с 10 на 3 месте: ");
            negative.Insert(2, 10);
            negative.Print();
            Console.WriteLine("\nМассив без 10: ");
            negative.Remove_Value(10);
            negative.Print();
            Console.WriteLine("Индекс максимального элемент массива: " + negative.Max());
            Console.WriteLine("Заполнен ли массив: " + negative.Full());
            Console.WriteLine("Количество элементов в массиве: " + negative.Count());

            
            
        }
    }
}
