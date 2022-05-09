package Database;

import Model.Questionario;
import java.util.ArrayList;

public class LOL {
    private ArrayList<String> questoes;
    private String[][] opcoes;
    private int[] corretas;
    Questionario q;
    
    public LOL(){
        q = new Questionario(8,4);
        questoes = new ArrayList();
        opcoes = new String[8][4];
        corretas = new int[8];
        
        cadastrarQuestoes();
        
    }
    
    private void cadastrarQuestoes(){
        questoes.add("Qual universo de runeterra pertence Yasuo, um dos campeões mais jogados de League of Legends?");
            opcoes[0][0] = "Ionia";
            opcoes[0][1] = "Noxus";
            opcoes[0][2] = "Piltover";
            opcoes[0][3] = "Zaun";  
                corretas[0] = 0;
        
        questoes.add("Qual é o time brasileiro que é pentacampeão no CBLOL?");
            opcoes[1][0] = "Kabum";
            opcoes[1][1] = "Vivo Keyd";
            opcoes[1][2] = "Pain Gaming";
            opcoes[1][3] = "INTZ";  
                corretas[1] = 3;
        
        questoes.add("Qual o campeão mais recente?");
            opcoes[2][0] = "Samira";
            opcoes[2][1] = "Seraphine";
            opcoes[2][2] = "Rell";
            opcoes[2][3] = "Aphelios";  
                corretas[2] = 2;
        
        questoes.add("Que campeão assume forma de pombo ao pressionar um comando do teclado?");
            opcoes[3][0] = "Quinn";
            opcoes[3][1] = "Azir";
            opcoes[3][2] = "Sejuani";
            opcoes[3][3] = "Yuumi";  
                corretas[3] = 1;
        
        questoes.add("Quantas skins ultimates existem?");
            opcoes[4][0] = "3";
            opcoes[4][1] = "4";
            opcoes[4][2] = "5";
            opcoes[4][3] = "6";  
                corretas[4] = 3;
        
        questoes.add("Qual apelido a comunidade aderiu a criatura que surge nos rios de League Of Legends?");
            opcoes[5][0] = "Azuleijo";
            opcoes[5][1] = "Carangueijo";
            opcoes[5][2] = "Arauto";
            opcoes[5][3] = "Manga";  
                corretas[5] = 1;
        
        questoes.add("Qual é o jogador mundialmente conhecido pelas perfomances no mundial e recebe destaque como O Melhor Jogador de LoL?");
            opcoes[6][0] = "Kami";
            opcoes[6][1] = "DoubleLift";
            opcoes[6][2] = "Faker";
            opcoes[6][3] = "SKT T1";  
                corretas[6] = 2;
        
        questoes.add("'Num massacre floresço, como uma flor no amanhecer'. Qual campeão pertence esta fala?");
            opcoes[7][0] = "Jhin";
            opcoes[7][1] = "Ivern";
            opcoes[7][2] = "Sylas";
            opcoes[7][3] = "Riven";  
                corretas[7] = 0;
        
        q.setQuestoes(questoes);
        q.setOpcoes(opcoes);
        q.setCorretas(corretas);
    }
    
    public Questionario getQuestoes(){
        return q;
    }
}
