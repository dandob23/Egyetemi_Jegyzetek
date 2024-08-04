package com.mycompany.download;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.util.ArrayList;
import java.util.List;

import org.springframework.core.io.Resource;
import org.springframework.core.io.UrlResource;
import org.springframework.stereotype.Component;

@Component
public class FileDownloadUtil {
    private Path foundFile;

    public Resource getFileAsResource(String fileCode) throws IOException {
        Path dirPath = Paths.get("Files-Upload");

        Files.list(dirPath).forEach(file -> {
            if (file.getFileName().toString().startsWith(fileCode)) {
                foundFile = file;
                return;
            }
        });

        if (foundFile != null) {
            return new UrlResource(foundFile.toUri());
        }

        return null;
    }

    public List<String> getAllFileCodes() {
        List<String> fileCodes = new ArrayList<>();

        try {
            Path dirPath = Paths.get("Files-Upload");

            Files.list(dirPath).forEach(file -> {
                String fileCode = file.getFileName().toString().split("-")[0];
                fileCodes.add(fileCode);
            });
        } catch (IOException e) {
            e.printStackTrace(); // Add proper error handling
        }

        return fileCodes;
    }
}