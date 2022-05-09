//Projeto Integrador: Estrutura de Dados I e Linguagem de Programação I.
//Este programa tem como estrutura de dado principal a lista, esta aplicação simula um controle de comandas de um restaurante, onde o usuário insere o pedido e ele é atribuído a uma lista.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Integrador_List
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        List<string> listaComida = new List<string>(); //Cria a lista listaComida.
        List<string> listaBebida = new List<string>(); //Cria a lista listaBebida.

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPedido_KeyPress(object sender, KeyPressEventArgs e) //Executa em tempo de execução um bloco de instruções quando alguma tecla for pressionada.
        {
            if (e.KeyChar == 13) //Verifica se a tecla "Enter" foi pressionada.
            {
                if (txtPedido.Text != "") //Verifica se o textbox de pedidos se encontra vázio ou não.
                {
                    if (cBoxTipo.SelectedItem != null) //Verifica se a combobox se encontra vázia ou não.
                    {
                        if (cBoxTipo.SelectedItem.ToString() == "Comida") //Executa o bloco de instruções abaixo se o item selecionado na combobox for do tipo "Comida".
                        {
                            listaComida.Add(txtPedido.Text); //Adiciona a lista de comidas o pedido que foi inserido na textbox.
                            lblQtdComida.Text = "Comandas: " + listaComida.Count.ToString(); //Imprime no label "Comandas" a contagem de quantos pedidos do tipo "Comida" foram feitos.
                            listComida.Items.Clear(); //Limpa os itens da listbox das comidas.
                            foreach (string comidas in listaComida) //Laço responsável por adicionar os pedidos do tipo "Comida" na listbox de comidas.
                            {
                                listComida.Items.Add("- " + comidas); //Adiciona na listbox de comidas o pedido do tipo "Comida" inserido pelo usuário.
                            }
                            
                        }

                        if (cBoxTipo.SelectedItem.ToString() == "Bebida") //Executa o bloco de instruções abaixo se o item selecionado na combobox for do tipo "Bebida".
                        {
                            listaBebida.Add(txtPedido.Text); //Adiciona a lista de bebidas o pedido que foi inserido na textbox de pedidos.
                            lblQtdBebida.Text = "Comandas: " + listaBebida.Count.ToString(); //Imprime no label "Comandas" a contagem de quantos pedidos do tipo "Bebida" foram feitos.
                            listBebida.Items.Clear(); //Limpa os itens da listbox das bebidas.
                            foreach (string bebidas in listaBebida) //Laço responsável por adicionar os pedidos do tipo "Bebida" na listbox de bebidas.
                            {
                                listBebida.Items.Add("- " + bebidas); //Adiciona na listbox de bebidas o pedido do tipo "Bebida" inserido pelo usuário.
                            }
                          
                        }
                        txtPedido.Clear(); //Limpa o conteúdo da textbox de pedidos.
                        txtPedido.Focus(); //Define o foco da entrada de dados para a textbox de pedidos.

                    } else { //Exibe uma messagebox avisando o usuário que nenhum item na combobox foi selecionado.
                        MessageBox.Show("Não se esqueça de selecionar a categoria...", "Erro");
                    }
                }
                else //Exibe uma messagebox avisando o usuário que nenhum pedido foi inserido.
                {
                    MessageBox.Show("Primeiramente, anote o pedido...", "Erro");
                }
            }
        }

        private void cBoxTipo_KeyPress(object sender, KeyPressEventArgs e) //Executa em tempo de execução quando uma tecla for pressionada quando a combobox estiver selecionada.
        {
            if (e.KeyChar == 13) //Verifica se a tecla "Enter" foi pressionada.
            {
                if (txtPedido.Text != "") //Verifica se o textbox de pedidos se encontra vázio ou não.
                {
                    if (cBoxTipo.SelectedItem != null) //Verifica se a combobox se encontra vázia ou não.
                    {
                        if (cBoxTipo.SelectedItem.ToString() == "Comida") //Executa o bloco de instruções abaixo se o item selecionado na combobox for do tipo "Comida". 
                        {
                            listaComida.Add(txtPedido.Text); //Adiciona a lista de comidas o pedido que foi inserido na textbox de pedidos.
                            lblQtdComida.Text = "Comandas: " + listaComida.Count.ToString(); //Imprime no label "Comandas" a contagem de quantos pedidos do tipo "Comida" foram feitos.
                            listComida.Items.Clear(); //Limpa os itens da listbox das comidas.
                            foreach (string comidas in listaComida) //Laço responsável por adicionar os pedidos do tipo "Comida" na listbox de comidas.
                            {
                                listComida.Items.Add("- " + comidas); //Adiciona na listbox de comidas o pedido do tipo "Comida" inserido pelo usuário.
                            }
                        }

                        if (cBoxTipo.SelectedItem.ToString() == "Bebida") //Executa o bloco de instruções abaixo se o item selecionado na combobox for do tipo "Bebida".
                        {
                            listaBebida.Add(txtPedido.Text); //Adiciona a lista de bebidas o pedido que foi inserido na textbox de pedidos.
                            lblQtdBebida.Text = "Comandas: " + listaBebida.Count.ToString(); //Imprime no label "Comandas" a contagem de quantos pedidos do tipo "Bebida" foram feitos.
                            listBebida.Items.Clear(); //Limpa os itens da listbox das bebidas.
                            foreach (string bebidas in listaBebida) //Laço responsável por adicionar os pedidos do tipo "Bebida" na listbox de bebidas.
                            {
                                listBebida.Items.Add("- " + bebidas); //Adiciona na listbox de bebidas o pedido do tipo "Bebida" inserido pelo usuário.
                            }
                        }
                        txtPedido.Clear(); //Limpa o conteúdo da textbox de pedidos.
                        txtPedido.Focus(); //Define o foco da entrada de dados para o textbox de pedidos.

                    }
                    else //Exibe uma messagebox avisando o usuário que nenhum item na combobox foi selecionado.
                    {
                        MessageBox.Show("Não se esqueça de selecionar a categoria...", "Erro");
                    }
                }
                else //Exibe uma messagebox avisando o usuário que nenhum pedido foi inserido.
                {
                    MessageBox.Show("Primeiramente, anote o pedido...", "Erro");
                }
            }

        }

        private void listComida_KeyPress(object sender, KeyPressEventArgs e) //Executa em tempo de execução um bloco de instruções se alguma tecla for pressionada quando a lista de comidas estiver selecionada.
        {
            if((e.KeyChar == 8) & (listComida.SelectedItem != null)) //Verifica se a tecla "Backspace" foi pressionada e se algum item da listbox de comida foi selecionado.
            {
                int temporario = listComida.SelectedIndex; //Armazena na variável temporario o índice do elemento selecionado na listbox de comidas.
                listaComida.RemoveAt(temporario); //Remove o item selecionado pelo usuário da lista de comidas.
                lblQtdComida.Text = "Comandas: " + listaComida.Count.ToString(); //Imprime no label de "Comandas" quantos itens estão presentes na listbox de comidas.
                listComida.Items.Clear(); //Limpa os itens da listbox de comidas.
                foreach (string comidas in listaComida) //Laço responsável por adicionar os pedidos do tipo "Comida" na listbox de comidas.
                {
                    listComida.Items.Add("- " + comidas); //Adiciona na listbox de comidas o pedido do tipo "Comida" inserido pelo usuário.
                }
            } else //Executa o bloco de instruções abaixo caso a tecla pressionada pelo usuário for diferente de "Backspace" ou se nada foi selecionado.
            {
                if (listComida.Items.Count == 0) //Verifica se há itens na listbox de comida.
                {
                    MessageBox.Show("Não há nenhum pedido para ser deletado...", "Erro"); //Exibe uma messagebox avisando o usuário que a listbox está vázia.
                } else //Exibe uma messagebox avisando o usuário para selecionar algum item da listbox.
                {
                    MessageBox.Show("Primeiramente, selecione um pedido para que possa ser deletado...", "Erro");
                }

            }
            txtPedido.Focus(); //Define o foco da entrada de dados para o textbox de pedidos.
        }

        private void listBebida_KeyPress(object sender, KeyPressEventArgs e) //Executa em tempo de execução um bloco de instruções se alguma tecla for pressionada quando a lista de bebidas estiver selecionada.
        {
            if ((e.KeyChar == 8) & (listBebida.SelectedItem != null)) //Verifica se a tecla "Backspace" foi pressionada e se algum item da listbox de bebidas foi selecionado.
            {
                int temporario = listBebida.SelectedIndex; //Armazena na variável temporario o índice do elemento selecionado na listbox de bebidas.
                listaBebida.RemoveAt(temporario); //Remove o item selecionado pelo usuário da lista de bebidas.
                lblQtdBebida.Text = "Comandas: " + listaBebida.Count.ToString(); //Imprime no label de "Comandas" quantos itens estão presentes na listbox de bebidas.
                listBebida.Items.Clear(); //Limpa a listbox de bebidas.
                foreach (string bebidas in listaBebida) //Laço responsável por adicionar os pedidos do tipo "Bebida" na listbox de bebidas.
                {
                    listBebida.Items.Add("- " + bebidas); //Adiciona na listbox de bebidas o pedido do tipo "Bebida" inserido pelo usuário.
                }
            }
            else //Executa o bloco de instruções abaixo caso a tecla pressionada pelo usuário for diferente de "Backspace" ou se nada foi selecionado.
            {
                if (listBebida.Items.Count == 0) //Verifica se há itens na listbox de bebida.
                {
                    MessageBox.Show("Não há nenhum pedido para ser deletado...", "Erro"); //Exibe uma messagebox avisando o usuário que a listbox está vázia.
                }
                else //Exibe uma messagebox avisando o usuário para selecionar algum item da listbox.
                {
                    MessageBox.Show("Primeiramente, selecione um pedido para que possa ser deletado...", "Erro");
                }

            }
            txtPedido.Focus(); //Define o foco da entrada de dados para o textbox de pedidos.
        }

        private void btnApagaComida_Click(object sender, EventArgs e) //Botão responsável por limpar a lista e a listbox de comidas.
        {
            if ((MessageBox.Show("Você está prestes a apagar todas as comidas...", "Tem certeza?", MessageBoxButtons.YesNo)) == DialogResult.Yes) //Executa o bloco de comandos abaixo caso o usuário confirme que deseja apagar a lista.
            {
                listaComida.Clear(); //Limpa a lista listaComida por completo.
                lblQtdComida.Text = "Comandas: " + listaComida.Count.ToString(); //Atualiza o contador de comandas da lista de comidas.
                listComida.Items.Clear(); //Limpa os itens da listbox de comidas.
            }
        }

        private void btnApagaBebida_Click(object sender, EventArgs e) //Botão responsável por limpar a lista e a listbox de comidas.
        {
            if ((MessageBox.Show("Você está prestes a apagar todas as bebidas...", "Tem certeza?", MessageBoxButtons.YesNo)) == DialogResult.Yes) //Executa o bloco de comandos abaixo caso o usuário confirme que deseja apagar a lista.
            {
                listaBebida.Clear(); //Limpa a lista listaBebida por completo.
                lblQtdBebida.Text = "Comandas: " + listaBebida.Count.ToString(); //Atualiza o contador de comandas da lista de bebidas.
                listBebida.Items.Clear(); //Limpa os itens da listbox de bebidas.
            }
        }
    }
}
