namespace Arrays_2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2D massiv elon qilish");
            int[,] array;
            array = new int[,] 
            { 
                { 1, 2, 3, 4 },
                { 1, 2, 3, 4},
                { 1, 2, 3, 4}
            };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j || i>j)
                    {
                        array[i, j] = 0;
                    }
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
