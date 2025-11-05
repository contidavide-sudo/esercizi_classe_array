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

            //6

            int[] v1 = { 3, 8, 6, 2, 9, 7 };

            int x = 5, contaMag = 0, contaMin = 0;

            for(int i=0;  i<v1.Length; i++)
            {
                if(v1[i] < x)
                {
                    contaMin = contaMin + 1;
                }
                else
                {
                    contaMag = contaMag + 1;
                }
            }

            int[] v2 = new int[contaMin];
            int[] v3 = new int[contaMag];

            int indMag = 0, indMin = 0;

            for(int i=0; i<v1.Length; i++)
            {
                if (v1[i] < x)
                {
                    v2[indMin] = v1[i];
                    indMin = indMin + 1;
                }
                else
                {
                    v3[indMag] = v1[i];
                    indMag = indMag + 1;
                }
            }

            for(int i=0; i<v2.Length; i++)
            {
                Console.Write($"[{v2[i]}]");
            }

            Console.WriteLine();

            for (int i = 0; i < v3.Length; i++)
            {
                Console.Write($"[{v3[i]}]");
            }
        }
    }
}
