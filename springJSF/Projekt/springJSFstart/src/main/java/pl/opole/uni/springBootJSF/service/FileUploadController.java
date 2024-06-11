package pl.opole.uni.springBootJSF.service;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.multipart.MultipartFile;

@Controller
@RequestMapping("/file-upload")
public class FileUploadController {

    @PostMapping("/upload")
    public String handleFileUpload(@RequestParam("image") MultipartFile file) {
        // Handle the file upload logic here
        // You can use Spring's MultipartFile API to process the file
        // Save the file or perform any other necessary actions
        
        // For simplicity, you can directly handle the file here or delegate to a service

        return "redirect:/success-page"; // Redirect to a success page
    }
}
