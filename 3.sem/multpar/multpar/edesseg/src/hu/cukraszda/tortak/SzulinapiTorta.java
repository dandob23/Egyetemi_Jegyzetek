package hu.cukraszda.tortak;

public class SzulinapiTorta extends Torta{
    private int gyertyakSzama;

    public SzulinapiTorta(int szelet, String iz, int gyertyakSzama){
        super(szelet, iz);
        this.gyertyakSzama = gyertyakSzama;
    }

    public void kivansagotTeljesit(){
        System.out.println("Kívánságod teljesült!");
    }
    public void info(){
        System.out.println("Ez a szülinapi torta " + super.getIz() + "ízű és "
        + super.szelet + " szeletes." + this.gyertyakSzama + " db gyertya van rajta.");
    }

    public static void main(String[] args) {
        Torta csokiTorta = new SzulinapiTorta(15, "csoki",9);

        Torta[] cukraszda = new Torta[3];
        cukraszda[0] = new Torta(20, "csokis-meggyes");
        cukraszda[1] = new Torta(12, "epres");
        cukraszda[2] = new SzulinapiTorta(12,"karamell", 12);

        for (Torta torta : cukraszda) {
            torta.info();
        }
    }
}
