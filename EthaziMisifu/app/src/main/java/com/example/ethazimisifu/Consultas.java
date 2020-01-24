package com.example.ethazimisifu;

import android.util.Log;

import org.json.JSONArray;
import org.json.JSONException;

import java.util.ArrayList;

public class Consultas {
    private int id = 0;
    private String user = "", pass = "";


    public static ArrayList<Usuarios> userSartu(String response) {
        ArrayList<Usuarios> lista = new ArrayList<Usuarios>();

        response = response.replace("][",",");
        if (response.length()>0){
            try {
                JSONArray ja = new JSONArray(response);

                for(int i=0;i<ja.length();i+=3) {

                    try {
                        Usuarios ost = new Usuarios(ja.getInt(i), ja.getString(i + 1), ja.getString(i + 2));
                        lista.add(ost);
                    } catch (JSONException e) {
                        e.printStackTrace();
                    }
                }

            } catch (JSONException e) {
                e.printStackTrace();
            }

        }

        return lista;
    }

    public static ArrayList<Ostatuak> ostatuLista(String response) {
        ArrayList<Ostatuak> lista = new ArrayList<Ostatuak>();

        response = response.replace("][",",");
        if (response.length()>0){
            try {
                JSONArray ja = new JSONArray(response);

                for(int i=0;i<ja.length();i+=9) {

                    try {
                        Ostatuak ost = new Ostatuak(ja.getInt(i), ja.getString(i + 1), ja.getString(i + 2), ja.getString(i + 3), ja.getString(i + 4), ja.getString(i + 5), ja.getInt(i + 6), Double.parseDouble(ja.getString(i + 7)),  Double.parseDouble(ja.getString(i + 8)));
                        Log.d("erabiltzaile", ja.getString(i + 1));
                        lista.add(ost);
                    } catch (JSONException e) {
                        e.printStackTrace();
                    }
                }

            } catch (JSONException e) {
                e.printStackTrace();
            }

        }

        return lista;
    }

    public static ArrayList<Ostatuak> probintziak_atera(String response) {
        ArrayList<Ostatuak> lista = new ArrayList<Ostatuak>();

        response = response.replace("][",",");
        if (response.length()>0){
            try {
                JSONArray ja = new JSONArray(response);

                for(int i=0;i<ja.length();i+=9) {

                    try {
                        Ostatuak ost = new Ostatuak(ja.getInt(i), ja.getString(i + 1), ja.getString(i + 2), ja.getString(i + 3), ja.getString(i + 4), ja.getString(i + 5), ja.getInt(i + 6), Double.parseDouble(ja.getString(i + 7)),  Double.parseDouble(ja.getString(i + 8)));
                        Log.d("erabiltzaile", ja.getString(i + 1));
                        lista.add(ost);
                    } catch (JSONException e) {
                        e.printStackTrace();
                    }
                }

            } catch (JSONException e) {
                e.printStackTrace();
            }

        }

        return lista;
    }

}
