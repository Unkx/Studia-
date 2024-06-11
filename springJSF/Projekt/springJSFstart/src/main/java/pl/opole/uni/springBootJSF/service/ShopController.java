package pl.opole.uni.springBootJSF.service;

import java.io.IOException;
import java.util.List;

import org.apache.catalina.User;
import org.ocpsoft.rewrite.annotation.Join;
import org.ocpsoft.rewrite.annotation.RequestAction;
import org.ocpsoft.rewrite.el.ELBeanName;
import org.ocpsoft.rewrite.faces.annotation.Deferred;
import org.ocpsoft.rewrite.faces.annotation.IgnorePostback;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Scope;
import org.springframework.stereotype.Component;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.multipart.MultipartFile;
import org.springframework.web.servlet.view.RedirectView;

import antlr.StringUtils;
import pl.opole.uni.springBootJSF.model.Shop;
import pl.opole.uni.springBootJSF.model.ShopRepository;


@Scope (value = "session")
@Component (value = "ShopController")
@ELBeanName(value = "ShopController")
@Join(path = "/shop", to = "/shopTable.xhtml")
public class ShopController {
    
    @Autowired
    private ShopRepository shopRepository;

    private List<Shop> shops;
    private Shop selectedShop;
    
    public Shop getSelectedShop() {
		return selectedShop;
	}
    public void setSelectedShop(Shop selectedShop) {

		this.selectedShop = selectedShop;
	}

	private String mode;
    
    public void add() {
        selectedShop = new Shop();  
        mode = "add";
    }
    
    public void edit() {
    	mode = "edit";
    }
    
    public void save() {
        shopRepository.save(selectedShop);
        if (mode.equals("add"))
        	shops.add(selectedShop);
    }
    
    public void beforeDelete() {
        mode = "delete";  
    }
    
    public void delete() {
    	 mode = "delete";
    	
        shopRepository.delete(selectedShop); 
        shops.remove(selectedShop);
        selectedShop = null;
    }
    
    @Deferred
    @RequestAction
    @IgnorePostback
    public void loadData() {	
        shops = shopRepository.findAll();
        selectedShop = null;
    }
    
    public List<Shop> getShops() {
        return shops;
    }
    
	public Shop getShop() {
        return selectedShop;
    }
    
	public void setShop(Shop shop) {
	    this.selectedShop = shop;
	}

    public void setSelectedStudent(Shop selectedShop) {    	
    	
    	System.out.println("Wybrany student: " + selectedShop.getNazwa());
    	
        this.selectedShop = selectedShop;                  
    }
    
    public String getMode() {
        return mode;
    }
    

}
	