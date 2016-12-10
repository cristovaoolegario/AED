using System;

    class ElementoListaDupla
    {
	public dynamic elemento;
        public ElementoListaDupla proximo, anterior;
	
	public ElementoListaDupla(){}
	public ElementoListaDupla(dynamic elemento)
	{
		this.elemento = elemento;
	}
    }

    class ListaDuplamenteEncadeada 
    {
        ElementoListaDupla primeiro, ultimo, sentinela;

        public ListaDuplamenteEncadeada()
        {
            sentinela = new ElementoListaDupla();
            primeiro = ultimo = sentinela;
        }

        public void InsereFinal(ElementoListaDupla elemento)
	{
		ultimo.proximo = elemento;
		elemento.anterior = ultimo;
		elemento.proximo = null;
	}

	public void InserePosicaoI(int i, ElementoListaDupla elemento)
	{
	    ElementoListaDupla anteriorAux = this.LocalizaElementoI(i - 1);
            ElementoListaDupla aux = anteriorAux.proximo;
	    elemento.proximo = aux;
	    elemento.anterior = anteriorAux;
	    aux.anterior = elemento;
	    anteriorAux.proximo = elemento;		

	}

        public ElementoListaDupla RetiraElementoI(int i)
	{
	    ElementoListaDupla anteriorAux = this.LocalizaElementoI(i - 1);
            ElementoListaDupla aux = anteriorAux.proximo;
	    ElementoListaDupla proximoAux = aux.proximo;

            anteriorAux.proximo = aux.proximo;
            aux.proximo = null;
	    proximoAux.anterior = aux.anterior;
	    aux.anterior = null;

	    return(aux);
	}

	public ElementoLista LocalizaElementoI(int i)
        {
	    int count = 0;
            ElementoListaDupla aux = primeiro;

            do
            {
                aux = aux.proximo;
                count++;
            }
            while (count != i);

            return (aux);
	}
   }
