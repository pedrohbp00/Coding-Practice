package Database;

import Model.Questionario;
import java.util.ArrayList;

public class CR7 {
    private ArrayList<String> questoes;
    private String[][] opcoes;
    private int[] corretas;
    Questionario q;
    
    public CR7(){
        q = new Questionario(8,4);
        questoes = new ArrayList();
        opcoes = new String[8][4];
        corretas = new int[8];
        
        cadastrarQuestoes();
        
    }
    
    private void cadastrarQuestoes(){
        questoes.add("Em qual time CR7 iniciou sua carreira?");
            opcoes[0][0] = "Nacional";
            opcoes[0][1] = "Manchester United";
            opcoes[0][2] = "Real Madrid";
            opcoes[0][3] = "Manchester City";
                corretas[0] = 0;
        
        questoes.add("Qual time CR7 jogou durante mais tempo?");
            opcoes[1][0] = "Manchester United";
            opcoes[1][1] = "Real Madrid";
            opcoes[1][2] = "Juventus";
            opcoes[1][3] = "Nacional";
                corretas[1] = 1;
        
        questoes.add("Quantos gols CR7 marcou durante sua passagem pela seleção portuguesa?");
            opcoes[2][0] = "100";
            opcoes[2][1] = "58";
            opcoes[2][2] = "102";
            opcoes[2][3] = "13";
                corretas[2] = 2;
        
        questoes.add("Quantas bolas de ouro CR7 tem?");
            opcoes[3][0] = "8";
            opcoes[3][1] = "4";
            opcoes[3][2] = "6";
            opcoes[3][3] = "5";
                corretas[3] = 3;
        
        questoes.add("Em qual time CR7 joga atualmente?");
            opcoes[4][0] = "Juventus";
            opcoes[4][1] = "Real Madrid";
            opcoes[4][2] = "Flamengo";
            opcoes[4][3] = "PSG";
                corretas[4] = 0;
        
        questoes.add("Qual o maior rival de CR7?");
            opcoes[5][0] = "Lionel Messi";
            opcoes[5][1] = "Neymar";
            opcoes[5][2] = "Pelé";
            opcoes[5][3] = "Ronaldinho";
                corretas[5] = 0;
        
        questoes.add("Quantos filhos tem CR7?");
            opcoes[6][0] = "1";
            opcoes[6][1] = "2";
            opcoes[6][2] = "3";
            opcoes[6][3] = "4";
                corretas[6] = 3;
        
        questoes.add("Qual o primeiro titulo que CR7 ganhou pela seleção portuguesa?");
            opcoes[7][0] = "Eurocopa 2016";
            opcoes[7][1] = "UEFA Champions League";
            opcoes[7][2] = "Eurocopa 2012";
            opcoes[7][3] = "Copa do Mundo de 2012";
                corretas[7] = 0;
        
        
        q.setQuestoes(questoes);
        q.setOpcoes(opcoes);
        q.setCorretas(corretas);
    }
    
    public Questionario getQuestoes(){
        return q;
    }
}
