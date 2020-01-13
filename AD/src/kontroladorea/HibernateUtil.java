package kontroladorea;

import java.util.Date;

import org.hibernate.HibernateException;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.Transaction;
import org.hibernate.boot.registry.StandardServiceRegistryBuilder;
import org.hibernate.cfg.Configuration;
import org.hibernate.service.ServiceRegistry;

import lehena.Alojamenduak;

public class HibernateUtil {

	    private static SessionFactory factory;
	    private static ServiceRegistry serviceRegistry;
	 
	
	    public static void addAllConfigs() {
	        Configuration config = new Configuration();
	        config.configure();
	        config.addAnnotatedClass(Alojamenduak.class);
	        config.addResource("Student.hbm.xml");
	        serviceRegistry = new StandardServiceRegistryBuilder().applySettings(config.getProperties()).build();
	        factory = config.buildSessionFactory(serviceRegistry);
	    }
	 
	    public static long insertAlojamendu(int id, String name, int marks, Date joindate) {
	        Session session = factory.openSession();
	        Transaction tx = null;
	        Integer stId = null;
	        try
	        {
	            tx = session.beginTransaction();
	            Alojamenduak al = new Alojamenduak();
	            
	            al.setIzena(name);
	            al.setUdalerri(udalerri);
	            al.setDeskribapena(deskribapena);
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

