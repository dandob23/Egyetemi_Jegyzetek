package org.example;

public class Mentos  implements GondosoraListener{
    private String nev;
    private String cim;

    public Mentos(String nev, String cim){
        this.nev=nev;
        this.cim=cim;
    }
    @Override
    public void onMeresErtesites(MeresEredmeny eredmeny) {
        int ertek = eredmeny.getErtek();
        if (ertek>150){
            System.out.println(nev + " mentős: Kritikus " + eredmeny.getAdat() + " érték: " + ertek + ", cím: " + cim);
        }
    }
}
