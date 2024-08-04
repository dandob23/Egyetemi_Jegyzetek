package com.mycompany.user;

import jakarta.persistence.*;
import org.hibernate.annotations.GenericGenerator;

import java.util.Arrays;

@Entity
@Table(name = "files")
public class FileEntity {

    @Id
    @GeneratedValue(generator = "uuid")
    @GenericGenerator(name = "uuid", strategy = "uuid2")
    @Column(name = "file_code", unique = true, nullable = false, length = 36)
    private String fileCode;

    @Lob
    @Column(name = "data", nullable = false)
    private byte[] data;

    @Column(name = "file_name", nullable = false)
    private String fileName;

    @Column(name = "file_type", nullable = false)
    private String fileType;

    @ManyToOne
    @JoinColumn(name = "user_id", nullable = false)
    private User user;

    public String getFileCode() {
        return fileCode;
    }

    public void setFileCode(String fileCode) {
        this.fileCode = fileCode;
    }

    public byte[] getData() {
        return data;
    }

    public void setData(byte[] data) {
        this.data = data;
    }

    public String getFileName() {
        return fileName;
    }

    public void setFileName(String fileName) {
        this.fileName = fileName;
    }

    public String getFileType() {
        return fileType;
    }

    public void setFileType(String fileType) {
        this.fileType = fileType;
    }

    public User getUser() {
        return user;
    }

    public void setUser(User user) {
        this.user = user;
    }

    @Override
    public String toString() {
        return "FileEntity{" +
                "fileCode='" + fileCode + '\'' +
                ", data=" + Arrays.toString(data) +
                ", fileName='" + fileName + '\'' +
                ", fileType='" + fileType + '\'' +
                ", user=" + user +
                '}';
    }

    public void setUserId(Long userId) {
    }
}
