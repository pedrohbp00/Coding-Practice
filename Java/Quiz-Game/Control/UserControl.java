/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Control;

import Model.User;

/**
 *
 * @author gerso
 */
public class UserControl {
    private User p;
    
    public UserControl(){
        p = new User();
    }
    
    public void InsertUser(String nome, String email, String usuario, String senha, int idade, int score){
        p.setNome(nome);
        p.setEmail(email);
        p.setUsuario(usuario);
        p.setSenha(senha);
        p.setIdade(idade);
        p.setScore(score);
    }
    
    public void AdicionaPonto(boolean correto){
        if(correto){
            p.addScore();
        }
    }
    
    public User getUser(){
        return p;
    }
}
