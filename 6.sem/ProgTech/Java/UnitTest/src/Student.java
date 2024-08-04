import java.io.IOException;
import java.util.Date;

public class Student {
    private String firtsName;

    public String getFirtsName() {
        return firtsName;
    }

    public void setFirtsName(String firtsName) {
        this.firtsName = firtsName;
    }

    private String lastName;

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    private Date dateOfBirth;

    public Date getDateOfBirth() {
        return dateOfBirth;
    }

    public void setDateOfBirth(Date dateOfBirth) {
        this.dateOfBirth = dateOfBirth;
    }

    public String FullName (String firtsName, String lastName){
        return firtsName + " " + lastName;
    }

    public int Age (){
        return getDateOfBirth()
    }
}
