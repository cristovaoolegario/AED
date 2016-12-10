using System;
	
    class ElementoFila
    {
        public dynamic elemento;
        public  ElementoFila proximo;

	public ElementoFila(){}
	public ElementoFila(dynamic elemento)
	{
		this.elemento = elemento;
	}
    }

    class Fila
    {
	ElementoFila primeiro, ultimo, sentinela;
	
	public Fila()
        {
            sentinela = new ElementoFila();
            primeiro = ultimo = sentinela;
        }
	
        public void InsereFinal(ElementoFila elemento)
        {
            this.ultimo.proximo = elemento;
            this.ultimo = elemento;
        }

        public ElementoFila RetiraElemento()
        {
            ElementoFila aux = this.primeiro.proximo;
            primeiro.proximo = aux.proximo;
            aux.proximo = null;

            return (aux);
        }

	public void ImprimirFila() 
	{
		ElementoFila aux = new ElementoFila();
		aux = this.sentinela;

		while(aux!= null)
		{
			//Imprimir aux. Console.WriteLine(aux.elemento.ToString());
			aux = aux.proximo;
		}		
	}

    }

