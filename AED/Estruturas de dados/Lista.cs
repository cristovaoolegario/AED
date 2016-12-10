using System;

    class ElementoLista
    {
        public dynamic elemento;
        public  ElementoLista proximo;

	public ElementoLista(){}
	public ElementoLista(dynamic elemento)
	{
		this.elemento = elemento;
	}
    }

    class ListaEncadeada
    {
	ElementoLista primeiro, ultimo, sentinela;

	public ListaEncadeada()
        {
            sentinela = new ElementoLista();
            primeiro = ultimo = sentinela;
        }	

        public void InsereFinal(ElementoLista elemento)
        {
            ultimo.proximo = elemento;
            ultimo = elemento;
        }

        public ElementoLista LocalizaElementoI(int i)
        {
            int count = 0;
            ElementoLista aux = primeiro;

            do
            {
                aux = aux.proximo;
                count++;
            }
            while (count != i);

            return (aux);
        }      

        public ElementoLista RetiraElementoI(int i)
        {
            ElementoLista anteriorAux = this.LocalizaElementoI(i - 1);
            ElementoLista aux = anteriorAux.proximo;

            anteriorAux.proximo = aux.proximo;
            aux.proximo = null;

            return (aux);
        }

        public void ConcatenarLista(ListaGenerica listaASerConcatenada)
        {
            this.ultimo.proximo = listaASerConcatenada.Primeiro.proximo;
            listaASerConcatenada.Primeiro.proximo = null;
            this.ultimo = listaASerConcatenada.Ultimo;
            listaASerConcatenada.Ultimo = null;
        }
	
	public void ImprimirLista() 
	{
		ElementoFila aux = new ElementoFila();
		aux = this.sentinela;
		while(aux != null)
		{
			//Imprimir aux. Console.WriteLine(aux.elemento.ToString());
			aux = aux.proximo;
		}
	}

    }

