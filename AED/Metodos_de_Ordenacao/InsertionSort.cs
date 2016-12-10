using System;

class Insertion
{
	public static void Insertionsort(int[] vetor)
        {
            Console.WriteLine("\nInsertionsort.");           
            int checar;
            int aux;
            int compInsertion = 0;
            int trocasInsertion = 0;

            for (int i = 1; i < vetor.Length; i++)
            {
                checar = vetor[i];
                aux = i;
                compInsertion++;
				
                while (aux > 0 && vetor[aux - 1] > checar)
                {
                    vetor[aux] = vetor[aux - 1];
                    aux--;
                    trocasInsertion++;
                    compInsertion++;

                }

                vetor[aux] = checar;

            }            
            Console.WriteLine("\nNumero de comparacoes: " + compInsertion + "\nNumero de trocas: " + trocasInsertion);

        }
}
