import java.time.LocalDateTime;
import java.util.HashMap;
import java.util.Map;

public class Thermometer extends Sensor {

    public Thermometer(ThermometerScaling thermometerScaling) {
        super(position);

        switch (thermometerScaling){
            case Narrow -> {
                minTemperature = -10;
                maxTemperature = 10;
                break;
            }
            case Medium -> {
                minTemperature = -30;
                maxTemperature = 40;
                break;
            }
            case Wide -> {
                minTemperature = -100;
                maxTemperature = 120;
                break;
            }
        }

    }

    private int minTemperature;
    private int maxTemperature;



    public void setMinTemperature(int minTemperature) {
        this.minTemperature = minTemperature;
    }

    public void setMaxTemperature(int maxTemperature) {
        this.maxTemperature = maxTemperature;
    }

    public int getMinTemperature() {
        return minTemperature;
    }

    public int getMaxTemperature() {
        return maxTemperature;
    }

    private Map<LocalDateTime, Double> measurements = new HashMap<>();

    @Override
    public void Measure() {
        this.measurements.put(LocalDateTime.now(), Math.random() * (maxTemperature-minTemperature) + minTemperature);
    }

    @Override
    protected Object clone() throws CloneNotSupportedException {
        return super.clone();
    }
}
