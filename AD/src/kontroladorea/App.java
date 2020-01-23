package kontroladorea;

public class App {

	public static void main(String[] args) {
		
		 HibernateUtil.addAllConfigs(); 

			//String url = "https://opendata.euskadi.eus/contenidos/ds_recursos_turisticos/albergues_de_euskadi/opendata/alojamientos.xml";
			//String url2 = "https://opendata.euskadi.eus/contenidos/ds_recursos_turisticos/alojamientos_rurales_euskadi/opendata/alojamientos.xml";
			String url3 = "../AD/XML/alberges.xml";
			String url2 = "../AD/XML/alojamientoRural.xml";
			String url1 = "../AD/XML/camping.xml";
			
			try {
				//fitxategiaIrakurri.mostrarContenido(url);
				//fitxategiaIrakurri.mostrarContenido(url2);

				fitxategiaIrakurri.igoFitzategiaXML(url3);
				fitxategiaIrakurri.igoFitzategiaXML(url2);
				fitxategiaIrakurri.igoFitzategiaXML(url1);
				
			} catch (Exception e) {

				e.printStackTrace();
			}
	  
	}
	
	
}
