package hetfo_jpa.hetfo_jpa.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;

import hetfo_jpa.hetfo_jpa.repository.StoryRepository.TutorialRepository;

public class TutorialController {
    @Autowired
    TutorialRepository tutorialRepository;

    @GetMapping("/tutorials")

    @GetMapping("/tutorials/{id}")

    @PostMapping("/tutorials")

    @PutMapping("/tutorials/{id}")

    @DeleteMapping("/tutorials/{id}")
}
