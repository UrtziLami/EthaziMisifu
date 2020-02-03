package com.example.ethazimisifu;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;
import cz.msebera.android.httpclient.HttpEntity;
import cz.msebera.android.httpclient.HttpResponse;
import cz.msebera.android.httpclient.client.ClientProtocolException;
import cz.msebera.android.httpclient.client.HttpClient;
import cz.msebera.android.httpclient.client.entity.UrlEncodedFormEntity;
import cz.msebera.android.httpclient.client.methods.HttpPost;
import cz.msebera.android.httpclient.impl.client.DefaultHttpClient;
import cz.msebera.android.httpclient.message.BasicNameValuePair;

import android.content.Intent;
import android.graphics.Bitmap;
import android.os.AsyncTask;
import android.os.Bundle;
import android.util.Base64;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.security.NoSuchAlgorithmException;
import java.security.SecureRandom;
import java.security.spec.InvalidKeySpecException;
import java.security.spec.KeySpec;
import java.util.ArrayList;
import java.util.List;

import javax.crypto.Cipher;
import javax.crypto.KeyGenerator;
import javax.crypto.SecretKey;
import javax.crypto.SecretKeyFactory;
import javax.crypto.spec.IvParameterSpec;
import javax.crypto.spec.PBEKeySpec;
import javax.crypto.spec.SecretKeySpec;

public class Registro extends AppCompatActivity {

    private EditText etNombre, etPasswd, etUser;
    private Button btnRegister;
    private String nombre, user, pass;


    private static final int pswdIterations = 10;
    private static final int keySize = 128;
    private static final String cypherInstance = "AES/CBC/PKCS5Padding";
    private static final String secretKeyInstance = "PBKDF2WithHmacSHA1";
    private static final String plainText = "12345";
    private static final String AESSalt = "exampleSalt";
    private static final String initializationVector = "8119745113154120";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_registro);

        etNombre = (EditText) findViewById(R.id.etNombre);
        etPasswd = (EditText) findViewById(R.id.etPassword);
        etUser = (EditText) findViewById(R.id.etUser);

        btnRegister = (Button) findViewById(R.id.btnRegistrar);

        btnRegister.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {


                nombre = etNombre.getText().toString();
                pass = etPasswd.getText().toString();
                user = etUser.getText().toString();
                InsertData(nombre, user, pass);

                Intent intent = new Intent();
                intent.setClass(getApplicationContext(), MainActivity.class);
                startActivity(intent);

            }
        });

    }

    public static String encrypt(String textToEncrypt) throws Exception {

        SecretKeySpec skeySpec = new SecretKeySpec(getRaw(plainText, AESSalt), "AES");
        Cipher cipher = Cipher.getInstance(cypherInstance);
        cipher.init(Cipher.ENCRYPT_MODE, skeySpec, new IvParameterSpec(initializationVector.getBytes()));
        byte[] encrypted = cipher.doFinal(textToEncrypt.getBytes());
        return Base64.encodeToString(encrypted, Base64.DEFAULT);
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

    public void InsertData(final String nombre, final String user, final String pass){
        if (!nombre.equals("") && !user.equals("") && !pass.equals("")) {
            class SendPostReqAsyncTask extends AsyncTask<String, Void, String> {
                @Override
                protected String doInBackground(String... params) {

                    List<BasicNameValuePair> nameValuePairs = new ArrayList<>();

                    nameValuePairs.add(new BasicNameValuePair("idBezeroak", null));
                    try {
                        nameValuePairs.add(new BasicNameValuePair("izenAbizena", nombre));
                        nameValuePairs.add(new BasicNameValuePair("pasahitza", encrypt(pass)));
                        nameValuePairs.add(new BasicNameValuePair("erabIzena", user));

                        Log.d("MyApp",nombre);
                        Log.d("MyApp",encrypt(pass));
                        Log.d("MyApp",user);

                    } catch (Exception e) {
                        e.printStackTrace();
                    }

                    try {
                        HttpClient httpClient = new DefaultHttpClient();

                        HttpPost httpPost = new HttpPost("http://192.168.13.33/misifu/insertUsuario.php");

                        httpPost.setEntity(new UrlEncodedFormEntity(nameValuePairs));

                        HttpResponse httpResponse = httpClient.execute(httpPost);

                        HttpEntity httpEntity = httpResponse.getEntity();


                    } catch (ClientProtocolException e) {

                    } catch (IOException e) {

                    }
                    return "Data Inserted Successfully";
                }



                @Override
                protected void onPostExecute(String result) {

                    super.onPostExecute(result);

                    Toast.makeText(getApplicationContext(), "Se ha registrado el nuevo usuario con exito", Toast.LENGTH_LONG).show();

                }
            }

            SendPostReqAsyncTask sendPostReqAsyncTask = new SendPostReqAsyncTask();

            sendPostReqAsyncTask.execute(null, nombre, pass, user);

        } else {
            Toast.makeText(getApplicationContext(), "No se permiten campos vacios", Toast.LENGTH_LONG).show();
        }

    }


}

