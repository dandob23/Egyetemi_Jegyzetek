import java.io.File;
import java.io.FileNotFoundException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class SensorNetwork{
    private Owner owner;

    private SensorNetwork(){

    }

    private static SensorNetwork instance;

    public static void instantiate(Owner owner) throw Exception{
        if (instance != null)
            try {
                throw new Exception("Instance already exists...");
            } catch (Exception e) {
                throw new RuntimeException(e);
            }
        instance = new SensorNetwork();
        instance.owner = new Owner(owner.getCompanyName(), owner.getLocation());
    }
    public static SensorNetwork getInstance() throws Exception{
        if (instance == null){
            throw new Exception("Instance does not exist. Please call the instantiate method first...");
        }
        return instance;
    }

    private List<Sensor> sensors = new ArrayList<>();

    public void Install(Sensor prototype, String fileName) throws FileNotFoundException, CloneNotSupportedException {
        File file = new File(fileName);
        Scanner scanner = new Scanner(file);
        while (scanner.hasNext()){
            String row = scanner.nextLine();
            String[] data = row.split(";");
            Sensor newSensor = (Sensor)prototype.clone();
            newSensor.setPosition(Integer.parseInt(data[0]),
                                    Integer.parseInt(data[1])
            );


        }
        scanner.close();
    }


    @java.lang.Override
    public java.lang.String toString() {
        return "SensorNetwork{" +
                "owner=" + owner +
                '}';
    }
}