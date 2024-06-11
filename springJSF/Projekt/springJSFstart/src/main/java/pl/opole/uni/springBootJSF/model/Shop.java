package pl.opole.uni.springBootJSF.model;

import java.util.List;
import java.util.Objects;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

import org.apache.catalina.User;

import antlr.StringUtils;


@Entity
@Table(name = "shop")
public class Shop {
	
	public Shop() {
		
	}
		
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long id;
	private String nazwa;
	private String symbol;
	private Long cena;
	private Long wiek;

    @OneToMany(mappedBy = "shop")
    private List<Cart> carts;

    public Long getId() {
        return id;
    }



    public List<Cart> getCarts() {
        return carts;
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
		Shop other = (Shop) obj;
		return Objects.equals(id, other.id);
	}

	@Override
	public String toString() {
		return "Shop [id=" + id + ", Nazwa=" + nazwa + ", Symbol" + symbol + ", Cena" + cena + ", Wiek" + wiek +"]";
		
	}


    
}
