public class Program {
    public static void main(String[] args) throws Exception{
        Owner owner = new Owner("valami", "valami");
        SensorNetwork.instantiate(owner);
        SensorNetwork sensorNetwork = SensorNetwork.getInstance();

        Thermometer wideThermometer = new Thermometer(ThermometerScaling.Wide);
        sensorNetwork.Install(wideThermometer, "asd");
    }
}