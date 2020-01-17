package kontroladorea;

import java.io.IOException;
import java.io.InputStreamReader;
import java.net.URL;
import java.util.ArrayList;

import javax.net.ssl.HttpsURLConnection;
import javax.net.ssl.SSLContext;
import javax.net.ssl.TrustManager;
import javax.net.ssl.X509TrustManager;
import javax.swing.JOptionPane;

import org.xml.sax.InputSource;
import org.xml.sax.SAXException;
import org.xml.sax.XMLReader;
import org.xml.sax.helpers.XMLReaderFactory;

import lehena.Ostatuak;

public class fitxategiaIrakurri {
	
	public static void mostrarContenido(String url) throws Exception {

		TrustManager[] trustAllCerts = new TrustManager[] { new X509TrustManager() {

			public java.security.cert.X509Certificate[] getAcceptedIssuers() {
				return null;
			}

			public void checkClientTrusted(java.security.cert.X509Certificate[] certs, String authType) {
				// No need to implement.
			}

			public void checkServerTrusted(java.security.cert.X509Certificate[] certs, String authType) {
				// No need to implement.
			}
		} };

				// Install the all-trusting trust manager
		try {
			SSLContext sc = SSLContext.getInstance("SSL");
			sc.init(null, trustAllCerts, new java.security.SecureRandom());
			HttpsURLConnection.setDefaultSSLSocketFactory(sc.getSocketFactory());
			URL ficheroUrl = new URL(url);
			
			ArrayList<Ostatuak> a=irakurriFitzategiaXML(new InputStreamReader(ficheroUrl.openStream()));
			for (Ostatuak elem: a) {
				HibernateUtil.insertAlojamendu(elem.getIzena(), elem.getDeskribapena(), elem.getUdalerri(), elem.getProbintzia(), elem.getTelefonoa(), elem.getEmail(), elem.getWeb());
			}
				
			
		} catch (Exception e) {
			System.out.println(e);
		
		}
	}
	public static ArrayList<Ostatuak> irakurriFitzategiaXML(InputStreamReader inputSteam) {
		ArrayList<Ostatuak> objetuenLista = new ArrayList<Ostatuak>();
		try {
			// Sortu Faktoria
			XMLReader reader = XMLReaderFactory.createXMLReader();
			// Lotu maneiatzailearekin
			reader.setContentHandler( new XMLManeiatzailea(objetuenLista));
			// Prozesatu liburuen fitxategia
			reader.parse(new InputSource(inputSteam));
			// Badaukagu kargatuta liburuak eta orain inprimatuko ditugu

		} catch (SAXException e) {
			JOptionPane.showMessageDialog(null, "SAX EXZEPZIOA" );
		
			JOptionPane.showMessageDialog(null, e.getMessage());
		} catch (IOException e) {
			JOptionPane.showMessageDialog(null, "XML FITXATEGIA TXARTO DAGO" );
			e.printStackTrace();
		}
		System.out.println();
		return objetuenLista;
	}
}
