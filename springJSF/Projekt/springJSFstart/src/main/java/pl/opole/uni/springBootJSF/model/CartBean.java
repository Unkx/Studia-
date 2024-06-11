package pl.opole.uni.springBootJSF.model;

import java.io.Serializable;
import java.util.Objects;

import javax.faces.bean.ManagedBean;
import javax.faces.bean.ViewScoped;

@ManagedBean(name = "cartBean")
@ViewScoped
public class CartBean implements Serializable {

    /**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private Cart selectedCart;

    // Getter and setter for selectedCart
    public Cart getSelectedCart() {
        if (selectedCart == null) {
            selectedCart = new Cart();
        }
        return selectedCart;
    }

    public void setSelectedCart(Cart selectedCart) {
        this.selectedCart = selectedCart;
    }
    public String zapisz() {
        // Przykładowa logika zapisywania danych do bazy danych
        // Możesz użyć serwisu (Service) lub repozytorium (Repository) do zapisu danych
        // np. MojaAplikacjaService.zapisz(selectedCart);

        // Tu możesz dodać dodatkową logikę zapisu danych
        System.out.println("Zapisywanie danych: " + selectedCart);

        // Po zapisie danych, możesz przekierować użytkownika na inną stronę
        return "successPage"; // Zastąp "successPage" właściwym wynikiem nawigacji
    }

    public String processPersonalData() {
        // Your processing logic here
        System.out.println("Processing data: " + selectedCart);

       
        // After processing, you can navigate to another page or return null to stay on the same page
        return "successPage"; // Replace "successPage" with the actual navigation outcome
    }

	@Override
	public int hashCode() {
		return Objects.hash(selectedCart);
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		CartBean other = (CartBean) obj;
		return Objects.equals(selectedCart, other.selectedCart);
	}

	@Override
	public String toString() {
		return "CartBean [selectedCart=" + selectedCart + ", getSelectedCart()=" + getSelectedCart()
				+ ", processPersonalData()=" + processPersonalData() + ", hashCode()=" + hashCode() + ", getClass()="
				+ getClass() + ", toString()=" + super.toString() + "]";
	}

    // Other methods...

}
