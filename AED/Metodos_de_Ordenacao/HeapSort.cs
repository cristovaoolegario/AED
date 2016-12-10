using System;

    class Heap
    {
        static int comparacoesHeap = 0;
        static int trocasHeap = 0;

        public static void HeapSort(int[] vetor, out StreamWriter escritor)
        {
            comparacoesHeap = 0;
            trocasHeap = 0;
            Console.WriteLine("\nHeapSort :");
            int tamanhoHeap = vetor.Length;
			
            for (int p = (tamanhoHeap - 1) / 2; p >= 0; p--)
            {
                MaximoHeap(vetor, tamanhoHeap, p);
            }

            for (int i = vetor.Length - 1; i > 0; i--)
            {                
                int temp = vetor[i];
                vetor[i] = vetor[0];
                vetor[0] = temp;
                trocasHeap++;

                tamanhoHeap--;
                MaximoHeap(vetor, tamanhoHeap, 0);
            }
         
            Console.WriteLine("\nNumero de comparacoes: " + comparacoesHeap + "\nNumero de trocas: " + trocasHeap);
        }

        private static void MaximoHeap(int[] vetor, int tamanhaHeap, int indice)
        {
            int esquerda = (indice + 1) * 2 - 1;
            int direita = (indice + 1) * 2;
            int maior = 0;

            comparacoesHeap++;
            if (esquerda < tamanhaHeap && vetor[esquerda] > vetor[indice])
            {
                maior = esquerda;
            }
            else
            {
                maior = indice;
            }

            comparacoesHeap++;
            if (direita < tamanhaHeap && vetor[direita] > vetor[maior])
            {
                maior = direita;
            }

            if (maior != indice)
            {
                int temp = vetor[indice];
                vetor[indice] = vetor[maior];
                vetor[maior] = temp;
                trocasHeap++;

                MaximoHeap(vetor, tamanhaHeap, maior);
            }
        }

    }
