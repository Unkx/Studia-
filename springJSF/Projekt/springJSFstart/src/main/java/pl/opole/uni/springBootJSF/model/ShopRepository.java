package pl.opole.uni.springBootJSF.model;

import org.springframework.data.jpa.repository.JpaRepository;


public interface ShopRepository extends JpaRepository<Shop, Long> {
    
}