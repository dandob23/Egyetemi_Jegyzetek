package hetfo_jpa.hetfo_jpa.repository.StoryRepository;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;

import hetfo_jpa.hetfo_jpa.model.Story;

public interface StoryRepository extends JpaRepository<Story, Long>
{
    List<Story> findAll();
}