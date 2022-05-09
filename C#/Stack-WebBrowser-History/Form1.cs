//Projeto Integrador: Estrutura de Dados e Linguagem de Programação I.
//Esta é uma aplicação que simula um navegador de internet tendo a pilha como estrutura de dado principal.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPilha
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        string outputStr; //Variável responsável por armazenar o histórico.
        Stack<string> minhapilha = new Stack<string>(); //Cria e instancia uma pilha chamada minhapilha.
        Stack<string> pilhaHistorico = new Stack<string>(); //Cria e instancia uma pilha chamada pilhaHistorico.

        private void btnAcessar_Click(object sender, EventArgs e) //Botão responsável por empilhar a string inserida no textbox.
        {
            minhapilha.Push(txtHistorico.Text); //Insere no topo da pilha minhapilha o conteúdo do textbox.
            txtHistorico.Focus(); //Define o foco de entrada para o textbox, permitindo a entrada de dados.
            txtHistorico.SelectAll(); //Seleciona todo o conteúdo do textbox.
        }

        private void txtHist_Click(object sender, EventArgs e) //Botão responsável por imprimir o histórico de navegação.
        {
            outputStr = string.Empty; //Define o conteúdo da variável outputStr como vázia.
              foreach (string historico in minhapilha) //Laço de repetição que passa por cada elemento da pilha.
              {
                outputStr += "- " + historico + Environment.NewLine; //Atribui e concatena a outputStr cada elemento da pilha e pula uma linha entre cada elemento.
              }
              MessageBox.Show(outputStr, "HISTORICO DE NAVEGAÇÃO"); //Imprime na tela, em formato de messagebox, o histórico de navegação.
            
        }

        private void btnClear_Click(object sender, EventArgs e) //Botão responsável por limpar o histórico e a pilha consequentemente.
        {
            if (minhapilha.Count() != 0) //Verifica se a pilha está vazia.
            {
                minhapilha.Clear(); //Método responsável por limpar a pilha minhapilha por completo.
                pilhaHistorico.Clear(); //Limpa a pilha pilhaHistorico por completo.
                txtHistorico.Clear(); //Apaga o conteúdo de txtHistorico.
                MessageBox.Show("Histórico limpo!", ""); //Exibe uma messagebox avisando que o histórico foi limpo.
                txtHistorico.Focus(); //Define o foco da entrada de dados para a textbox.
            } else //Avisa o usuário que a pilha está vazia.
            {
                MessageBox.Show("Seu histórico de navegação já está limpo!", ""); //Exibe uma messagebox avisando que o histórico já se encontra limpo.
                txtHistorico.Focus(); //Define o foco da entrada de dados para o textbox.
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e) //Botão responsável por voltar ao elemento anterior.
        {
            if (minhapilha.Count() != 1) //Verifica se há elementos na pilha.
            {
                pilhaHistorico.Push(minhapilha.Peek()); //Empilha em pilhaHistorico o topo da pilha minhapilha.
                minhapilha.Pop(); //Remove o topo da pilha minhapilha.
                txtHistorico.Text = minhapilha.Peek(); //Imprime no textbox o conteúdo do topo da minhapilha.
            } else //Avisa o usuário que há pilha está vázia.
            {
                MessageBox.Show("Não há mais para onde retornar...", "Erro"); //Exibe uma messagebox avisando que a pilha está vázia.
                txtHistorico.Focus(); //Define o foco da entrada de dados para o textbox.
                txtHistorico.SelectAll(); //Seleciona todo o conteúdo do textbox.
            }
        }

        private void btnAvancar_Click(object sender, EventArgs e) //Botão responsável por avançar ao próximo elemento.
        {
            if (pilhaHistorico.Count() != 0) //Verifica se há elementos na pilha.
            {
                minhapilha.Push(pilhaHistorico.Peek()); //Insere no topo de minhapilha o conteúdo do topo da pilha pilhaHistorico.
                pilhaHistorico.Pop(); //Remove o topo da pilhaHistorico.
                txtHistorico.Text = minhapilha.Peek(); //Atribui ao textbox o topo da pilha minhapilha.
            } else //Avisa o usuário que a pilha está vázia.
            {
                MessageBox.Show("Você já está na última página de acesso...", "Erro"); //Exibe uma messagebox avisando que a pilha está vázia.
                txtHistorico.Focus(); //Define o foco da entrada de dados para o textbox.
                txtHistorico.SelectAll(); //Seleciona todo o conteúdo da textbox.
            }
        }

        private void txtHistorico_KeyPress(object sender, KeyPressEventArgs e) //KeyPress é um evento que executa um bloco a cada vez que uma tecla é pressionada no campo "txtHistorico", mas especificamos na linha "if(e.KeyChar == 13)" que irá executar o bloco de comandos dentro do evento caso a tecla pressionada seja Enter.
        {
            if (e.KeyChar == 13)
            {
                minhapilha.Push(txtHistorico.Text); //Insere no topo da pilha minhapilha o conteúdo do textbox.
                txtHistorico.Focus(); //Define o foco da entrada de dados para o textbox.
                txtHistorico.SelectAll(); //Seleciona todo o conteúdo da textbox.
            }
        }
    }
}
