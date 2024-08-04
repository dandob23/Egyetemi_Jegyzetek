package org.example;

public class Orvos implements GondosoraListener{
    private String nev;

    public Orvos(String nev){
        this.nev=nev;
    }

    @Override
    public void onMeresErtesites(MeresEredmeny eredmeny){
        int ertek = eredmeny.getErtek();
        if (ertek > 100 && ertek <=150){
            System.out.println(nev + " orvos: Tűréshatáron belüli " + eredmeny.getAdat() + " érték: " + ertek);
        } else if (ertek > 150) {
            System.out.println(nev + " orvos: Kritikus " + eredmeny.getAdat() + " érték: " + ertek);
        }
    }
}
