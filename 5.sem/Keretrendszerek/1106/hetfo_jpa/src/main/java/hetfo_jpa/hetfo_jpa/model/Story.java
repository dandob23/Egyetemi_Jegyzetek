package hetfo_jpa.hetfo_jpa.model;

import jakarta.persistence.*;

@Entity
@Table(name = "stories")
public class Story {
    
    @Id
    @GeneratedValue(strategy = GenerationType.SEQUENCE, generator = "tutorial_generator")
    private long id;

    @Column(name = "title", nullable = false, length = 100,unique = true)
    private String title;

    @Column(name = "content")
    private String content;


    public Story(){}

    public Story(String title, String content){
        this.title = title;
        this.content = content;
    }

    public long getId(){
        return id;
    }

    public void setId(long id){
        this.id=id;
    }

    public String getTitle() {
        return null;
    }

    public String getContent() {
        return null;
    }

    public void setContent(String content2) {
    }

    public void setTitle(String title2) {
    }
}
