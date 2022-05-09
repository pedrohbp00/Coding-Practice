package Model;

import java.util.ArrayList;

public class Questionario {
    
    private ArrayList<String> questoes;
    private String[][] opcoes;
    private int qtdOpcoes;
    private int[] corretas;
    
    public Questionario(int qtdQuestoes, int qtdOpcoes){
        this.qtdOpcoes = qtdOpcoes;
        questoes = new ArrayList();
        opcoes = new String[qtdQuestoes][qtdOpcoes];
        corretas = new int[qtdQuestoes];
    }
    
    public ArrayList<String> getQuestoes() {
        return questoes;
    }

    public void setQuestoes(ArrayList<String> questoes) {
        this.questoes = questoes;
    }

    public String[][] getOpcoes() {
        return opcoes;
    }

    public void setOpcoes(String[][] opcoes) {
        this.opcoes = opcoes;
    }

    public int getQtdOpcoes() {
        return qtdOpcoes;
    }

    public void setQtdOpcoes(int quantidadeOpcoes) {
        this.qtdOpcoes = quantidadeOpcoes;
    }

    public int[] getCorretas() {
        return corretas;
    }

    public void setCorretas(int[] corretas) {
        this.corretas = corretas;
    }
    
    public boolean verificaCorreta(int questao, int resposta){
        return this.corretas[questao] == resposta;
    }
}
