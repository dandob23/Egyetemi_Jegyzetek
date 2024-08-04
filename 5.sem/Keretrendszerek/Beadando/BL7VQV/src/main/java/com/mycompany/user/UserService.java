package com.mycompany.user;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.Optional;

@Service
public class UserService {
    @Autowired private UserRepository repo;
    private final FileRepository fileEntityRepository;


    @Autowired
    public UserService(UserRepository userRepository, FileRepository fileEntityRepository) {
        this.repo = userRepository;
        this.fileEntityRepository = fileEntityRepository;
    }

    public List<User> listAll(){
        return (List<User>) repo.findAll();
    }

    public void save(User user) {
        repo.save(user);
    }

    public User get(Integer id) throws UserNotFoundException {
        Optional<User> result = repo.findById(id);
        if (result.isPresent()){
            return result.get();
        }
        throw new UserNotFoundException("Could not find any users with ID: " + id);
    }

    public void delete(Integer id) throws UserNotFoundException {
        Long count = repo.countById(id);
        if (count == null || count == 0){
            throw new UserNotFoundException("Could not find any users with ID: " + id);
        }
        repo.deleteById(id);
    }

    public void registerUser(User user){
        repo.save(user);
    }

    public User loginUser(String email, String password) throws UserNotFoundException {
        Optional<User> user = repo.findByEmailAndPassword(email, password);

        if (user.isPresent()) {
            return user.get();
        } else {
            throw new UserNotFoundException("Invalid email or password");
        }
    }

    public boolean isValidUser(User user) {
        Optional<User> userInDatabase = repo.findByEmailAndPassword(user.getEmail(), user.getPassword());
        return userInDatabase.isPresent();
    }

    public void saveFile(FileEntity fileEntity) {
        fileEntityRepository.save(fileEntity);
    }
}
