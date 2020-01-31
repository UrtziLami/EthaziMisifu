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

import java.util.ArrayList;

public class VerOstatu extends AppCompatActivity {

    private TextView nombre, mota, descripcion, ubicacion, telefono, web, email;
    private ArrayList<String> ostatuArray = new ArrayList<String>();

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
        startActivity(intent);
        intent.putExtra("KEY", ostatuArray.get(0));
        intent.putExtra("KEY2", ostatuArray.get(6));

    }

}
