package com.example.ethazimisifu;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.MenuItem;
import android.view.View;

public class Menu extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu);
        setTitle("Menu");

    }

    @Override
    public boolean onCreateOptionsMenu(android.view.Menu menu) {
        getMenuInflater().inflate(R.menu.actionbar, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        int id = item.getItemId();

        if(id == R.id.spanish){

        } else if (id == R.id.basque) {

        } else if (id == R.id.english) {

        }

        return true;
    }

    public void abrirMapa(View view){
        Intent intent = new Intent();
        intent.setClass(getApplicationContext(), LocationComponentActivity.class);
        startActivity(intent);
    }

    public void abrirLista(View view){
        Intent intent = new Intent();
        intent.setClass(getApplicationContext(), Lista.class);
        startActivity(intent);
    }


}
