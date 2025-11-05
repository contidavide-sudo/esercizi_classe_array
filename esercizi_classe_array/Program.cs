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

            //3 e 4

            int[] numD = { 4, 7, 8, 2, 9 };

            int contaP = 0, contaD = 0;

            for (int i = 0; i < numD.Length; i++)
            {
                if (numD[i] % 2 == 1)
                {
                    Console.Write($"[{numD[i]}]");

                    contaD = contaD + 1;
                }
                else
                {
                    contaP = contaP + 1;
                }

            }

            Console.WriteLine();

            Console.WriteLine("Numeri pari: " + contaP);
            Console.WriteLine("Numeri dispari: " + contaD);
        }
    }
}
