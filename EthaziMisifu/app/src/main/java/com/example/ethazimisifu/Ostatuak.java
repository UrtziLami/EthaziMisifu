package com.example.ethazimisifu;

import android.os.Parcel;
import android.os.Parcelable;

public class Ostatuak implements Parcelable {

    private String id;
    private String izena;
    private String deskribapena;
    private String udalerria;
    private String probintzia;
    private String email;
    private String telefonoa;
    private String web;
    private double latitudea;
    private double longitudea;
    private String ostatuMota;



    protected Ostatuak(Parcel in) {
        id = in.readString();
        izena = in.readString();
        deskribapena = in.readString();
        udalerria = in.readString();
        probintzia = in.readString();
        email = in.readString();
        telefonoa = in.readString();
        web = in.readString();
        latitudea = in.readDouble();
        longitudea = in.readDouble();
        ostatuMota = in.readString();
    }

    public static final Creator<Ostatuak> CREATOR = new Creator<Ostatuak>() {
        @Override
        public Ostatuak createFromParcel(Parcel in) {
            return new Ostatuak(in);
        }

        @Override
        public Ostatuak[] newArray(int size) {
            return new Ostatuak[size];
        }
    };

    public Ostatuak(String id, String izena, String deskribapena, String udalerria, String probintzia, String email, String telefonoa, String web, double latitudea, double longitudea, String ostatuMota) {
        this.id = id;
        this.izena = izena;
        this.deskribapena = deskribapena;
        this.udalerria = udalerria;
        this.probintzia = probintzia;
        this.email = email;
        this.telefonoa = telefonoa;
        this.web = web;
        this.latitudea = latitudea;
        this.longitudea = longitudea;
        this.ostatuMota = ostatuMota;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
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

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getTelefonoa() {
        return telefonoa;
    }

    public void setTelefonoa(String telefonoa) {
        this.telefonoa = telefonoa;
    }

    public String getWeb() {
        return web;
    }

    public void setWeb(String web) {
        this.web = web;
    }

    public double getLatitudea() {
        return latitudea;
    }

    public void setLatitudea(double latitudea) {
        this.latitudea = latitudea;
    }

    public double getLongitudea() {
        return longitudea;
    }

    public void setLongitudea(double longitudea) {
        this.longitudea = longitudea;
    }

    public String getOstatuMota() {
        return ostatuMota;
    }

    public void setOstatuMota(String ostatuMota) {
        this.ostatuMota = ostatuMota;
    }

    @Override
    public int describeContents() {
        return 0;
    }

    @Override
    public void writeToParcel(Parcel parcel, int i) {
        parcel.writeString(id);
        parcel.writeString(izena);
        parcel.writeString(deskribapena);
        parcel.writeString(udalerria);
        parcel.writeString(probintzia);
        parcel.writeString(telefonoa);
        parcel.writeString(web);
        parcel.writeDouble(latitudea);
        parcel.writeDouble(longitudea);
        parcel.writeString(ostatuMota);
    }



}
