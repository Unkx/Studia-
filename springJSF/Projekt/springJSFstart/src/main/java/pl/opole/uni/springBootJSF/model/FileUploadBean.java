package pl.opole.uni.springBootJSF.model;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;
import org.springframework.web.multipart.MultipartFile;

import pl.opole.uni.springBootJSF.service.FileUploadService;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.StandardCopyOption;

import javax.annotation.ManagedBean;
import javax.faces.bean.RequestScoped;

@ManagedBean
@RequestScoped
public class FileUploadBean {

    @Autowired
    private FileUploadService fileUploadService;

    private MultipartFile image;

    public MultipartFile getImage() {
        return image;
    }

    public void setImage(MultipartFile image) {
        this.image = image;
    }

    public String upload() {
        try {
            // Validate file if needed
            
            // Save the file
            String fileName = image.getOriginalFilename();
            Path filePath = Path.of("your/upload/directory/" + fileName);
            Files.copy(image.getInputStream(), filePath, StandardCopyOption.REPLACE_EXISTING);

            // Process the file using your service
            fileUploadService.processFile(filePath);

            return "success"; // Navigate to a success page
        } catch (IOException e) {
            e.printStackTrace();
            // Handle exception appropriately and provide feedback to the user
            return "error"; // Navigate to an error page
        }
    }
}