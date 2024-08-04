package hu.cukraszda.tortak;

public class Torta {
    protected int szelet;
    private String iz;
    public String getIz(){
        return iz;
    }
    public void setIz(String Iz){
        this.iz = iz;
    }
    public Torta(int szelet, String iz){
        this.szelet = szelet;
        this.iz = iz;
    }
    public void info(){
        System.out.println("Ez a torta " + this.iz + " ízű, és" + this.szelet
                            + " szeletes.");
    }
}
