package com.example.ethazimisifu;

import android.system.Os;
import android.util.Base64;
import android.util.Log;

import org.json.JSONArray;
import org.json.JSONException;

import java.security.NoSuchAlgorithmException;
import java.security.Security;
import java.security.spec.InvalidKeySpecException;
import java.security.spec.KeySpec;
import java.sql.Array;
import java.util.ArrayList;

import javax.crypto.Cipher;
import javax.crypto.SecretKeyFactory;
import javax.crypto.spec.IvParameterSpec;
import javax.crypto.spec.PBEKeySpec;
import javax.crypto.spec.SecretKeySpec;

public class Consultas {

    private int id = 0;
    private String user = "", pass = "";

    private static final int pswdIterations = 10;
    private static final int keySize = 128;
    private static final String cypherInstance = "AES/CBC/PKCS5Padding";
    private static final String secretKeyInstance = "PBKDF2WithHmacSHA1";
    private static final String plainText = "sampleText";
    private static final String AESSalt = "exampleSalt";
    private static final String initializationVector = "8119745113154120";


    public static ArrayList<Usuarios> userSartu(String response) {
        ArrayList<Usuarios> lista = new ArrayList<Usuarios>();

        response = response.replace("][",",");
        if (response.length()>0){
            try {
                JSONArray ja = new JSONArray(response);

                for(int i=0;i<ja.length();i+=4) {

                    try {
                        Usuarios ost = new Usuarios(ja.getInt(i), ja.getString(i + 1), decrypt(ja.getString(i + 2)), ja.getString(i + 3));
                        lista.add(ost);
                    } catch (JSONException e) {
                        e.printStackTrace();
                    } catch (Exception e) {
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
                        Ostatuak ost = new Ostatuak(ja.getString(i), ja.getString(i + 1), ja.getString(i + 2), ja.getString(i + 3), ja.getString(i + 4), ja.getString(i + 5), ja.getString(i + 6), ja.getString(i + 7), ja.getDouble(i + 8), ja.getDouble(i + 9), ja.getString(i + 10));
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

    public static String decrypt(String textToDecrypt) throws Exception {

        byte[] encryted_bytes = Base64.decode(textToDecrypt, Base64.DEFAULT);
        SecretKeySpec skeySpec = new SecretKeySpec(getRaw(plainText, AESSalt), "AES");
        Cipher cipher = Cipher.getInstance(cypherInstance);
        cipher.init(Cipher.DECRYPT_MODE, skeySpec, new IvParameterSpec(initializationVector.getBytes()));
        byte[] decrypted = cipher.doFinal(encryted_bytes);
        return new String(decrypted, "UTF-8");
    }

    private static byte[] getRaw(String plainText, String salt) {
        try {
            SecretKeyFactory factory = SecretKeyFactory.getInstance(secretKeyInstance);
            KeySpec spec = new PBEKeySpec(plainText.toCharArray(), salt.getBytes(), pswdIterations, keySize);
            return factory.generateSecret(spec).getEncoded();
        } catch (InvalidKeySpecException e) {
            e.printStackTrace();
        } catch (NoSuchAlgorithmException e) {
            e.printStackTrace();
        }
        return new byte[0];
    }

    public static ArrayList<Ostatuak> probintziak_atera(String response) {
        ArrayList<Ostatuak> lista = new ArrayList<Ostatuak>();

        Log.d("DRAGON", response);

        response = response.replace("][",",");
        if (response.length()>0){
            try {
                JSONArray ja = new JSONArray(response);

                for(int i=0;i<ja.length();i+=9) {

                    try {
                        Ostatuak ost = new Ostatuak(ja.getString(i), ja.getString(i + 1), ja.getString(i + 2), ja.getString(i + 3), ja.getString(i + 4), ja.getString(i + 5), ja.getString(i + 6), ja.getString(i + 7), ja.getDouble(i + 8), ja.getDouble(i + 9), ja.getString(i + 10));
                        Log.d("españa", ost.toString());
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
