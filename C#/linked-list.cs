//Alunos: Pedro Henrique Bezerro Pereira, Pedro Henrique Estarque
//Projeto Integrador: Estrutura de Dados I e Linguagem de Programação I
//Este projeto utiliza como estrutura de dado principal a lista ligada linear.
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ListaLigadaLinear
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = new string[3];

            Console.WriteLine("Bem-Vindo ao Manipulador de Frases!");
            Console.WriteLine("Digite palavra por palavra da frase que deseja compor (limite de 3 palavras): ");

            for(int i = 0; i < palavras.Length; i++)
            {
                palavras[i] = Console.ReadLine();
            }
            //Criando a lista ligada e passando como parametro a string de palavras.
            LinkedList<string> frase = new LinkedList<string>(palavras);
            
            //Imprimindo a lista.
            PrintarLista(frase, "Elementos da lista:");

            //Adicionando uma palavra no inicio da frase(lista).
            Console.WriteLine("Digite uma palavra para ser adicionada no inicio da frase: ");
            string palavraInicio = Console.ReadLine();
            frase.AddFirst(palavraInicio);
            PrintarLista(frase, "A lista foi alterada.");

            //Alterando o conteúdo do último nodo.
            frase.RemoveLast();
            Console.WriteLine("Substitua uma palavra no final da frase:");
            string palavraUltimo = Console.ReadLine();
            frase.AddLast(palavraUltimo);
            PrintarLista(frase, "O último nodo da lista foi alterado.");

            //Movendo o primeiro nodo para o último nodo.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Deseja mover o primeiro nodo para o último nodo? S/N");
            string confirma = Console.ReadLine();
            if (confirma == "s" || confirma == "S")
            {
                LinkedListNode<string> nodo01 = frase.First;
                frase.RemoveFirst();
                frase.AddLast(nodo01);
                PrintarLista(frase, "O primeiro nodo da lista foi movido para o final da lista");

            }
            else
                Console.WriteLine("Nenhum nodo foi alterado");

            //Remove o nodo especificado pelo usuário da lista.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Deseja remover alguma palavra da frase? S/N");
            confirma = Console.ReadLine();
            if (confirma == "s" || confirma == "S")
            {
                Console.WriteLine("Digite a palavra(case-sensitive) que deseja remover:");
                string palavraRemover = Console.ReadLine();
                if (frase.Find(palavraRemover) != null)
                {
                    frase.Remove(frase.Find(palavraRemover));
                    PrintarLista(frase, "Nova frase: ");
                }
            }
            else
                Console.WriteLine("Nenhum nodo foi removido.");



        }

        
        //Função criada para imprimir a lista, passando como parâmetro uma lista encadeada do tipo string e uma variável texto do tipo string.
        private static void PrintarLista(LinkedList<string> palavras, string texto)
        {
            Console.WriteLine(texto);

            foreach (string qualquer in palavras)
            {
                Console.Write(qualquer + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
