public class Ember {
    // public -> mindenhonnan látható
    // private -> csak maga az osztály látja
    // nem írtunk ki semmit -> "friendly" láthatóság, csomagon belül public, csomagon kívűl private
    // protected -> a csomag, az osztály és az azokból származtatott gyermekosztályok látják

    String nev;
    int kor;
    boolean ferfi;

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
            System.out.println("A kor csak pozitív szám lehet");
        }
    }
    public boolean isFerfi(){
        return this.ferfi;
    }

    // default konstruktor
    public Ember() {}
    // paraméteres konstruktor
    public Ember(String nev, int kor, boolean ferfi){
        this.nev = nev;
        this.kor = kor;
        this.ferfi = ferfi;
    }
    public void koszon(){
        System.out.println("Szia! " + nev + " vagyok és " + kor + " éves, mellesleg "
                        + (ferfi ? "férfi." : "nő."));
    }

    public String toString(){
        return "Ez egy ember, neve " + this.nev + ", éves: " + this.kor +
                ", ferfi=" + this.ferfi;
    }

    public static void main(String[] args) {
        Ember adam = new Ember("Ádám", 27, true);
        //adam.koszon();
        System.out.print(adam);
    }
}

