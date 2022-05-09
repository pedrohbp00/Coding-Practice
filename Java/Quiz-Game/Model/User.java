/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Model;

/**
 *
 * @author gerso
 */
public class User {
    
    private static String nome;
    private static String email;
    private static String usuario;
    private static String senha;
    private static int idade;
    
    private int score;
    
    public User(String nome, String email, String usuario, String senha, int idade, int score){
        setNome(nome);
        setEmail(email);
        setUsuario(usuario);
        setSenha(senha);
        setIdade(idade);
        setScore(score);
    }

    public User() {
    }
    
    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email.toLowerCase();
    }

    public String getUsuario() {
        return usuario;
    }

    public void setUsuario(String usuario) {
        this.usuario = usuario.toLowerCase();
    }

    public String getSenha() {
        return senha;
    }

    public void setSenha(String senha) {
        this.senha = senha.toLowerCase();
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        this.idade = idade;
    }

    public int getScore() {
        return score;
    }

    public void setScore(int score) {
        this.score = score;
    }
    
    public boolean validaUser(String user, String pass){
        if (this.usuario.equals(user) && this.senha.equals(pass)){
            return true;
        } return false;    
    }
    
    public void addScore(){
        this.score += 1;
    }
}
