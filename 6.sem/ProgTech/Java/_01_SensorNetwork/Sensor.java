public abstract class Sensor {

    private static int ID = 0;
    public Sensor(Position position){
        this.id = ID++;
    }

    @Override
    protected Object clone() throws CloneNotSupportedException {
        return super.clone();
    }

    private int id;
    private Position position;
    public abstract void Measure();

    @Override
    public String toString() {
        return "Sensor{" +
                "id=" + id +
                ", position=" + position +
                '}';
    }

}
