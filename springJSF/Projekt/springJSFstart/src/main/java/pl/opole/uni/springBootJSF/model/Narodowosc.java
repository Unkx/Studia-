package pl.opole.uni.springBootJSF.model;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;


@Entity
@Table(name = "narodowosc")
public class Narodowosc {

	@Id
    @GeneratedValue(strategy = GenerationType.AUTO)
	private Long id;
    private String Nazwa;
    private String Symbol;
	

	public Narodowosc() {
		
    }

	public Long getId() {
		return id;
	}

	public void setId(Long id) {
		this.id = id;
	}

	public String getNazwa() {
		return Nazwa;
	}

	public void setNazwa(String nazwa) {
		Nazwa = nazwa;
	}

	public String getSymbol() {
		return Symbol;
	}

	public void setSymbol(String symbol) {
		Symbol = symbol;
	}

}
