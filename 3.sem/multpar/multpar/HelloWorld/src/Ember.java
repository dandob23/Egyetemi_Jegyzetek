public class Ember {
    String nev;
    int kor;
    boolean nem;
    public Ember(String nev, int kor, boolean nem)
    {
        this.nev = nev;
        this.kor = kor;
        this.nem = nem;
    }
    public String getNev(){
        return this.nev;
    }
    public void setNev(String nev){
        this.nev = nev;
    }
    public void setKor(int kor){
        if (kor > 0){
            this.kor = kor;
        }else{
            System.out.println("A kor csak pozitív szám lehet!");
        }
    }
    public boolean isNem(){
        return this.nem;
    }
    public String toString(){
        return "Ez egy ember, neve "  + this.nev + ", eletkor "
                + this.kor + " nem " + (this.nem ? "ferfi" : "nő");
    }
    public void koszon()
    {
        System.out.println("Szia! " + nev + " vagyok és " + kor + " éves vagyok és " + (nem ? "férfi" : "nő"));
    }

    // Static
    // Adattag: összes példány esetében ugyanaz lesz az értékük, osztály összes példánya osztozik rajta
    // Metódus: nem példányhoz, hanem osztályhoz tartozik, példányosítás nélkül is meghívható

    // Final
    // Adattag: adattag kezdeti értéke nem megváltoztatható
    // Metódus: gyerekosztályban nem lehet felüldefiniálni
    // Osztály: nem lehet gyerekosztálya
}













