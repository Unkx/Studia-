package pl.opole.uni.springBootJSF.model;

import java.util.Objects;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "game")
public class Game {
	
	public Game() {
		
	}
		
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long id;
	private String nazwa;
	private String symbol;
	private Long cena;
	private Long wiek;
	private int kategoriawiekowa;
	public Long getId() {
		return id;
	}
	public void setId(Long id) {
		this.id = id;
	}
	public String getNazwa() {
		return nazwa;
	}
	public void setNazwa(String nazwa) {
		this.nazwa = nazwa;
	}
	public String getSymbol() {
		return symbol;
	}
	public void setSymbol(String symbol) {
		this.symbol = symbol;
	}
	public Long getCena() {
		return cena;
	}
	public void setCena(Long cena) {
		this.cena = cena;
	}
	public Long getWiek() {
		return wiek;
	}
	public void setWiek(Long wiek) {
		this.wiek = wiek;
	}
	public int getKategoriawiekowa() {
		return kategoriawiekowa;
	}
	public void setKategoriawiekowa(int kategoriawiekowa) {
		this.kategoriawiekowa = kategoriawiekowa;
	}
	@Override
	public int hashCode() {
		return Objects.hash(cena, id, kategoriawiekowa, nazwa, symbol, wiek);
	}
	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		Game other = (Game) obj;
		return Objects.equals(cena, other.cena) && Objects.equals(id, other.id)
				&& kategoriawiekowa == other.kategoriawiekowa && Objects.equals(nazwa, other.nazwa)
				&& Objects.equals(symbol, other.symbol) && Objects.equals(wiek, other.wiek);
	}
}
	