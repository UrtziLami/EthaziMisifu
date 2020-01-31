package com.example.ethazimisifu;

import androidx.appcompat.app.AppCompatActivity;

import android.app.DatePickerDialog;
import android.os.Bundle;
import android.view.View;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.Calendar;

public class Reserva extends AppCompatActivity {

    private int mYear, mMonth, mDay;

    private TextView nombre;

    private EditText txtDate, txtDate2;

    private String izena, id;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        setContentView(R.layout.activity_reserva);
        super.onCreate(savedInstanceState);

        nombre = (TextView) findViewById(R.id.txtNombre);

        txtDate = (EditText)findViewById(R.id.etFecha);
        txtDate.setEnabled(false);

        txtDate2 = (EditText)findViewById(R.id.etFecha2);
        txtDate2.setEnabled(false);

        Bundle extras = getIntent().getExtras();
        if(extras !=null) {
            izena = extras.getString("KEY");
        }

        extras = getIntent().getExtras();
        if(extras !=null) {
            id = extras.getString("KEY2");
        }

        nombre.setText(izena);

    }

    public void abrirCalendar(View v){
        final Calendar c = Calendar.getInstance();
        mYear = c.get(Calendar.YEAR);
        mMonth = c.get(Calendar.MONTH);
        mDay = c.get(Calendar.DAY_OF_MONTH);


        DatePickerDialog datePickerDialog = new DatePickerDialog(this,
                new DatePickerDialog.OnDateSetListener() {

                    @Override
                    public void onDateSet(DatePicker view, int year,
                                          int monthOfYear, int dayOfMonth) {

                        txtDate.setText(dayOfMonth + "-" + (monthOfYear + 1) + "-" + year);

                    }
                }, mYear, mMonth, mDay);
        datePickerDialog.getDatePicker().setMinDate(Calendar.getInstance().getTime().getTime());
        datePickerDialog.show();
    }

    public void abrirCalendar2(View v){
        final Calendar c = Calendar.getInstance();
        mYear = c.get(Calendar.YEAR);
        mMonth = c.get(Calendar.MONTH);
        mDay = c.get(Calendar.DAY_OF_MONTH);


        DatePickerDialog datePickerDialog = new DatePickerDialog(this,
                new DatePickerDialog.OnDateSetListener() {

                    @Override
                    public void onDateSet(DatePicker view, int year,
                                          int monthOfYear, int dayOfMonth) {

                        txtDate.setText(dayOfMonth + "-" + (monthOfYear + 1) + "-" + year);

                    }
                }, mYear, mMonth, mDay);
        datePickerDialog.getDatePicker().setMinDate(Calendar.getInstance().getTime().getTime());
        datePickerDialog.show();
    }

}
