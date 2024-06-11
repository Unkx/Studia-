package pl.opole.uni.springBootJSF.service;

import java.util.ArrayList;
import java.util.List;

import javax.annotation.PostConstruct;

import org.springframework.context.annotation.Scope;
import org.springframework.stereotype.Component;
import pl.opole.uni.springBootJSF.model.PozycjaMenu;

@Scope(value = "session")
@Component(value = "menuController")
public class MenuController {

	private PozycjaMenu wybranaPozycja;
	private List<PozycjaMenu> menuList;
	
	@PostConstruct
	private void loadMenu () {
		menuList = new ArrayList<PozycjaMenu>();
		
		PozycjaMenu pozycjaMain = new PozycjaMenu("Strona Główna", "Witamy", "mainTable.xhtml");
		menuList.add(pozycjaMain);
		//add new site 
		PozycjaMenu pozycjaSklep = new PozycjaMenu("Sklep", "Dodaj grę", "shopTable.xhtml");
		menuList.add(pozycjaSklep);
		
		PozycjaMenu pozycjaCart = new PozycjaMenu("Koszyk", "Dane", "cartTable.xhtml");
		menuList.add(pozycjaCart);
		
		
		this.wybranaPozycja = pozycjaMain;
		this.wybranaPozycja = pozycjaSklep;
		this.wybranaPozycja = pozycjaCart;

	}

	public String zmienPozycje(String pozycjaNazwa) {
        
        for (PozycjaMenu pozycja : menuList)
        {
            if (pozycja.getNazwa().equals(pozycjaNazwa))
            {
                this.wybranaPozycja = pozycja;
                break;
            }
        }
        
        return this.wybranaPozycja.getStrona() + "?faces-redirect=true";
    }
	
	public PozycjaMenu getWybranaPozycja() {
		return wybranaPozycja;
	}

	public List<PozycjaMenu> getMenuList() {
		return menuList;
	}
	
}
