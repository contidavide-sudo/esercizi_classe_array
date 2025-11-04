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


        }
    }
}
