package pl.opole.uni.springBootJSF.model;

import org.springframework.data.jpa.repository.JpaRepository;

/**
 *
 * @author mszczerba
 */
public interface StudentRepository extends JpaRepository<Student, Long> {
    
}
