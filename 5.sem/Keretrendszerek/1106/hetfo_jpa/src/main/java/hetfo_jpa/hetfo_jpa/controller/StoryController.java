package hetfo_jpa.hetfo_jpa.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.HttpStatusCode;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;

import hetfo_jpa.hetfo_jpa.model.Story;
import hetfo_jpa.hetfo_jpa.repository.StoryRepository.StoryRepository;

@Controller
@RequestMapping("/api")
public class StoryController {
    @Autowired
    StoryRepository storyRepository;

    @GetMapping("/stories")
    public ResponseEntity<List<Story>> sh0owStories()
    {
        List<Story> stories = storyRepository.findAll();

        return ResponseEntity.status(HttpStatus.OK).body(stories);
    }

    @GetMapping("/story/{id}")
    public ResponseEntity<Story> getStory (@PathVariable long id){
        Story s = storyRepository.findById(id).orElse(null);

        return ResponseEntity.status(HttpStatus.OK).body(s);
    }



    @PostMapping("/create-story")
    public ResponseEntity<Story> createStory(@RequestBody Story story)
    {
        Story s = new Story(story.getTitle(), story.getContent());
        storyRepository.save(s);
        return ResponseEntity.status(HttpStatus.CREATED).body(s);
    }


    @PutMapping("/update-story/{id}")
    public ResponseEntity<Story> updateStory(@PathVariable long id, @RequestBody Story story){
        Story s = storyRepository.findById(id).orElse(null);
        if (s==null) {
            return ResponseEntity.status(HttpStatus.BAD_REQUEST).body(s);
        }

        s.setContent(story.getContent());
        s.setTitle(story.getTitle());

        s = storyRepository.save(s);

        return ResponseEntity.status(HttpStatus.OK).body(s);
    }

    @DeleteMapping("/delete-story/{id}")
    public ResponseEntity<List<Story>> deleteStory(@PathVariable long id)
    {
        storyRepository.deleteById(id);

        return ResponseEntity.status(HttpStatus.OK).body(storyRepository.findAll());
    }

    
}
