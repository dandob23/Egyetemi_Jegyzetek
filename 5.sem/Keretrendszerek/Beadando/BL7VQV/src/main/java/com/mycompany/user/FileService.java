package com.mycompany.user;

import com.mycompany.upload.FileUploadUtil;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.web.multipart.MultipartFile;

import java.io.IOException;

@Service
public class FileService {

    @Autowired
    private FileRepository fileRepository;

    @Autowired
    private FileUploadUtil fileUploadUtil;

    @Transactional
    public FileEntity saveFile(FileEntity fileEntity) {
        return fileRepository.save(fileEntity);
    }

    @Transactional
    public FileEntity saveFile(String fileName, MultipartFile multipartFile, User user) throws IOException {
        FileEntity fileEntity = new FileEntity();
        fileEntity.setUser(user);
        fileEntity.setFileName(fileName);
        fileEntity.setFileType(multipartFile.getContentType());
        fileEntity.setData(multipartFile.getBytes());
        fileEntity.setFileCode(fileUploadUtil.saveFile(fileName, multipartFile));

        return saveFile(fileEntity);
    }
}
