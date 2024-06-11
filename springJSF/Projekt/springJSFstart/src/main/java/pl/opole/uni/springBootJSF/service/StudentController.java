package pl.opole.uni.springBootJSF.service;


import java.util.List;

/**
 *
 * 
 */
import org.ocpsoft.rewrite.annotation.Join;
import org.ocpsoft.rewrite.annotation.RequestAction;
import org.ocpsoft.rewrite.el.ELBeanName;
import org.ocpsoft.rewrite.faces.annotation.Deferred;
import org.ocpsoft.rewrite.faces.annotation.IgnorePostback;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Scope;
import org.springframework.stereotype.Component;
import pl.opole.uni.springBootJSF.model.Student;
import pl.opole.uni.springBootJSF.model.StudentRepository;

@Scope (value = "session")
@Component (value = "studentController")
@ELBeanName(value = "studentController")
@Join(path = "/student", to = "/studentTable.xhtml")
public class StudentController {
    
    @Autowired
    private StudentRepository studentRepository;

    private List<Student> students;
    private Student student;
    private String mode;
    
    public void add() {
        student = new Student();  
        mode = "add";
    }
    
    public void edit() {
    	mode = "edit";
    }
    
    public void save() {
        studentRepository.save(student);
        if (mode.equals("add"))
        	students.add(student);
    }
    
    public void beforeDelete() {
        mode = "delete";  
    }
    
    public void delete() {
        studentRepository.delete(student); 
        students.remove(student);
        student = null;
    }
    
    @Deferred
    @RequestAction
    @IgnorePostback
    public void loadData() {	
        students = studentRepository.findAll();
        student = null;
    }
    
    public List<Student> getStudents() {
        return students;
    }
    
	public Student getStudent() {
        return student;
    }
    
    public void setStudent(Student student) {
        this.student = student;
    }
    
    public String getMode() {
        return mode;
    }
}
