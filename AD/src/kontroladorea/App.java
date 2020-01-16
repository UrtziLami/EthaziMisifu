package kontroladorea;

public class App {

	public static void main(String[] args) {
		
		 HibernateUtil.addAllConfigs(); 

			//String url = "https://opendata.euskadi.eus/contenidos/ds_recursos_turisticos/albergues_de_euskadi/opendata/alojamientos.xml";
			//String url2 = "https://opendata.euskadi.eus/contenidos/ds_recursos_turisticos/alojamientos_rurales_euskadi/opendata/alojamientos.xml";
			String url3 = "https://opendata.euskadi.eus/contenidos/ds_recursos_turisticos/campings_de_euskadi/opendata/alojamientos.xml";
			
			try {
				//fitxategiaIrakurri.mostrarContenido(url);
				//fitxategiaIrakurri.mostrarContenido(url2);
				fitxategiaIrakurri.mostrarContenido(url3);
				
			} catch (Exception e) {

				e.printStackTrace();
			}
	  
	}
	
	
}
