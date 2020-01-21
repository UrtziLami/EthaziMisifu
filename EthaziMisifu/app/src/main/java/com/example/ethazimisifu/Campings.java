package com.example.ethazimisifu;

public class Campings {

    private int id;
    private String izena;
    private String deskribapena;
    private String udalerria;
    private String probintzia;
    private int telefonoa;
    private float longitudea;
    private float latitudea;

    public Campings(int id, String izena, String deskribapena, String udalerria,
                    String probintzia, int telefonoa, float longitudea, float latitudea) {
        this.id = id;
        this.izena = izena;
        this.deskribapena = deskribapena;
        this.udalerria = udalerria;
        this.probintzia = probintzia;
        this.telefonoa = telefonoa;
        this.longitudea = longitudea;
        this.latitudea = latitudea;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getIzena() {
        return izena;
    }

    public void setIzena(String izena) {
        this.izena = izena;
    }

    public String getDeskribapena() {
        return deskribapena;
    }

    public void setDeskribapena(String deskribapena) {
        this.deskribapena = deskribapena;
    }

    public String getUdalerria() {
        return udalerria;
    }

    public void setUdalerria(String udalerria) {
        this.udalerria = udalerria;
    }

    public String getProbintzia() {
        return probintzia;
    }

    public void setProbintzia(String probintzia) {
        this.probintzia = probintzia;
    }

    public int getTelefonoa() {
        return telefonoa;
    }

    public void setTelefonoa(int telefonoa) {
        this.telefonoa = telefonoa;
    }

    public float getLongitudea() {
        return longitudea;
    }

    public void setLongitudea(float longitudea) {
        this.longitudea = longitudea;
    }

    public float getLatitudea() {
        return latitudea;
    }

    public void setLatitudea(float latitudea) {
        this.latitudea = latitudea;
    }

}


