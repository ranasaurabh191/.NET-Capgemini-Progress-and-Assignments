class Program
{
    static void Main()
    {
        int[][] jagged_arr = new int[4][];

        jagged_arr[0] = new int[]{1,2,3,4};
        jagged_arr[1] = new int[]{1,2,3};
        jagged_arr[2] = new int[]{12,3,4,5};
        jagged_arr[3] = new int[]{32,4,34,4};

        for(int i = 0; i < jagged_arr.Length; i++)
        {
            Console.Write("Row "+i+": ");
            for(int k = 0; k < jagged_arr[i].Length; k++)
            {
                Console.Write(jagged_arr[i][k]);
                if (k < jagged_arr[i].Length - 1)
                {
                    Console.Write(", ");
                }
            
            }
            Console.WriteLine();
        }
    }
}