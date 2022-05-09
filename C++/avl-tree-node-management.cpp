//AVL-TREE NODE MANAGEMENT
//Date: 31/10/2020


#include <stdio.h>
#include <stdlib.h>

//Estrutura de um nó da arvore AVL
typedef struct noAVL{
	int conteudo;
	int alt; //Altura
	struct noAVL *dir, *esq;
}noAVL;

//Função que retorna o fator de balanceamento de um nó
int fatorBal(noAVL *z){
	
	int altEsq, altDir;
	
	if(z == NULL)
		return(0);
 
	if(z->esq == NULL)
		altEsq = 0;
	else
		altEsq = 1 + z->esq->alt;
 
	if(z->dir == NULL)
		altDir = 0;
	else
		altDir = 1 + z->dir->alt;
 
	return(altEsq - altDir);
}

//Função que printa na tela um menu com opções para o usuario manipular a arvore
void menu(){
	
		printf("\n1. Criar arvore AVL:");
		printf("\n2. Inserir no:");
		printf("\n3. Deletar no:");
		printf("\n4. Mostrar arvore:");
		printf("\n5. Sair:");
		printf("\n\nSelecione uma opcao:\n");
		
}

//Função que retorna a altura
int altura(noAVL *z){
	
	int altEsq, altDir;
	
	if(z == NULL)
	
		return(0);
	
	if(z->esq == NULL)
		altEsq = 0;
	else
		altEsq = 1 + z->esq->alt;
		
	if(z->dir == NULL)
		altDir = 0;
	else
		altDir = 1 + z->dir->alt;
	
	if(altEsq>altDir){
		
		return(altEsq);
	}
	
	return(altDir);
}

noAVL * rotacionaEsquerda(noAVL *x){
	noAVL *y;
	
	y = x->dir;
	x->dir = y->esq;
	y->esq = x;
	x->alt = altura(x);
	y->alt = altura(y);
	
	return(y);
}

noAVL * dirDireita(noAVL *z){
	z = rotacionaEsquerda(z);
	
	return(z);
}

noAVL * rotacionaDireita(noAVL *x){
	noAVL *y;
	
	y = x->esq;
	x->esq = y->dir;
	y->dir = x;
	x->alt = altura(x);
	y->alt = altura(y);
	
	return(y);
}

//Rotação dupla a direta
noAVL * dirEsq(noAVL *z){
	
	z->dir = rotacionaDireita(z->dir);
	z = rotacionaEsquerda(z);
	
	return(z);
}


noAVL * esqEsquerda(noAVL *z){
	z = rotacionaDireita(z);
	
	return(z);
}

//Rotacação dupla a esquerda
noAVL * esqDir(noAVL *z){
	
	z->esq = rotacionaEsquerda(z->esq);
	z = rotacionaDireita(z);
	
	return(z);
}

//Função que insere um nó na arvore
noAVL * inserir(noAVL *z, int x){
	
	if(z == NULL)
	{
		z = (noAVL*)malloc(sizeof(noAVL));
		z->conteudo = x;
		z->esq = NULL;
		z->dir = NULL;
	}
	else
		if(x > z->conteudo)     //Inserção na subarvore da direita
		{
			z->dir = inserir(z->dir, x);
			if(fatorBal(z) == -2)
				if(x > z->dir->conteudo)
					z = dirDireita(z);
				else
					z = dirEsq(z);
		}
		else
			if(x < z->conteudo)  //Inserção na subarvore da esquerda
			{
				z->esq = inserir(z->esq, x);
				if(fatorBal(z) == 2)
					if(x < z->esq->conteudo)
						z = esqEsquerda(z);
					else
						z = esqDir(z);
			}
		
		z->alt = altura(z);
		
		return(z);
}

//Função que remove um nó da arvore
noAVL * remover(noAVL *z, int x){
	
	noAVL *p;
	
	if(z == NULL)
	{
		return NULL;
	}
	else
		if(x > z->conteudo)		//Inserção na subarvore da direita
		{
			z->dir = remover(z->dir, x);
			if(fatorBal(z) == 2)
				if(fatorBal(z->esq) >= 0)
					z = esqEsquerda(z);
				else
					z = esqDir(z);
		}
		else
			if(x < z->conteudo)
			{
				z->esq = remover(z->esq, x);
				if(fatorBal(z) == -2)	//Rebalanceia a arvore
					if(fatorBal(z->dir) <= 0)
						z = dirDireita(z);
					else
						z = dirEsq(z);
			}
			else
			{
									//Executa o bloco abaixo se houver algo para ser deletado
				if(z->dir != NULL)
				{					//Apaga o proximo
					p = z->dir;
					
					while(p->esq != NULL)
						p = p->esq;
					
					z->conteudo = p->conteudo;
					z->dir = remover(z->dir, p->conteudo);
					
					if(fatorBal(z) == 2){  //Rebalanceia a arvore
						if(fatorBal(z->esq) >= 0)
							z = esqEsquerda(z);
						else
							z = esqDir(z);
					}
				}
				else
				
					return(z->esq);
			}
			
	z->alt = altura(z);
	
	return(z);
}

//Função que passa pela arvore em "pre-ordem" printando os nós e seu fator de balanceamento
void preOrdem(noAVL *z){
	if(z != NULL){
		printf("%d[FatorBalanceamento = %d]", z->conteudo, fatorBal(z));
		
		preOrdem(z->esq);
		
		preOrdem(z->dir);
	}
}

//Função que passa pela arvore "em-ordem" printando os nós e seu fator de balanceamento
void emOrdem(noAVL *z)
{
	if(z != NULL){
		emOrdem(z->esq);
		
		printf("%d[FatorBalanceamento = %d]", z->conteudo, fatorBal(z));
		
		emOrdem(z->dir);
	}
}




int main(){
	
	int n, x, opcao, i;
	noAVL *raiz = NULL;
	
	do
	{
		menu();
		scanf("%d", &opcao);
		
		switch(opcao)
		{
			case 1: 
					printf("\nInsira o numero de nos:");
					scanf("%d", &n);
					
					printf("\nInsira o conteudo da arvore:");
					
					raiz = NULL;
					for(i = 0; i < n; i++)
					{
						scanf("%d", &x);
						raiz = inserir(raiz, x);
					}
					
					break;
				
			case 2: 
					printf("\nInsira o conteudo do no que deseja criar:");
					scanf("%d", &x);
					
					raiz = inserir(raiz, x);
					
					break;
					
			case 3: 
					printf("\nInsira o no que deseja deletar:");
					scanf("%d", &x);
					
					raiz = remover(raiz, x);
					
					break;
			
			case 4: 
					printf("\nSequencia em pre-ordem:\n");
					preOrdem(raiz);
					
					printf("\n\nSequencia em ordem:\n");
					emOrdem(raiz);
					
					printf("\n\n");
					
					break;			
		}
	} while(opcao != 5);
	
	return 0;
}




