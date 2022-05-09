package Database;

import Model.Questionario;
import java.util.ArrayList;

public class MATEMATICA {
    private ArrayList<String> questoes;
    private String[][] opcoes;
    private int[] corretas;
    Questionario q;
    
    public MATEMATICA(){
        q = new Questionario(8,4);
        questoes = new ArrayList();
        opcoes = new String[8][4];
        corretas = new int[8];
        
        cadastrarQuestoes();
        
    }
    
    private void cadastrarQuestoes(){
        questoes.add("Quanto é 3 vezes 5?");
            opcoes[0][0] = "12";
            opcoes[0][1] = "15";
            opcoes[0][2] = "18";
            opcoes[0][3] = "8";  
                corretas[0] = 1;
        
        questoes.add("Quanto é a raiz quadrada de 36?");
            opcoes[1][0] = "6";
            opcoes[1][1] = "8";
            opcoes[1][2] = "7";
            opcoes[1][3] = "4";  
                corretas[0] = 0;
        
        questoes.add("Quantos vértices tem um quadrado?");
            opcoes[2][0] = "3";
            opcoes[2][1] = "2";
            opcoes[2][2] = "4";
            opcoes[2][3] = "5";  
                corretas[0] = 2;
        
        questoes.add("Quantos lados tem um octágono?");
            opcoes[3][0] = "18";
            opcoes[3][1] = "7";
            opcoes[3][2] = "9";
            opcoes[3][3] = "8";  
                corretas[0] = 3;
        
        questoes.add("Qual destes é um número primo?");
            opcoes[4][0] = "13";
            opcoes[4][1] = "14";
            opcoes[4][2] = "15";
            opcoes[4][3] = "16";  
                corretas[0] = 0;
        
        questoes.add("Quanto é 1 dividido por 0?");
            opcoes[5][0] = "0";
            opcoes[5][1] = "1";
            opcoes[5][2] = "Indefinido";
            opcoes[5][3] = "0 ou 1";  
                corretas[0] = 2;
        
        questoes.add("Qual é o fatorial de 5?");
            opcoes[6][0] = "100";
            opcoes[6][1] = "110";
            opcoes[6][2] = "120";
            opcoes[6][3] = "150";  
                corretas[0] = 2;
        
        questoes.add("2 com expoente dez resulta em:");
            opcoes[7][0] = "64";
            opcoes[7][1] = "1024";
            opcoes[7][2] = "128";
            opcoes[7][3] = "256";  
                corretas[0] = 1;
        
        q.setQuestoes(questoes);
        q.setOpcoes(opcoes);
        q.setCorretas(corretas);
    }
    
    public Questionario getQuestoes(){
        return q;
    }
}
