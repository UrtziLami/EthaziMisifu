package com.example.ethazimisifu;

import android.content.Intent;
import android.os.Bundle;
import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.mapbox.android.core.permissions.PermissionsListener;
import com.mapbox.android.core.permissions.PermissionsManager;
import com.mapbox.mapboxsdk.Mapbox;
import com.mapbox.mapboxsdk.annotations.Marker;
import com.mapbox.mapboxsdk.annotations.MarkerOptions;
import com.mapbox.mapboxsdk.geometry.LatLng;
import com.mapbox.mapboxsdk.location.LocationComponent;
import com.mapbox.mapboxsdk.location.LocationComponentActivationOptions;
import com.mapbox.mapboxsdk.location.modes.CameraMode;
import com.mapbox.mapboxsdk.location.modes.RenderMode;
import com.mapbox.mapboxsdk.maps.MapView;
import com.mapbox.mapboxsdk.maps.MapboxMap;
import com.mapbox.mapboxsdk.maps.OnMapReadyCallback;
import com.mapbox.mapboxsdk.maps.Style;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

/**
 * Use the LocationComponent to easily add a device location "puck" to a Mapbox map.
 */
public class LocationComponentActivity extends AppCompatActivity implements
        OnMapReadyCallback, PermissionsListener {

    private PermissionsManager permissionsManager;
    private MapboxMap mapboxMap;
    private MapView mapView;
    private ArrayList<Ostatuak> ostatuak = new ArrayList<Ostatuak>();
    private ArrayList<String> ostatuArray = new ArrayList<String>();
    private ArrayList<MarkerOptions> allMarker = new ArrayList<MarkerOptions>();
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setTitle("Mapa");
// Mapbox access token is configured here. This needs to be called either in your application
// object or in the same activity which contains the mapview.
        Mapbox.getInstance(this, "pk.eyJ1IjoiZXJsb3IiLCJhIjoiY2s1M3VydnUxMDdsNjNtcGJtdmgycGw4MiJ9.PNr5NoOKxlMQmy3GQxcGLA");
// This contains the MapView in XML and needs to be called after the access token is configured.
        setContentView(R.layout.activity_location_component);

        mapView = findViewById(R.id.mapView);
        mapView.onCreate(savedInstanceState);
        mapView.getMapAsync(this);

        StringRequest stringRequest = new StringRequest(Request.Method.POST, "http://192.168.13.33/misifu/selectOstuatuak.php", new com.android.volley.Response.Listener<String>() {
            @Override
            public void onResponse(String response) {
                ostatuak = Consultas.ostatuLista(response);
                addMarkers(ostatuak);


                mapboxMap.setOnMarkerClickListener(new MapboxMap.OnMarkerClickListener() {
                    @Override
                    public boolean onMarkerClick(@NonNull Marker marker) {
                        LatLng point= marker.getPosition();
                        Ostatuak ostatu;
                        double Latitude= point.getLatitude();
                        double longitude= point.getLongitude();
                        /*for(Ostatuak os : ostatuak) {
                            if(os.getLongitudea()==Latitude && os.getLatitudea()== longitude) {
                                ostatu = os;
                                Intent intent = new Intent();
                                intent.setClass(getApplicationContext(), VerOstatu.class);
                                intent.putExtra("KEY", (Serializable) ostatu);
                                startActivity(intent);
                                break;
                            }
                        }*/

                        for(int i = 0; i < ostatuak.size(); i++){
                            if(ostatuak.get(i).getLongitudea() == Latitude && ostatuak.get(i).getLatitudea()== longitude){

                                ostatuArray.add(ostatuak.get(i).getIzena());
                                ostatuArray.add(ostatuak.get(i).getOstatuMota());
                                ostatuArray.add(ostatuak.get(i).getUdalerria() + ", " + ostatuak.get(i).getProbintzia());
                                ostatuArray.add(ostatuak.get(i).getDeskribapena());
                                ostatuArray.add(ostatuak.get(i).getTelefonoa());
                                ostatuArray.add(ostatuak.get(i).getWeb());
                                ostatuArray.add(ostatuak.get(i).getId());
                                ostatuArray.add(ostatuak.get(i).getEmail());
                                ostatuArray.add(ostatuak.get(i).getEmail());

                                Intent intent = new Intent();
                                intent.setClass(getApplicationContext(), VerOstatu.class);
                                intent.putExtra("KEY", ostatuArray);
                                startActivity(intent);
                                break;

                            }
                        }

                        return true;
                    }
                });


            }

        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {

            }
        });
        RequestQueue requestQueue = Volley.newRequestQueue(this);
        requestQueue.add(stringRequest);
    }


    @Override
    public void onMapReady(@NonNull final MapboxMap mapboxMap) {
        LocationComponentActivity.this.mapboxMap = mapboxMap;

        mapboxMap.setStyle(new Style.Builder().fromUri("mapbox://styles/mapbox/cjerxnqt3cgvp2rmyuxbeqme7"),
                new Style.OnStyleLoaded() {
                    @Override
                    public void onStyleLoaded(@NonNull Style style) {
                        enableLocationComponent(style);
                    }
                });
    }

    @SuppressWarnings( {"MissingPermission"})
    private void enableLocationComponent(@NonNull Style loadedMapStyle) {
// Check if permissions are enabled and if not request
        if (PermissionsManager.areLocationPermissionsGranted(this)) {

// Get an instance of the component
            LocationComponent locationComponent = mapboxMap.getLocationComponent();

// Activate with options
            locationComponent.activateLocationComponent(
                    LocationComponentActivationOptions.builder(this, loadedMapStyle).build());

// Enable to make component visible
            locationComponent.setLocationComponentEnabled(true);

// Set the component's camera mode
            locationComponent.setCameraMode(CameraMode.TRACKING);

// Set the component's render mode
            locationComponent.setRenderMode(RenderMode.COMPASS);
        } else {
            permissionsManager = new PermissionsManager(this);
            permissionsManager.requestLocationPermissions(this);
        }
    }
    public void addMarkers(ArrayList<Ostatuak> OstatuenLista) {
        allMarker.clear();
        for(Ostatuak os : OstatuenLista) {
            MarkerOptions marker = new MarkerOptions()
                    .position(new LatLng(os.getLongitudea(), os.getLatitudea()))
                    .title(os.getIzena())
                    .snippet(os.getDeskribapena());
            mapboxMap.addMarker(marker);
            allMarker.add(marker);
        }

    }


    @Override
    public void onRequestPermissionsResult(int requestCode, @NonNull String[] permissions, @NonNull int[] grantResults) {
        permissionsManager.onRequestPermissionsResult(requestCode, permissions, grantResults);
    }

    @Override
    public void onExplanationNeeded(List<String> permissionsToExplain) {
        Toast.makeText(this, R.string.user_location_permission_explanation, Toast.LENGTH_LONG).show();
    }

    @Override
    public void onPermissionResult(boolean granted) {
        if (granted) {
            mapboxMap.getStyle(new Style.OnStyleLoaded() {
                @Override
                public void onStyleLoaded(@NonNull Style style) {
                    enableLocationComponent(style);
                }
            });
        } else {
            Toast.makeText(this, R.string.user_location_permission_not_granted, Toast.LENGTH_LONG).show();
            finish();
        }
    }

    @Override
    @SuppressWarnings( {"MissingPermission"})
    protected void onStart() {
        super.onStart();
        mapView.onStart();
    }

    @Override
    protected void onResume() {
        super.onResume();
        mapView.onResume();
    }

    @Override
    protected void onPause() {
        super.onPause();
        mapView.onPause();
    }

    @Override
    protected void onStop() {
        super.onStop();
        mapView.onStop();
    }

    @Override
    protected void onSaveInstanceState(Bundle outState) {
        super.onSaveInstanceState(outState);
        mapView.onSaveInstanceState(outState);
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        mapView.onDestroy();
    }

    @Override
    public void onLowMemory() {
        super.onLowMemory();
        mapView.onLowMemory();
    }

}
