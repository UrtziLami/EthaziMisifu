package com.example.ethazimisifu;

import androidx.appcompat.app.AppCompatActivity;
import cz.msebera.android.httpclient.HttpEntity;
import cz.msebera.android.httpclient.HttpResponse;
import cz.msebera.android.httpclient.client.ClientProtocolException;
import cz.msebera.android.httpclient.client.HttpClient;
import cz.msebera.android.httpclient.client.entity.UrlEncodedFormEntity;
import cz.msebera.android.httpclient.client.methods.HttpPost;
import cz.msebera.android.httpclient.impl.client.DefaultHttpClient;
import cz.msebera.android.httpclient.message.BasicNameValuePair;

import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.text.method.PasswordTransformationMethod;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.CompoundButton;
import android.widget.EditText;
import android.widget.Switch;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    private Switch switchPasswd;
    private EditText etPasswd, etUser;
    private Button btnLogin, btnRegister;
    private String user, pass;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        setTitle("LogIn");
        switchPasswd = (Switch) findViewById(R.id.switchPassword);
        etPasswd = (EditText) findViewById(R.id.etPassword);
        etUser = (EditText) findViewById(R.id.etUser);
        btnLogin = findViewById(R.id.btnLogin);
        btnRegister = findViewById(R.id.btnRegistrar);

        switchPasswd.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {

                if (switchPasswd.isChecked()) {
                    etPasswd.setTransformationMethod(null);
                } else {
                    etPasswd.setTransformationMethod(new PasswordTransformationMethod());
                }

            }
        });

        btnLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view){
                validarUsuario("http://192.168.13.33/misifu/validar_usuario.php");
            }
        });

        btnRegister.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                GetData();

                InsertData(user, pass);

            }
        });

    }

    private void validarUsuario (final String URL){

        StringRequest stringRequest = new StringRequest(Request.Method.POST, URL, new com.android.volley.Response.Listener<String>() {
            @Override
            public void onResponse(String response) {
                ArrayList<Usuarios> columnas = Consultas.userSartu(response);
                user = etUser.getText().toString();
                pass = etPasswd.getText().toString();
                int i = 0;
                boolean check = false;

                Log.d("España", response);

                if(!user.equals("") && !pass.equals("")){
                    do{
                        if(user.equals(columnas.get(i).getUser()) && pass.equals(columnas.get(i).getPass())){
                            check = true;
                            Intent intent = new Intent();
                            intent.setClass(getApplicationContext(), Menu.class);
                            startActivity(intent);

                        }
                        i++;
                    } while(i <= columnas.size() - 1);
                    if (check == false) {
                        Toast.makeText(MainActivity.this,"Usuario y/o contyraseña incorrecto(s)", Toast.LENGTH_LONG).show();
                    }

                }else {
                    Toast.makeText(MainActivity.this, "No se permiten campos vacios", Toast.LENGTH_LONG).show();
                }
            }

        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                Toast.makeText(MainActivity.this, error.toString(), Toast.LENGTH_SHORT).show();
            }
        });

        RequestQueue requestQueue = Volley.newRequestQueue(this);
        requestQueue.add(stringRequest);

    }

    public void GetData(){
        user = etUser.getText().toString();
        pass = etPasswd.getText().toString();
    }

    public void InsertData(final String user, final String pass){
        if (!user.equals("") && !pass.equals("")) {
        class SendPostReqAsyncTask extends AsyncTask<String, Void, String> {
            @Override
            protected String doInBackground(String... params) {



                    String NameHolder = user;
                    String EmailHolder = pass;

                    List<BasicNameValuePair> nameValuePairs = new ArrayList<>();

                    nameValuePairs.add(new BasicNameValuePair("id", null));
                    nameValuePairs.add(new BasicNameValuePair("erabiltzailea", NameHolder));
                    nameValuePairs.add(new BasicNameValuePair("pasahitza", EmailHolder));

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

                Toast.makeText(MainActivity.this, "Se ha registrado el nuevo usuario con exito", Toast.LENGTH_LONG).show();

            }
        }

        SendPostReqAsyncTask sendPostReqAsyncTask = new SendPostReqAsyncTask();

        sendPostReqAsyncTask.execute(null, user, pass);

        } else {
            Toast.makeText(MainActivity.this, "No se permiten campos vacios", Toast.LENGTH_LONG).show();
        }

    }


}


