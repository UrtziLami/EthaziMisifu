package kontroladorea;

import java.util.ArrayList;

import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;

import lehena.Ostatuak;



public class XMLManeiatzailea extends DefaultHandler{
	private String balioa = null;
	private Ostatuak alojamendu;


	private ArrayList<Ostatuak> ObjetuLista;

	public XMLManeiatzailea(ArrayList<Ostatuak> objetuenLista) {
		this.ObjetuLista = objetuenLista;
	}

	// Alde baterako aldagaiaren balioa garbitu.
	@Override
	public void startElement(String uri, String localName, String name, Attributes attributes) throws SAXException {

		balioa = null;

		// Elentua <liburua> bada isbn atributua irakurriko dugu
		if (localName.equals("row")) {
			alojamendu = new Ostatuak();
		} 
	}

	@Override
	public void characters(char[] ch, int start, int length) throws SAXException {
		// Balioa aldi baterako aldagai batean gordeko dugu
		balioa = new String(ch, start, length);
	}

	@Override
	public void endElement(String uri, String localName, String name) throws SAXException {
		// Elementuaren arabera gordeko dugu irakurritako balioa dagokion liburu
		// objektuaren propietatean
		switch (localName) {
		case "documentname":
			alojamendu.setIzena(balioa);
			break;
		case "turismdescription":
			balioa.replaceAll("<[^>]*>","");
			alojamendu.setDeskribapena(balioa);
			break;
		case "phonenumber":
			alojamendu.setTelefonoa(balioa);
			break;
		case "tourismemail":			
			alojamendu.setEmail(balioa);
			break;
		case "web":
			alojamendu.setWeb(balioa);
			break;
		case "row":
			ObjetuLista.add(alojamendu);
			break;
		}

	}
}
