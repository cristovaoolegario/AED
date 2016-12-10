using System;

class Select
{
	static int comparacoesSelect = 0;
        static int trocasSelect = 0;

	public static void SelectionSort(int[] vetor)
        {
            Console.WriteLine("\nSelection : ");
            int aux;
            int menor;
           

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                menor = i;

                for (int j = i + 1; j < vetor.Length; j++)
                {
                   comparacoesSelect++;
                    if (vetor[j] > vetor[menor])
                    {
                        menor = j;
                    }
                }

                if (menor != i)
                {
                    aux = vetor[menor];
                    vetor[menor] = vetor[i];
                    vetor[i] = aux;
                    trocasSelect++;
                }
            }
            
            Console.WriteLine("\nNumero de comparacoes: " + comparacoesSelect + "\nNumero de trocas: " + trocasSelect);
        }
}
