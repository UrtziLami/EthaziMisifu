package lehena;
// Generated 16-ene-2020 8:27:48 by Hibernate Tools 5.4.7.Final

import java.util.HashSet;
import java.util.Set;

/**
 * Ostatuak generated by hbm2java
 */
public class Ostatuak implements java.io.Serializable {

	private Integer idAlojamenduak;
	private String izena;
	private String deskribapena;
	private String udalerri;
	private String probintzia;
	private String email;
	private String telefonoa;
	private String web;


	public Ostatuak() {
	}

	public Ostatuak(String izena, String deskribapena, String udalerri, String probintzia, String email,
			String telefonoa, String web) {
		this.izena = izena;
		this.deskribapena = deskribapena;
		this.udalerri = udalerri;
		this.probintzia = probintzia;
		this.email = email;
		this.telefonoa = telefonoa;
		this.web = web;

	}

	public Integer getIdAlojamenduak() {
		return this.idAlojamenduak;
	}

	public void setIdAlojamenduak(Integer idAlojamenduak) {
		this.idAlojamenduak = idAlojamenduak;
	}

	public String getIzena() {
		return this.izena;
	}

	public void setIzena(String izena) {
		this.izena = izena;
	}

	public String getDeskribapena() {
		return this.deskribapena;
	}

	public void setDeskribapena(String deskribapena) {
		this.deskribapena = deskribapena;
	}

	public String getUdalerri() {
		return this.udalerri;
	}

	public void setUdalerri(String udalerri) {
		this.udalerri = udalerri;
	}

	public String getProbintzia() {
		return this.probintzia;
	}

	public void setProbintzia(String probintzia) {
		this.probintzia = probintzia;
	}

	public String getEmail() {
		return this.email;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public String getTelefonoa() {
		return this.telefonoa;
	}

	public void setTelefonoa(String telefonoa) {
		this.telefonoa = telefonoa;
	}

	public String getWeb() {
		return this.web;
	}

	public void setWeb(String web) {
		this.web = web;
	}

}
