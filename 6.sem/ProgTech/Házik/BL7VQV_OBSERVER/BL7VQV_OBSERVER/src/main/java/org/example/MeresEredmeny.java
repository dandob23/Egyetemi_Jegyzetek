package org.example;

public class MeresEredmeny {
    private String adat;
    private int ertek;

    public MeresEredmeny(String adat, int ertek){
        this.adat = adat;
        this.ertek = ertek;
    }

    public String getAdat(){
        return adat;
    }

    public int getErtek(){
        return ertek;
    }
}
