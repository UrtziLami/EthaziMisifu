package com.example.ethazimisifu;

import androidx.appcompat.app.AppCompatActivity;

import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.widget.ScrollView;
import android.widget.TextView;

public class VerOstatu extends AppCompatActivity {

    private TextView nombre, mota, ubicacion, telefono, web;
    private ScrollView descripcion;
    private String value, provincia, municipio;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ver_ostatu);

        nombre = (TextView) findViewById(R.id.txtNombre);
        descripcion = (ScrollView) findViewById(R.id.scDescripcion);
        mota = (TextView) findViewById(R.id.txtOstatuMota);
        ubicacion = (TextView) findViewById(R.id.txtUbicacion);
        telefono = (TextView) findViewById(R.id.txtTelefono);
        web = (TextView) findViewById(R.id.txtWeb);

        Bundle extras = getIntent().getExtras();
        if(extras !=null) {
            value = extras.getString("KEY");
        }

        //rellenarTextos(value);

    }

    /*public void rellenarTextos(String value){
        AdminSQLiteOpenHelper admin = new AdminSQLiteOpenHelper(this,
                "administracion", null, 1);

        SQLiteDatabase bd = admin.getWritableDatabase();
        Cursor fila = bd.rawQuery("Select * from tareas where nombre like '" + value + "'", null);

        nombre.setText(value);
        if(fila != null && fila.moveToFirst()){
            descripcion.setText(String.valueOf(fila.getString(1)));
            fecha.setText(String.valueOf(fila.getString(2)));
            prioridad.setText(String.valueOf(fila.getString(3)));
            switch(String.valueOf(fila.getString(2))) {
                case "Urgente":
                    fecha.setTextColor(0xffff0000);
                    break;
                case "Alta":
                    fecha.setTextColor(0xFFFF631C);
                    break;
                case "Media":
                    fecha.setTextColor(0xFFFFE135);
                    break;
                case "Baja":
                    fecha.setTextColor(0xFF006B3C);
                    break;
                default:
                    break;
            }

            coste.setText(String.valueOf(fila.getString(4)));
        }

    }*/

}
