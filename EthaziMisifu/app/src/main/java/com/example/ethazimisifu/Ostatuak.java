package com.example.ethazimisifu;

import android.os.Parcel;
import android.os.Parcelable;

public class Ostatuak implements Parcelable {

    private int id;
    private String izena;
    private String ostatuMota;
    private String deskribapena;
    private String udalerria;
    private String probintzia;
    private int telefonoa;
    private double latitudea;
    private double longitudea;

    public Ostatuak(int id, String izena, String ostatuMota, String deskribapena, String udalerria, String probintzia, int telefonoa, double latitudea, double longitudea) {
        this.id = id;
        this.izena = izena;
        this.ostatuMota = ostatuMota;
        this.deskribapena = deskribapena;
        this.udalerria = udalerria;
        this.probintzia = probintzia;
        this.telefonoa = telefonoa;
        this.latitudea = latitudea;
        this.longitudea = longitudea;
    }

    protected Ostatuak(Parcel in) {
        id = in.readInt();
        izena = in.readString();
        ostatuMota = in.readString();
        deskribapena = in.readString();
        udalerria = in.readString();
        probintzia = in.readString();
        telefonoa = in.readInt();
        latitudea = in.readDouble();
        longitudea = in.readDouble();
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

    public String getOstatuMota() {
        return ostatuMota;
    }

    public void setOstatuMota(String ostatuMota) {
        this.ostatuMota = ostatuMota;
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

    @Override
    public int describeContents() {
        return 0;
    }

    @Override
    public void writeToParcel(Parcel parcel, int i) {
        parcel.writeInt(id);
        parcel.writeString(izena);
        parcel.writeString(ostatuMota);
        parcel.writeString(deskribapena);
        parcel.writeString(udalerria);
        parcel.writeString(probintzia);
        parcel.writeInt(telefonoa);
        parcel.writeDouble(latitudea);
        parcel.writeDouble(longitudea);
    }
}
