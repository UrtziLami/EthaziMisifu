package com.example.ethazimisifu;

public class Usuarios {

    private int id;
    private String izenAbizena;
    private String pass;
    private String user;

    public Usuarios(int id, String izenAbizena, String pass, String user) {
        this.id = id;
        this.izenAbizena = izenAbizena;
        this.pass = pass;
        this.user = user;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getIzenAbizena() {
        return izenAbizena;
    }

    public void setIzenAbizena(String izenAbizena) {
        this.izenAbizena = izenAbizena;
    }

    public String getPass() {
        return pass;
    }

    public void setPass(String pass) {
        this.pass = pass;
    }

    public String getUser() {
        return user;
    }

    public void setUser(String user) {
        this.user = user;
    }

    @Override
    public String toString() {
        return "Usuarios{" +
                "id=" + id +
                ", izenAbizena='" + izenAbizena + '\'' +
                ", pass='" + pass + '\'' +
                ", user='" + user + '\'' +
                '}';
    }
}
