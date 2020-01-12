package lehena;
// Generated 12-ene-2020 13:29:37 by Hibernate Tools 5.4.7.Final

import java.util.HashSet;
import java.util.Set;

/**
 * Erabiltzaileak generated by hbm2java
 */
public class Erabiltzaileak implements java.io.Serializable {

	private int idBezeroak;
	private String izenAbizena;
	private String pasahitza;
	private Set reservases = new HashSet(0);

	public Erabiltzaileak() {
	}

	public Erabiltzaileak(int idBezeroak) {
		this.idBezeroak = idBezeroak;
	}

	public Erabiltzaileak(int idBezeroak, String izenAbizena, String pasahitza, Set reservases) {
		this.idBezeroak = idBezeroak;
		this.izenAbizena = izenAbizena;
		this.pasahitza = pasahitza;
		this.reservases = reservases;
	}

	public int getIdBezeroak() {
		return this.idBezeroak;
	}

	public void setIdBezeroak(int idBezeroak) {
		this.idBezeroak = idBezeroak;
	}

	public String getIzenAbizena() {
		return this.izenAbizena;
	}

	public void setIzenAbizena(String izenAbizena) {
		this.izenAbizena = izenAbizena;
	}

	public String getPasahitza() {
		return this.pasahitza;
	}

	public void setPasahitza(String pasahitza) {
		this.pasahitza = pasahitza;
	}

	public Set getReservases() {
		return this.reservases;
	}

	public void setReservases(Set reservases) {
		this.reservases = reservases;
	}

}
