using System;
		class Quick
		{

			static int comparacoesQuick = 0;
			static int trocasQuick = 0;

			public static void QuickSort(int[] vetor)
			{
				Console.WriteLine("\nQuickSort :");
				

				Ordenar(vetor, 0, vetor.Length - 1);


				for(int i = 0; i< vetor.Length; i++)
				{
					Console.WriteLine(vetor[i]);
				}				
				
				Console.WriteLine("Numero de comparacoes: " + comparacoesQuick + "\tNumero de trocas: " + trocasQuick);
			}

			private static void Ordenar(int[] vetor, int Inicio, int Fim)
			{
				if (Inicio < Fim)
				{
					int Pivo = Separa(vetor, Inicio, Fim);
					Ordenar(vetor, Inicio, Pivo - 1);
					Ordenar(vetor, Pivo + 1, Fim);
				}
			}

			private static int Separa(int[] vetor, int Inicio, int Fim)
			{
				int Mediano = vetor[Inicio];
				int i = Inicio + 1;
				int f = Fim;

				while (i <= f)
				{
					comparacoesQuick++;
					if (vetor[i] < (Mediano))
					{
						i++;
					}
					else
					{
						comparacoesQuick++;
						if (vetor[f] > Mediano))
						{
							f--;
						}
						else
						{
							int Troca = vetor[i];
							vetor[i] = vetor[f];
							vetor[f] = Troca;
							i++;
							f--;
							trocasQuick++;
						}
					}
				}

				vetor[Inicio] = vetor[f];
				vetor[f] = Mediano;
				trocasQuick++;

				return f;
			}
		}
