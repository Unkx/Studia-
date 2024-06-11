package pl.opole.uni.springBootJSF.service;

import java.util.List;

import org.ocpsoft.rewrite.annotation.Join;
import org.ocpsoft.rewrite.annotation.RequestAction;
import org.ocpsoft.rewrite.el.ELBeanName;
import org.ocpsoft.rewrite.faces.annotation.Deferred;
import org.ocpsoft.rewrite.faces.annotation.IgnorePostback;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Scope;
import org.springframework.stereotype.Component;
import pl.opole.uni.springBootJSF.model.Cart;
import pl.opole.uni.springBootJSF.model.CartRepository;

@Scope(value = "session")
@Component(value = "CartController")
@ELBeanName(value = "CartController")
@Join(path = "/cart", to = "/cartTable.xhtml")
public class CartController {

    @Autowired
    private CartRepository cartRepository;

    private List<Cart> carts;
    private Cart cart;

    private Cart selectedCart;
    
    public Cart getSelectedCart() {
		return selectedCart;
	}
    public void setSelectedCart(Cart selectedCart) {

		this.selectedCart = selectedCart;
	}
    private String mode;

    public void add() {
        cart = new Cart();
        mode = "add";
    }

    public void edit() {
        mode = "edit";
    }

    public void save() {
        cartRepository.save(cart);
        if (mode.equals("add"))
            carts.add(cart);
    }

    public void beforeDelete() {
        mode = "delete";
    }

    public void delete() {
        cartRepository.delete(cart);
        carts.remove(cart);
        cart = null;
    }

    @Deferred
    @RequestAction
    @IgnorePostback
    public void loadData() {
        carts = cartRepository.findAll();
        cart = null;
    }

    public List<Cart> getCarts() {
        return carts;
    }

    public Cart getCart() {
        return cart;
    }

    public void setCart(Cart cart) {
        this.cart = cart;
    }

    public String getMode() {
        return mode;
    }
}
