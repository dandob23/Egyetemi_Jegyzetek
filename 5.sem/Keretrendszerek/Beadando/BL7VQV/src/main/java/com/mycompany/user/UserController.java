package com.mycompany.user;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

import org.springframework.web.multipart.MultipartFile;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import java.io.IOException;
import java.util.List;


@Controller
public class UserController {
    @Autowired private UserService userService;
    @Autowired
    public UserController(UserService userService) {
        this.userService = userService;
    }
    @GetMapping("/users")
    public String showUserList(Model model){
        List<User> listUsers = userService.listAll();
        model.addAttribute("listUsers", listUsers);

        return "users";
    }

    @GetMapping("/users/new")
    public String showNewForm(Model model){
        model.addAttribute("user", new User());
        model.addAttribute("pageTitle", "Add New User");
        return "user_form";
    }

    @PostMapping("/users/save")
    public String saveUser(User user, RedirectAttributes ra) {
        userService.save(user);
        ra.addFlashAttribute("message","The user has been added successfully...");
        return "redirect:/users";
    }

    @GetMapping("/users/edit/{id}")
    public String showEditForm(@PathVariable("id") Integer id, Model model, RedirectAttributes ra){
        try {
            User user = userService.get(id);
            model.addAttribute("user", user);
            model.addAttribute("pageTitle", "Edit User (ID: "+ id + " )");
            return "user_form";
        } catch (UserNotFoundException e) {
            ra.addFlashAttribute("message",e.getMessage());
            return "redirect:/users";
        }
    }

    @GetMapping("/users/delete/{id}")
    public String deleteUser(@PathVariable("id") Integer id, RedirectAttributes ra){
        try {
            userService.delete(id);
            ra.addFlashAttribute("message", "The user ID: " + id + " has been deleted.");
        } catch (UserNotFoundException e) {
            ra.addFlashAttribute("message",e.getMessage());
        }
        return "redirect:/users";
    }

    @GetMapping("/register")
    public String showRegistrationForm(Model model) {
        model.addAttribute("user", new User());
        return "registration_form";
    }

    @PostMapping("/register")
    public String registerUser(@ModelAttribute("user") User user) {
        userService.save(user);
        return "redirect:/login";
    }

    @GetMapping("/login")
    public String showLoginPage(Model model) {
        model.addAttribute("user", new User());
        return "login_form";
    }
    @PostMapping("/login")
    public String processLogin(@ModelAttribute("user") User user, RedirectAttributes ra) {
        if (userService.isValidUser(user)) {
            return "redirect:/users";
        } else {
            ra.addFlashAttribute("error", "Invalid username or password");
            return "redirect:/login";
        }
    }


    @GetMapping("/upload/{id}")
    public String showFileUploadForm(@PathVariable("id") Integer id, Model model, RedirectAttributes ra) {
        try {
            User user = userService.get(id);
            model.addAttribute("user", user);
            model.addAttribute("fileEntity", new FileEntity());
            model.addAttribute("pageTitle", "File Upload for User (ID: " + id + ")");
            return "file_upload_form";
        } catch (UserNotFoundException e) {
            ra.addFlashAttribute("error", "Error while uploading file...");
            return "redirect:/users";
        }
    }

    @PostMapping("/upload/{id}")
    public String handleFileUpload(@PathVariable("id") Integer id,
                                   @ModelAttribute("fileEntity") FileEntity fileEntity,
                                   @RequestParam("file") MultipartFile file,
                                   RedirectAttributes ra) {

        try {
            User user = userService.get(id);
            fileEntity.setUser(user);

            if (file != null && !file.isEmpty()) {
                fileEntity.setData(file.getBytes());
                fileEntity.setFileName(file.getOriginalFilename());
                fileEntity.setFileType(file.getContentType());
            }

            userService.saveFile(fileEntity);

            ra.addFlashAttribute("success", "File uploaded successfully.");
            return "redirect:/users";
        } catch (IOException | UserNotFoundException e) {
            ra.addFlashAttribute("error", "Error while uploading file.");
            return "redirect:/users";
        }
    }








}
