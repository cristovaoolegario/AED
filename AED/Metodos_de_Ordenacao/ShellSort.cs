using System;

class Shell
{
	public static void ShellSort(int[] vetor)
        {
            Console.WriteLine("\nShell Sort");         
            int h = 1;
            int n = vetor.Length;
            int compShellSort = 0;
            int trocasShellSort = 0;
			
            while (h < n)
            {
                h = 3 * h + 1;
            }

            h = h / 3;

            int c;
            int j;

            while (h > 0)
            {
                for (int i = h; i < n; i++)
                {
                    c = vetor[i];
                    j = i;

                    compShellSort++;
                    while (j >= h && vetor[j - h] > c)
                    {
                        vetor[j] = vetor[j - h];
                        j = j - h;
                        trocasShellSort++;
                        compShellSort++;
                    }

                    vetor[j] = c;

                }

                h = h / 2;
            }
           
            Console.WriteLine("\nNumero de comparacoes: " + CompShellSort + "\nNumero de trocas: " + TrocasShellSort);


        }
}
