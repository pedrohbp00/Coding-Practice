package Database;

import Model.Questionario;
import java.util.ArrayList;

public class NARUTO {
    private ArrayList<String> questoes;
    private String[][] opcoes;
    private int[] corretas;
    Questionario q;
    
    public NARUTO(){
        q = new Questionario(8,4);
        questoes = new ArrayList();
        opcoes = new String[8][4];
        corretas = new int[8];
        
        cadastrarQuestoes();
        
    }
    
    private void cadastrarQuestoes(){
        questoes.add("Qual o nome completo do personagem principal?");
            opcoes[0][0] = "Sasuke Uchiha";
            opcoes[0][1] = "Naruto Uzumaki";
            opcoes[0][2] = "Naruto Umaki";
            opcoes[0][3] = "Saske Uchiha";  
                corretas[0] = 1;
        
        questoes.add("Qual o personagem que em Naruto Clássico era vilão, mas se torna amigo de Naruto?");
            opcoes[1][0] = "Gaara";
            opcoes[1][1] = "Rock Lee";
            opcoes[1][2] = "Kakashi Hatake";
            opcoes[1][3] = "Orochimaru";  
                corretas[0] = 0;
        
        questoes.add("Quem é responsável pelas marcas das maldições em diversos ninjas?");
            opcoes[2][0] = "Orochimaru";
            opcoes[2][1] = "Gaara";
            opcoes[2][2] = "Itachi Uchiha";
            opcoes[2][3] = "Senpai";  
                corretas[0] = 0;
        
        questoes.add("Em que vila nasceu e vive Naruto?");
            opcoes[3][0] = "Vila principal";
            opcoes[3][1] = "Vila da pedra";
            opcoes[3][2] = "Vila da areia";
            opcoes[3][3] = "Vila da folha";  
                corretas[0] = 3;
        
        questoes.add("Quantos membros tem o time 7?");
            opcoes[4][0] = "1";
            opcoes[4][1] = "2";
            opcoes[4][2] = "3";
            opcoes[4][3] = "4";  
                corretas[0] = 2;
        
        questoes.add("Quem é o sensei do time 7?");
            opcoes[5][0] = "Itachi";
            opcoes[5][1] = "Sasuke";
            opcoes[5][2] = "Kakashi";
            opcoes[5][3] = "Zayn";  
                corretas[0] = 0;
        
        questoes.add("Qual é da juubi de naruto?");
            opcoes[6][0] = "Shukaku";
            opcoes[6][1] = "Matatabi";
            opcoes[6][2] = "Isobu";
            opcoes[6][3] = "Kurama";  
                corretas[0] = 3;
        
        questoes.add("Quantas caudas tem a juubi de naruto?");
            opcoes[7][0] = "2";
            opcoes[7][1] = "9";
            opcoes[7][2] = "3";
            opcoes[7][3] = "7";  
                corretas[0] = 1;
        
        q.setQuestoes(questoes);
        q.setOpcoes(opcoes);
        q.setCorretas(corretas);
    }
    
    public Questionario getQuestoes(){
        return q;
    }
}
