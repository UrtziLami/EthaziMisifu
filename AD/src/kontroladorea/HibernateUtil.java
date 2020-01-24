package kontroladorea;

import org.hibernate.HibernateException;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.Transaction;
import org.hibernate.boot.registry.StandardServiceRegistryBuilder;
import org.hibernate.cfg.Configuration;
import org.hibernate.service.ServiceRegistry;

import lehena.Ostatuak;
public class HibernateUtil {
	 private static SessionFactory factory;
	    private static ServiceRegistry serviceRegistry;
	 
	
	    public static void addAllConfigs() {
	        Configuration config = new Configuration();
	        config.configure();
	        config.addAnnotatedClass(Ostatuak.class);
	        config.addResource("./lehena/Ostatuak.hbm.xml");
	        serviceRegistry = new StandardServiceRegistryBuilder().applySettings(config.getProperties()).build();
	        factory = config.buildSessionFactory(serviceRegistry);
	    }
	 
	    public static String insertAlojamendu(String sinadura, String name,String deskribapena,String udalerri,String probintzia,String email,String telefonoa,String web,String ostatuMota, Double longitude, Double latitude) {
	        Session session = factory.openSession();
	        Transaction tx = null;
	        String stId = null;
	        try
	        {
	            tx = session.beginTransaction();
	            Ostatuak al = new Ostatuak();
	            al.setSinadura(sinadura);
	            al.setIzena(name);
	            al.setDeskribapena(deskribapena);
	            al.setUdalerri(udalerri);
	            al.setProbintzia(probintzia);
	            al.setTelefonoa(telefonoa);
	            al.setEmail(email);
	            al.setWeb(web);
	            al.setLongitudea(longitude);
	            al.setLatitudea(latitude);
	            al.setOstatuMota(ostatuMota);
	            stId = (String) session.save(al);
	            tx.commit();
	        } 
	        catch (HibernateException ex)
	        {
	            if(tx != null)
	                tx.rollback();
	        }
	        finally
	        {
	            session.close();
	        }
	         
	        return stId;
	    }
}
