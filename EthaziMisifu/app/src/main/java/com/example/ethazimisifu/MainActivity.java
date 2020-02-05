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
import android.content.SharedPreferences;
import android.os.AsyncTask;
import android.os.Bundle;
import android.text.method.PasswordTransformationMethod;
import android.util.Base64;
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

import java.util.ArrayList;

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

        SharedPreferences sp1=this.getSharedPreferences("Login", MODE_PRIVATE);

        String user = sp1.getString("User", null);
        etUser.setText(user);

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

                Intent intent = new Intent();
                intent.setClass(getApplicationContext(), Registro.class);
                startActivity(intent);

            }
        });

    }

    private void validarUsuario (final String URL){

        StringRequest stringRequest = new StringRequest(Request.Method.POST, URL, new com.android.volley.Response.Listener<String>() {
            @Override
            public void onResponse(String response) {
                Log.d("Kaixo",response);
                ArrayList<Usuarios> columnas = Consultas.userSartu(response);
                user = etUser.getText().toString();
                pass = etPasswd.getText().toString();
                int i = 0;
                boolean check = false;

                if(!user.equals("") && !pass.equals("")){
                    do{
                        if(user.equals(columnas.get(i).getUser()) && pass.equals(columnas.get(i).getPass())){
                            check = true;
                            Intent intent = new Intent();
                            intent.setClass(getApplicationContext(), Menu.class);
                            startActivity(intent);

                            SharedPreferences sp=getSharedPreferences("Login", MODE_PRIVATE);
                            SharedPreferences.Editor Ed=sp.edit();
                            Ed.putInt("id", columnas.get(i).getId());
                            Ed.putString("User", columnas.get(i).getUser());
                            Ed.commit();

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


}


