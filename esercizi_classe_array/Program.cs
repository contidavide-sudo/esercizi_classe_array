namespace esercizi_classe_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1

            int[] numContr = {4, 7, 8, 2, 9};

            for (int i = numContr.Length-1; i >= 0; i--)
            {
                Console.Write("[" + numContr[i] + "]");
            }
            
            Console.WriteLine();

            //2

            int[] indP = { 4, 7, 8, 2, 9 };

            for (int i = 0; i < indP.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("[" + indP[i] + "]");
                }
               
            }

            Console.WriteLine();

            //3

            int[] numD = { 4, 7, 8, 2, 9 };

            for (int i = 0; i < numD.Length; i++)
            {
                if (numD[i] % 2 == 1)
                {
                    Console.Write("[" + numD[i] + "]");
                }

            }

        }
    }
}
