package hu.cukraszda.tortak;

public class SzulinapiTorta extends Torta{
    // extends - ezzel a kulcsszóval érhetjük el az öröklődést, az osztály deklarációjában,
    // az osztály neve után kell írnunk

    // super - a gyerekosztályból hivatkozhatunk a szülőre
    private int gyertyakSzama;
    public SzulinapiTorta(int szelet, String iz, int gyertyakSzama){
        super(szelet, iz);
        this.gyertyakSzama = gyertyakSzama;
    }
    public void kivansagotTeljesit(){
        System.out.println("Kívánságod teljesült!");
    }
    public void info(){
        System.out.println("Ez a szülinapi torta " + super.getIz() + "ízű, és " + super.szelet + " szeletes."
        + this.gyertyakSzama + "  db gyertya van rajta.");
    }
}
