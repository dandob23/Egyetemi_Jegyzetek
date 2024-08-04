public class Position {
    public int getLattitude() {
        return lattitude;
    }

    public void setLattitude(int lattitude) {
        this.lattitude = lattitude;
    }

    public int getLongitude() {
        return longitude;
    }

    public void setLongitude(int longitude) {
        this.longitude = longitude;
    }

    private int lattitude;
    private int longitude;

    public Position(int lattitude, int longitude) {
        this.lattitude = lattitude;
        this.longitude = longitude;
    }

    @java.lang.Override
    public java.lang.String toString() {
        return "Position{" +
                "lattitude=" + lattitude +
                ", longitude=" + longitude +
                '}';
    }
}