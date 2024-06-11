package pl.opole.uni.springBootJSF.model;

public class PozycjaMenu {

	private String nazwa;
	private String tytul;
	private String strona;
	
	public PozycjaMenu() {
		
	}
	
	public PozycjaMenu(String nazwa, String tytul, String strona) {
		super();
		this.nazwa = nazwa;
		this.tytul = tytul;
		this.strona = strona;
	}

	public String getNazwa() {
		return nazwa;
	}

	public void setNazwa(String nazwa) {
		this.nazwa = nazwa;
	}

	public String getTytul() {
		return tytul;
	}

	public void setTytuł(String tytul) {
		this.tytul = tytul;
	}

	public String getStrona() {
		return strona;
	}

	public void setStrona(String strona) {
		this.strona = strona;
	}
	
	
	
}
