package Database;

import Model.Questionario;
import java.util.ArrayList;

public class CS {
    private ArrayList<String> questoes;
    private String[][] opcoes;
    private int[] corretas;
    Questionario q;
    
    public CS(){
        q = new Questionario(8,4);
        questoes = new ArrayList();
        opcoes = new String[8][4];
        corretas = new int[8];
        
        cadastrarQuestoes();
        
    }
    
    private void cadastrarQuestoes(){
        questoes.add("Qual foi a versão de Counter-Strike mais jogada nas lan-houses nos anos 2000?");
            opcoes[0][0] = "Counter-Strike Global Offensive";
            opcoes[0][1] = "Counter-Strike 1.6";
            opcoes[0][2] = "Counter-Strike Source";
            opcoes[0][3] = "Counter-Strike 1.5";
                corretas[0] = 1;
        
        questoes.add("Qual é o time que venceu mais campeonatos mundiais(Majors)?");
            opcoes[1][0] = "SK Gaming";
            opcoes[1][1] = "Fnatic";
            opcoes[1][2] = "Astralis";
            opcoes[1][3] = "Natus Vincere";
                corretas[1] = 2;
        
        questoes.add("Qual é o único jogador brasileiro que tem 100% de winrate em Majors?");
            opcoes[2][0] = "Coldzera";
            opcoes[2][1] = "s1mple";
            opcoes[2][2] = "fnxL";
            opcoes[2][3] = "olofmeister";
                corretas[2] = 2;
        
        questoes.add("Qual é a posição(role) terrorista responsável por cortar rotações do CT e jogar na retaguarda do time?");
            opcoes[3][0] = "Entry-fragger";
            opcoes[3][1] = "Suporte";
            opcoes[3][2] = "Trader";
            opcoes[3][3] = "Lurker";
                corretas[3] = 3;
        
        questoes.add("Qual pistola do jogo é capaz de matar um jogador com apenas um tiro na cabeça utilizando capacete?");
            opcoes[4][0] = "Desert Eagle";
            opcoes[4][1] = "Tec-9";
            opcoes[4][2] = "Mac-10";
            opcoes[4][3] = "FiveSeven";
                corretas[4] = 0;
        
        questoes.add("Qual foi o primeiro titulo internacional que o Brasil ganhou no CS:GO");
            opcoes[5][0] = "MLG Columbus 2016";
            opcoes[5][1] = "Epicenter 2017";
            opcoes[5][2] = "ESL One: Cologne 2016";
            opcoes[5][3] = "Blast Pro Series";
                corretas[5] = 0;
        
        questoes.add("Qual é o mapa mais jogado no Matchmaking do CS:GO?");
            opcoes[6][0] = "Cache";
            opcoes[6][1] = "Inferno";
            opcoes[6][2] = "Mirage";
            opcoes[6][3] = "Dust 2";
                corretas[6] = 2;
        
        questoes.add("Quantos mundiais o time Astralis ja ganhou?");
            opcoes[7][0] = "4 mundiais";
            opcoes[7][1] = "Nenhum mundial";
            opcoes[7][2] = "2 mundiais";
            opcoes[7][3] = "Apenas um mundial";
                corretas[7] = 0;
        
        q.setQuestoes(questoes);
        q.setOpcoes(opcoes);
        q.setCorretas(corretas);
    }
    
    public Questionario getQuestoes(){
        return q;
    }
}
