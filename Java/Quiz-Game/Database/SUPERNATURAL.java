package Database;

import Model.Questionario;
import java.util.ArrayList;

public class SUPERNATURAL {
    private ArrayList<String> questoes;
    private String[][] opcoes;
    private int[] corretas;
    Questionario q;
    
    public SUPERNATURAL(){
        q = new Questionario(8,4);
        questoes = new ArrayList();
        opcoes = new String[8][4];
        corretas = new int[8];
        
        cadastrarQuestoes();
        
    }
    
    private void cadastrarQuestoes(){
        questoes.add("Quando foi estreado Supernatural?");
            opcoes[0][0] = "Setembro de 2008";
            opcoes[0][1] = "Janeiro 2010";
            opcoes[0][2] = "Setembro de 2005";
            opcoes[0][3] = "Novembro 2005";
                corretas[0] = 2;
        
        questoes.add("Quantas temporadas tem supernatural?");
            opcoes[1][0] = "15";
            opcoes[1][1] = "16";
            opcoes[1][2] = "10";
            opcoes[1][3] = "18";
                corretas[1] = 0;
        
        questoes.add("Qual o nome do demônio que trai Sam e abre a jaula de Lúcifer?");
            opcoes[2][0] = "Ruby";
            opcoes[2][1] = "Lilith";
            opcoes[2][2] = "Lucifer";
            opcoes[2][3] = "Dean";
                corretas[2] = 0;
        
        questoes.add("Qual o nome do pai do Sam e do Dean?");
            opcoes[3][0] = "John";
            opcoes[3][1] = "Paul";
            opcoes[3][2] = "Christopher";
            opcoes[3][3] = "Clyde";
                corretas[3] = 0;
        
        questoes.add("Qual é o anjo que possui Sam e menti para Dean na 9 temporada?");
            opcoes[4][0] = "Zacarias";
            opcoes[4][1] = "Gadriel";
            opcoes[4][2] = "Metatron";
            opcoes[4][3] = "Castiel";
                corretas[4] = 1;
        
        questoes.add("Quais anjos caiem do céu quando os portões se fecham?");
            opcoes[5][0] = "Todos";
            opcoes[5][1] = "Nenhum";
            opcoes[5][2] = "Apenas Castiel";
            opcoes[5][3] = "Ingrid, Castiel, Gadriel, Gabriel e Ana";
                corretas[5] = 0;
        
        questoes.add("Qual anjo se alia aos irmão Sam e Dean?");
            opcoes[6][0] = "Castiel";
            opcoes[6][1] = "Gabriel";
            opcoes[6][2] = "Zacarias";
            opcoes[6][3] = "Ana";
                corretas[6] = 0;
        
        questoes.add("Qual personagem se torna um demônio após fazer uso da faca de Kayn");
            opcoes[7][0] = "Kayn";
            opcoes[7][1] = "Dean";
            opcoes[7][2] = "Sam";
            opcoes[7][3] = "Crowley";
                corretas[7] = 1;
        
        q.setQuestoes(questoes);
        q.setOpcoes(opcoes);
        q.setCorretas(corretas);
    }
    
    public Questionario getQuestoes(){
        return q;
    }
}
