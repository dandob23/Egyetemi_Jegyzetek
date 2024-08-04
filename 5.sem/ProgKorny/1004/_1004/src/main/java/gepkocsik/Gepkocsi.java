package gepkocsik;

import java.time.LocalDateTime;

public class Gepkocsi {
    String rendszam;

    int evjarat;

    int eredetiAr;

    Allapot allapot;

    static String betuk = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    static String szamok = "0123456789";

    public String getRendszam() {
        return rendszam;
    }

    private void setRendszam(String rendszam) throws Exception {
        if (rendszam.length()!=7) throw new Exception("Nem megfelelő rendszám hossz!");

        for (int i = 0; i<3;i++) {
            if (!betuk.contains(rendszam.substring(i,i+1))){
                throw new Exception("A rendszám betűi nem megfelelőek!");
            }
        }
        if(rendszam.charAt(3) != '-'){
            throw new Exception("A 4. karakter nem '-' ");
        }

        for (int i = 4; i<7;i++){
            if (!szamok.contains(rendszam.substring(i,i+1))){
                throw new Exception("A rendszám számai nem megfelelőek!");
            }
        }
        this.rendszam = rendszam;
    }

    public int getEvjarat() {
        return evjarat;
    }

    private void setEvjarat(int evjarat) throws Exception {
        if (evjarat < 1950 || evjarat >LocalDateTime.now().getYear()) throw new Exception("Az évjárat nem megfelelő!");
        this.evjarat = evjarat;
    }

    public int getEredetiAr() {
        return eredetiAr;
    }

    private void setEredetiAr(int eredetiAr) throws Exception {
        if(eredetiAr<300000 || eredetiAr>12000000) throw new Exception("Az ár nem megfelelő!");
        this.eredetiAr = eredetiAr;
    }

    public Allapot getAllapot() {
        return allapot;
    }

    public void setAllapot(Allapot allapot) {
        this.allapot = allapot;
    }

    public int getKor() {
        return LocalDateTime.now().getYear() - evjarat;
    }

    public int getExtraAr(){
        int val = 0;
        if(getKor() <= 2 && allapot == Allapot.UJSZERU) val = eredetiAr / 100 * 2;
        return val;
    }

    public Gepkocsi(String rendszam, int evjarat, int eredetiAr, Allapot allapot)
    throws Exception{
        setAllapot(allapot);
        setEvjarat(evjarat);
        setRendszam(rendszam);
        setEredetiAr(eredetiAr);
    }

    public Gepkocsi(String rendszam, int evjarat, int eredetiAr) throws Exception{
        this(rendszam,evjarat, eredetiAr, Allapot.MEGKIMELT);
    }

    public int getVetelAr(){
        int val = getEredetiAr();

        switch (allapot){
            case UJSZERU:
                val*= Math.pow(9, getKor());
                break;

            case MEGKIMELT:
                val*= Math.pow(10, getKor());
                break;

            case SERULT:
                val*= Math.pow(11, getKor());
                break;

            case HIBAS:
                val*= Math.pow(12, getKor());
                break;
        }
        return val + getExtraAr();
    }

    @Override
    public boolean equals(Object obj) {
        if(obj.getClass() != this.getClass())
            return false;
        Gepkocsi other = Gepkocsi.class.cast(obj);
        return this.rendszam.equals(other.rendszam);
    }

    @Override
    public String toString() {
        String s = "";
        s += "Rendszám: " + rendszam;
        s += "\nÉvjárat: " + evjarat;
        s += "\nEredeti ár: " + eredetiAr;
        s += "\nÁllapot: " + allapot;
        s += "\nExtra ár:  " + getExtraAr();
        s += "\nVétel ár: " + getVetelAr();
        s += "\nKor: " + getKor();
        return s;
    }
}