package pl.opole.uni.springBootJSF.model;

import java.util.Objects;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "kierunek")
public class Kierunek {
	
	public Kierunek() {
		
	}
		@Id
	    @GeneratedValue(strategy = GenerationType.AUTO)
	private Long id;
	private String Nazwa;
	private String Symbol;
	

	
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
	
	@Override
	public int hashCode() {
		return Objects.hash(id);
	}
	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		Kierunek other = (Kierunek) obj;
		return Objects.equals(id, other.id);
	}
	
}
