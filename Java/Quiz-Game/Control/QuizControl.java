package Control;

import Database.CR7;
import Database.CS;
import Database.LOL;
import Database.MATEMATICA;
import Database.NARUTO;
import Database.SUPERNATURAL;
import Model.Questionario;

public class QuizControl {
    Questionario q;
    int perguntaAtual = 0;
    
    public QuizControl(String quiz){
        switch(quiz){
            case "CR7":
                CR7 qCr7 = new CR7();
                q = qCr7.getQuestoes();
            break;
            
            case "CS":
                CS qCs = new CS();
                q = qCs.getQuestoes();
            break;
            
            case "LOL":
                LOL qLol = new LOL();
                q = qLol.getQuestoes();
            break;
            
            case "MATEMATICA":
                MATEMATICA qMatematica = new MATEMATICA();
                q = qMatematica.getQuestoes();
            break;
            
            case "NARUTO":
                NARUTO qNaruto = new NARUTO();
                q = qNaruto.getQuestoes();
            break;
            
            case "SUPERNATURAL":
                SUPERNATURAL qSupernatural = new SUPERNATURAL();
                q = qSupernatural.getQuestoes();
            break;
        }
                
    }
    
    public String getPerguntas(){
        if (perguntaAtual <= q.getQuestoes().size()){
            return q.getQuestoes().get(perguntaAtual); 
        } else {
            return null;
        }
    }
    
    public String getAlternativas(int alt){
        return  q.getOpcoes()[perguntaAtual][alt];
    }
    
    public int getCorreta(){
        return q.getCorretas()[perguntaAtual];
    }
    
    public void proxPergunta(){
        this.perguntaAtual++;
    }
    
    public int getPerguntaAtual(){
        return perguntaAtual;
    }
    
}
