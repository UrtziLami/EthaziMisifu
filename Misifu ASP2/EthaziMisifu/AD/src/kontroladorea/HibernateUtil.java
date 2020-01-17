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
	 
	    public static long insertAlojamendu(String name,String deskribapena,String udalerri,String probintzia,String telefonoa,String email,String web) {
	        Session session = factory.openSession();
	        Transaction tx = null;
	        Integer stId = null;
	        try
	        {
	            tx = session.beginTransaction();
	            Ostatuak al = new Ostatuak();
	            
	            al.setIzena(name);
	            al.setDeskribapena(deskribapena);
	            al.setUdalerri(udalerri);
	            al.setProbintzia(probintzia);
	            al.setTelefonoa(telefonoa);
	            al.setEmail(email);
	            al.setWeb(web);
	             
	            stId = (Integer) session.save(al);
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
