package pl.opole.uni.springBootJSF.model;

import java.util.Objects;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

/**
 *
 * @author mszczerba
 */

@Entity
@Table(name = "studenci")
public class Student {
	
	public Student() {
		
	}
    
    public Narodowosc getNarodowosc() {
		return narodowosc;
	}

	public void setNarodowosc(Narodowosc narodowosc) {
		this.narodowosc = narodowosc;
	}

	@Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;
    private String imie;
    private String nazwisko;
    private String nrIndeksu; 
    
    @ManyToOne
    @JoinColumn(name = "id_narodowosci")
    private Narodowosc narodowosc;
    


    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
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

    public String getNrIndeksu() {
        return nrIndeksu;
    }

    public void setNrIndeksu(String nrIndeksu) {
        this.nrIndeksu = nrIndeksu;
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
		Student other = (Student) obj;
		return Objects.equals(id, other.id);
	}

	@Override
	public String toString() {
		return "Student [imie=" + imie + ", nazwisko=" + nazwisko + ", nrIndeksu=" + nrIndeksu + "]";
	}
    
}
