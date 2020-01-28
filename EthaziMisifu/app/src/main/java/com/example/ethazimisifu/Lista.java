package com.example.ethazimisifu;

import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.SharedPreferences;
import android.graphics.Color;
import android.os.Bundle;
import android.util.Log;
import android.view.ContextMenu;
import android.view.LayoutInflater;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Spinner;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;

import java.util.ArrayList;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

public class Lista extends AppCompatActivity {

    private ArrayList<String> tareas = new ArrayList<String>();
    private ArrayList<Ostatuak> ostatuak = new ArrayList<Ostatuak>();
    private ArrayAdapter adapter;
    private ListView lista;
    private AdapterView.AdapterContextMenuInfo info;
    private View lastTouchedView;
    private Button btnBuscar, btnAlbergue, btnCamping, btnRural;
    private EditText etBuscar;
    private Spinner spProbintzia, spUdalerria, spMota;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_lista);
        etBuscar = (EditText) findViewById(R.id.etBuscar);
        setTitle("Lista");
        btnAlbergue = (Button) findViewById(R.id.btnMota1);
        btnCamping = (Button) findViewById(R.id.btnMota2);
        btnRural = (Button) findViewById(R.id.btnMota3);

        StringRequest stringRequest = new StringRequest(Request.Method.POST, "http://192.168.13.33/misifu/selectOstuatuak.php", new com.android.volley.Response.Listener<String>() {
            @Override
            public void onResponse(String response) {
                ostatuak = Consultas.ostatuLista(response);
                verTareas(ostatuak);

                lista = (ListView)findViewById(R.id.lista);
                adapter = new ArrayAdapter<String>(getApplicationContext(), android.R.layout.simple_selectable_list_item, tareas);
                lista.setAdapter(adapter);

                registerForContextMenu(lista);

                lista.setOnItemClickListener(new AdapterView.OnItemClickListener() {
                                                 @Override
                                                 public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

                                                     Intent intent = new Intent(getApplicationContext(), Menu.class);
                                                     //intent.putExtra("KEY", tareas.get(position));
                                                     startActivity(intent);
                                                 }
                                             }

                );
            }

        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                Toast.makeText(Lista.this, error.toString(), Toast.LENGTH_SHORT).show();
            }
        });

        RequestQueue requestQueue = Volley.newRequestQueue(this);
        requestQueue.add(stringRequest);

    }

    public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo menuInfo) {
        super.onCreateContextMenu(menu, v, menuInfo);
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.menu, menu);
    }

    public boolean onCreateOptionsMenu(android.view.Menu menu) {
        getMenuInflater().inflate(R.menu.filtro, menu);
        return true;
    }


    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        int id = item.getItemId();

        if(id == R.id.albergues){
            tareas.clear();
            for(int i = 0; i < ostatuak.size(); i++){
                Log.d("rural", ostatuak.get(i).getIzena());
                if(ostatuak.get(i).getOstatuMota().matches("Albergues")){
                    tareas.add(String.valueOf(ostatuak.get(i).getIzena()));
                }
            }
                lista = (ListView)findViewById(R.id.lista);
                adapter = new ArrayAdapter<String>(getApplicationContext(), android.R.layout.simple_selectable_list_item, tareas);
                lista.setAdapter(adapter);
                adapter.notifyDataSetChanged();
        } else if (id == R.id.rural) {
            tareas.clear();
            for(int i = 0; i < ostatuak.size(); i++){
                if(ostatuak.get(i).getOstatuMota().equals("Casas Rurales")){
                    tareas.add(String.valueOf(ostatuak.get(i).getIzena()));
                }
            }
            lista = (ListView)findViewById(R.id.lista);
            adapter = new ArrayAdapter<String>(getApplicationContext(), android.R.layout.simple_selectable_list_item, tareas);
            lista.setAdapter(adapter);
            adapter.notifyDataSetChanged();
        } else if (id == R.id.campings) {
            tareas.clear();
            for(int i = 0; i < ostatuak.size(); i++){
                if(ostatuak.get(i).getOstatuMota().equals("Campings")){
                    tareas.add(String.valueOf(ostatuak.get(i).getIzena()));
                }
            }
            lista = (ListView)findViewById(R.id.lista);
            adapter = new ArrayAdapter<String>(getApplicationContext(), android.R.layout.simple_selectable_list_item, tareas);
            lista.setAdapter(adapter);
            adapter.notifyDataSetChanged();
        } else if (id == R.id.search) {
            dialogoContrasena();
        }

        return true;
    }

    @Override
    public boolean onContextItemSelected(@NonNull MenuItem item) {
        info = (AdapterView.AdapterContextMenuInfo) item.getMenuInfo();
        switch (item.getItemId()) {
            case R.id.modificar:
                Intent intent = new Intent(this, Menu.class);
                //intent.putExtra("KEY", tareas.get(info.position));
                startActivity(intent);
                return true;
            case R.id.borrar:
                DialogInterface.OnClickListener dialogClickListener = new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        switch (which){
                            case DialogInterface.BUTTON_POSITIVE:
                                /*SQLiteDatabase bd = admin.getWritableDatabase();
                                String nombre = (String) lista.getItemAtPosition(info.position);
                                bd.delete("tareas", "nombre like '" + nombre + "'", null);
                                bd.close();
                                tareas.remove(info.position);
                                adapter.notifyDataSetChanged();*/
                                Toast.makeText(getApplicationContext(), "Borrado", Toast.LENGTH_SHORT).show();
                                break;

                            case DialogInterface.BUTTON_NEGATIVE:
                                //No button clicked
                                break;
                        }
                    }
                };
                AlertDialog.Builder builder = new AlertDialog.Builder(this);
                builder.setMessage("¿Estas seguro que quieres borrar la tarea seleccionada?").setPositiveButton("Si", dialogClickListener)
                        .setNegativeButton("No", dialogClickListener).show();
                return true;
            default:
                return super.onContextItemSelected(item);
        }

    }

    public void verTareas(ArrayList<Ostatuak> ostatuak) {
        for(int i = 0; i < ostatuak.size(); i++){
            tareas.add(String.valueOf(ostatuak.get(i).getIzena()));
        }
    }

    public void volverMenu(View v){
        Intent intent = new Intent(this, Menu.class);
        startActivity(intent);
        finish();
    }

    public void buscar(View view){
        tareas.clear();

        for(int i = 0; i < ostatuak.size(); i++){
            if(ostatuak.get(i).getIzena().toLowerCase().contains(etBuscar.getText().toString().toLowerCase())){
                tareas.add(String.valueOf(ostatuak.get(i).getIzena()));
            }
        }
        lista = (ListView)findViewById(R.id.lista);
        adapter = new ArrayAdapter<String>(getApplicationContext(), android.R.layout.simple_selectable_list_item, tareas);
        lista.setAdapter(adapter);
        adapter.notifyDataSetChanged();
    }

    public void dialogoContrasena() {

        spMota = (Spinner) findViewById(R.id.spMota);
        spProbintzia = (Spinner) findViewById(R.id.spProbintzia);

        LayoutInflater li = LayoutInflater.from(this);
        View promptsView = li.inflate(R.layout.custom_dialogo, null);

        AlertDialog.Builder alertDialogBuilder = new AlertDialog.Builder(this);

        alertDialogBuilder.setView(promptsView);

        alertDialogBuilder
                .setCancelable(false)
                .setPositiveButton("Filtrar",
                        new DialogInterface.OnClickListener() {
                            public void onClick(DialogInterface dialog, int id) {



                            }
                        })
                .setNegativeButton("Cancel",
                        new DialogInterface.OnClickListener() {
                            public void onClick(DialogInterface dialog,int id) {
                                dialog.cancel();
                            }
                        });

        AlertDialog alertDialog = alertDialogBuilder.create();

        alertDialog.show();

        alertDialog.setTitle("Busqueda avanzada");

    }

}
