using System;

	class Elemento
	{
		public dynamic conteudo;
		public Elemento proximo;
		
		public Elemento(dynamic u)
		{
			this.conteudo = u;
			this.proximo = null;
		}
	}
	
	class Pilha
	{
		private Elemento fundo;
		private Elemento Sentinela;
		private Elemento topo;
		
		public Elemento()
		{
			this.fundo = Sentinela;
			this.topo = this.fundo;
		}
		
		public void Empilhar(Elemento el)
		{
			el.proximo = topo;
			topo = el;
		}
		
		public Elemento Desempilar()
		{
			if(PilhaVazia() == false)
			{
				Elemento aux = topo;
				topo = topo.proximo;
				aux.proximo = null;			
				return(aux);
			}
			else
			{
				return(null);
			}
		}
		
		public bool PilhaVazia()
		{
			if(this.fundo == this.topo)
			{
				return(true);
			}
			else
			{
				return(false);
			}
		}
		
		public Elemento Encontrar(dynamic id)
		{

		
	}
