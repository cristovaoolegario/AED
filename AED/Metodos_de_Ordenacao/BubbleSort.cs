using System;

    class Bubble
    {
        static int comparacoesBub = 0;
        static int trocasBub = 0;

        public static void BubbleSort(int[] vetor)
        {            
            Console.WriteLine("\nBubblesort.");
            int aux;

            for (int i = vetor.Length - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    comparacoesBub++;
                    if (vetor2[j + 1] < vetor[j])
                    {
                        aux = vetor[j + 1];
                        vetor[j + 1] = vetor[j];
                        vetor[j] = aux;
                        trocasBub++;
                    }
                }
            }         

            Console.WriteLine("\nNumero de comparacoes: " + comparacoesBub + "\nNumero de trocas: " + trocasBub);            
        }
    }
