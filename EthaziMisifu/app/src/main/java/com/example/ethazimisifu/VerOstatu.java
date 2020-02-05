package com.example.ethazimisifu;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.text.Html;
import android.text.method.ScrollingMovementMethod;
import android.util.Log;
import android.view.View;
import android.widget.ScrollView;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;

public class VerOstatu extends AppCompatActivity {

    private TextView nombre, mota, descripcion, ubicacion, telefono, web, email;
    private ArrayList<String> ostatuArray = new ArrayList<String>();
    private ArrayList<String> mapaOstatu = new ArrayList<String>();
    private String izena, id;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ver_ostatu);

        nombre = (TextView) findViewById(R.id.txtNombre);
        descripcion = (TextView) findViewById(R.id.txtDescripcion);

        mota = (TextView) findViewById(R.id.txtOstatuMota);
        ubicacion = (TextView) findViewById(R.id.txtUbicacion);
        telefono = (TextView) findViewById(R.id.txtTelefono);
        web = (TextView) findViewById(R.id.txtWeb);
        email = (TextView) findViewById(R.id.txtEmail);

        Bundle extras = getIntent().getExtras();
        if(extras !=null) {
            ostatuArray = extras.getStringArrayList("KEY");
        }

        nombre.setText(ostatuArray.get(0));
        izena = ostatuArray.get(0);
        mota.setText(ostatuArray.get(1));
        ubicacion.setText(ostatuArray.get(2));
        telefono.setText(ostatuArray.get(4));
        web.setText(Html.fromHtml(ostatuArray.get(5)));
        descripcion.setText(ostatuArray.get(3));
        email.setText(ostatuArray.get(7));

    }

    public void volver(View v){
        Intent intent = new Intent(this, Lista.class);
        startActivity(intent);
        finish();
    }

    public void reserva(View v){

        Intent intent = new Intent(this, Reserva.class);
        intent.putExtra("KEY", izena);
        intent.putExtra("KEY2", ostatuArray.get(6));
        startActivity(intent);

    }

    public void mapa(View v){

        mapaOstatu.add(ostatuArray.get(0));
        mapaOstatu.add(ostatuArray.get(3));
        mapaOstatu.add(ostatuArray.get(9));
        mapaOstatu.add(ostatuArray.get(10));

        Intent intent = new Intent(getApplicationContext(), MapaOstatu.class);
        intent.putExtra("KEY", mapaOstatu);
        startActivity(intent);

    }

}
