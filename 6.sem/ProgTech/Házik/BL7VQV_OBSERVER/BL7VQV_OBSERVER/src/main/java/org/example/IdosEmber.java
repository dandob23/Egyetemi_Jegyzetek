package org.example;

public class IdosEmber implements GondosoraListener{
    private String nev;
    private String cim;

    public IdosEmber(String nev, String cim){
        this.nev = nev;
        this.cim = cim;
    }

    public String getNev(){
        return nev;
    }

    public String getCim(){
        return cim;
    }

    @Override
    public void onMeresErtesites(MeresEredmeny eredmeny) {
        System.out.println("Idős ember "+nev+" értesítése: "+eredmeny.getAdat()+" értéke: "+eredmeny.getErtek());
    }
}
