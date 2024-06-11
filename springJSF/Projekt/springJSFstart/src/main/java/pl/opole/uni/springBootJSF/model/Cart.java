package pl.opole.uni.springBootJSF.model;

import java.io.Serializable;
import java.util.Objects;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.SessionScoped;
@Entity
@Table(name = "cart")
@ManagedBean
@SessionScoped
public class Cart implements Serializable {

	
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	public Cart() {
		
	}
	
    @ManyToOne
    @JoinColumn(name = "shop_id")
    private Shop shop;
		
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long id;
	private String imie;
	private String nazwisko;
	private Long wiek;
	private String ulica;
	private Long kodpocztowy;
	private String miasto;
	private String dodatkoweinformacje;
	private Long telefon;
	private String email;
	private String zdjecie; 

	private String cartItemName;
    public String getCartItemName() {
        return cartItemName;
    }
	
	public String getZdjecie() {
		return zdjecie;
	}
	public void setZdjecie(String zdjecie) {
		this.zdjecie = zdjecie;
	}
	public Long getTelefon() {
		return telefon;
	}
	public void setTelefon(Long telefon) {
		this.telefon = telefon;
	}
	public String getEmail() {
		return email;
	}
	public void setEmail(String email) {
		this.email = email;
	}
	@Override
	public int hashCode() {
		return Objects.hash(dodatkoweinformacje, email, imie, kodpocztowy, miasto, nazwisko, telefon, ulica, wiek,
				zdjecie);
	}
	
	public String getImie() {
		return imie;
	}
	public void setImie(String imie) {
		this.imie = imie;
	}
	public String getNazwisko() {
		return nazwisko;
	}
	public void setNazwisko(String nazwisko) {
		this.nazwisko = nazwisko;
	}
	public String getUlica() {
		return ulica;
	}
	public void setUlica(String ulica) {
		this.ulica = ulica;
	}
	public Long getKodpocztowy() {
		return kodpocztowy;
	}
	public void setKodpocztowy(Long kodpocztowy) {
		this.kodpocztowy = kodpocztowy;
	}
	public String getMiasto() {
		return miasto;
	}
	public void setMiasto(String miasto) {
		this.miasto = miasto;
	}
	public String getDodatkoweinformacje() {
		return dodatkoweinformacje;
	}
	public void setDodatkoweinformacje(String dodatkoweinformacje) {
		this.dodatkoweinformacje = dodatkoweinformacje;
	}
	public String getFirstname() {
		return imie;
	}
	public void setFirstname(String firstname) {
		this.imie = firstname;
	}
	public String getLastname() {
		return nazwisko;
	}
	public void setLastname(String lastname) {
		this.nazwisko = lastname;
	}
	public Long getWiek() {
		return wiek;
	}
	public void setWiek(Long wiek) {
		this.wiek = wiek;
	}
	
    @Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		Cart other = (Cart) obj;
		return Objects.equals(dodatkoweinformacje, other.dodatkoweinformacje) && Objects.equals(email, other.email)
				&& Objects.equals(imie, other.imie) && Objects.equals(kodpocztowy, other.kodpocztowy)
				&& Objects.equals(miasto, other.miasto) && Objects.equals(nazwisko, other.nazwisko)
				&& Objects.equals(telefon, other.telefon) && Objects.equals(ulica, other.ulica)
				&& Objects.equals(wiek, other.wiek) && Objects.equals(zdjecie, other.zdjecie);
	}
    
	public Cart(String imie, String nazwisko, Long wiek, String ulica, Long kodpocztowy, String miasto,
			String dodatkoweinformacje) {
		super();
		this.imie = imie;
		this.nazwisko = nazwisko;
		this.wiek = wiek;
		this.ulica = ulica;
		this.kodpocztowy = kodpocztowy;
		this.miasto = miasto;
		this.dodatkoweinformacje = dodatkoweinformacje;
	}
	@Override
	public String toString() {
		return "Cart [imie=" + imie + ", nazwisko=" + nazwisko + ", wiek=" + wiek + ", ulica=" + ulica
				+ ", kodpocztowy=" + kodpocztowy + ", miasto=" + miasto + ", dodatkoweinformacje=" + dodatkoweinformacje
				+ ", telefon=" + telefon + ", email=" + email + ", zdjecie=" + zdjecie + "]";
	}
	
}

	