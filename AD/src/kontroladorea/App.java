package kontroladorea;

import java.util.Date;

public class App {

  //  @SuppressWarnings("deprecation")
    public void main(String[] args) 
    {
        HibernateUtil.addAllConfigs();
       
        long one = HibernateUtil.insertAlojamendu(1," Mark Johnson", 58, new Date("08/11/2008"));
        long two = HibernateUtil.insertAlojamendu(2, "Jill Rhodes", 95, new Date("08/08/2008"));      
    }
     

}
