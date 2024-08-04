package model;

public class Model {
    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getName() {
        return Name;
    }

    public void setName(String name) {
        Name = name;
    }

    public String getProductId() {
        return Product_id;
    }

    public void setProductId(String id) {
        this.Product_id = id;
    }

    public String getCountrytId() {
        return Country_id;
    }

    public void setCountrId(String id) {
        this.Country_id = id;
    }
    
    private String id;
    private String Name;
    private String Product_id;
    private String Country_id;
    

    public Model(){}
}
