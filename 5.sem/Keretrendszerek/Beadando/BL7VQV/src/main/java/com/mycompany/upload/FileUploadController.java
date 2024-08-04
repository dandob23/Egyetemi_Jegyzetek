package com.mycompany.upload;

import com.mycompany.user.FileEntity;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.multipart.MultipartFile;

import java.io.IOException;

@Controller
@RequestMapping("/upload")
public class FileUploadController {

    private final FileUploadUtil fileUploadUtil;

    public FileUploadController(FileUploadUtil fileUploadUtil) {
        this.fileUploadUtil = fileUploadUtil;
    }

    @PostMapping
    public ResponseEntity<FileUploadResponse> uploadFile(
            @RequestParam("file") MultipartFile multipartFile) throws IOException {

        String fileName = multipartFile.getOriginalFilename();
        long size = multipartFile.getSize();

        String fileCode = fileUploadUtil.saveFile(fileName, multipartFile);

        FileUploadResponse response = new FileUploadResponse();
        response.setFileName(fileName);
        response.setSize(size);
        response.setDownloadUri("/download/" + fileCode);

        return new ResponseEntity<>(response, HttpStatus.OK);
    }

    @RequestMapping("/form")
    public String showFileUploadForm(Model model) {
        model.addAttribute("fileEntity", new FileEntity());
        return "file_upload_form";
    }
}
