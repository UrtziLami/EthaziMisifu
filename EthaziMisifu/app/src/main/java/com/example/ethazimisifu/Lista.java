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
import android.widget.TextView;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;

import java.util.ArrayList;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

public class Lista extends AppCompatActivity {

    private ArrayList<String> tareas = new ArrayList<String>();
    private ArrayList<Ostatuak> ostatuak = new ArrayList<Ostatuak>();
    private ArrayAdapter adapter;
    private ListView lista;
    private AdapterView.AdapterContextMenuInfo info;
    private EditText etBuscar;
    private ArrayList<String> ostatuArray = new ArrayList<String>();
    private String izena, kodea;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_lista);
        setTitle("Lista");
        etBuscar = (EditText) findViewById(R.id.etBuscar);

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

                                                     for(int i = 0; i < ostatuak.size(); i++){
                                                         if(ostatuak.get(i).getIzena().equals(tareas.get(position))){

                                                             ostatuArray.add(ostatuak.get(i).getIzena());
                                                             ostatuArray.add(ostatuak.get(i).getOstatuMota());
                                                             ostatuArray.add(ostatuak.get(i).getUdalerria() + ", " + ostatuak.get(i).getProbintzia());
                                                             ostatuArray.add(ostatuak.get(i).getDeskribapena());
                                                             ostatuArray.add(ostatuak.get(i).getTelefonoa());
                                                             ostatuArray.add(ostatuak.get(i).getWeb());
                                                             ostatuArray.add(ostatuak.get(i).getId());
                                                             ostatuArray.add(ostatuak.get(i).getEmail());
                                                             ostatuArray.add(ostatuak.get(i).getEmail());

                                                         }
                                                     }

                                                     Intent intent = new Intent(getApplicationContext(), VerOstatu.class);
                                                     intent.putExtra("KEY", ostatuArray);
                                                     intent.putExtra("KEY2", ostatuArray);
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
        } else if (id == R.id.Agroturismos) {
            tareas.clear();
            for(int i = 0; i < ostatuak.size(); i++){
                if(ostatuak.get(i).getOstatuMota().equals("Agroturismos")){
                    tareas.add(String.valueOf(ostatuak.get(i).getIzena()));
                }
            }
            lista = (ListView)findViewById(R.id.lista);
            adapter = new ArrayAdapter<String>(getApplicationContext(), android.R.layout.simple_selectable_list_item, tareas);
            lista.setAdapter(adapter);
            adapter.notifyDataSetChanged();
        }

        return true;
    }

    @Override
    public boolean onContextItemSelected(@NonNull MenuItem item) {
        info = (AdapterView.AdapterContextMenuInfo) item.getMenuInfo();
        switch (item.getItemId()) {
            case R.id.mapa:
                Intent intent = new Intent(this, Menu.class);
                //intent.putExtra("KEY", tareas.get(info.position));
                startActivity(intent);
                return true;
            case R.id.reserva:

                for(int i = 0; i < ostatuak.size(); i++){
                    if(ostatuak.get(i).getIzena().equals(tareas.get(info.position))){

                        izena = ostatuak.get(i).getIzena();
                        kodea = ostatuak.get(i).getId();

                    }
                }

                Intent reserva = new Intent(getApplicationContext(), Reserva.class);
                reserva.putExtra("KEY", izena);
                reserva.putExtra("KEY2", kodea);
                startActivity(reserva);
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

}