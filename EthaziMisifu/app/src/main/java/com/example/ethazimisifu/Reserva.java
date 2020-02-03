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

import android.app.DatePickerDialog;
import android.content.Intent;
import android.os.AsyncTask;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import java.io.IOException;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.List;

public class Reserva extends AppCompatActivity {

    private int mYear, mMonth, mDay;

    private TextView nombre;

    private EditText txtDate, txtDate2;

    private String izena, id;

    private Button btnReserva;

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
        btnReserva = (Button) findViewById(R.id.btnReserva);
        btnReserva.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                InsertData(izena, 2, txtDate.getText().toString(), txtDate2.getText().toString());

                Intent intent = new Intent();
                intent.setClass(getApplicationContext(), MainActivity.class);
                startActivity(intent);

            }
        });

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

                        txtDate2.setText(dayOfMonth + "-" + (monthOfYear + 1) + "-" + year);

                    }
                }, mYear, mMonth, mDay);
        datePickerDialog.getDatePicker().setMinDate(Calendar.getInstance().getTime().getTime());
        datePickerDialog.show();
    }

    public void InsertData(final String nombre, final int user, final String sartu, final String atera){
        if (!sartu.equals("") && !atera.equals("")) {
            class SendPostReqAsyncTask extends AsyncTask<String, Void, String> {
                @Override
                protected String doInBackground(String... params) {

                    List<BasicNameValuePair> nameValuePairs = new ArrayList<>();

                    nameValuePairs.add(new BasicNameValuePair("idErreserba", null));

                    try {
                        nameValuePairs.add(new BasicNameValuePair("Ostatuak_sinadura", nombre));
                        nameValuePairs.add(new BasicNameValuePair("Erabiltzaileak_idBezeroak", Integer.toString(2)));
                        nameValuePairs.add(new BasicNameValuePair("sartuData", sartu));
                        nameValuePairs.add(new BasicNameValuePair("ateraData", atera));

                    } catch (Exception e) {
                        e.printStackTrace();
                    }

                    try {
                        HttpClient httpClient = new DefaultHttpClient();

                        HttpPost httpPost = new HttpPost("http://192.168.13.33/misifu/insertReserva.php");

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

                    Toast.makeText(getApplicationContext(), "Se ha hecho la reserva con exito", Toast.LENGTH_LONG).show();

                }
            }

            SendPostReqAsyncTask sendPostReqAsyncTask = new SendPostReqAsyncTask();

            sendPostReqAsyncTask.execute(null, nombre, Integer.toString(2), sartu, atera);

        } else {
            Toast.makeText(getApplicationContext(), "No se permiten campos vacios", Toast.LENGTH_LONG).show();
        }

    }


}
