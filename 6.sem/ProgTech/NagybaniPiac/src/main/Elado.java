package main;

import java.util.HashMap;
import java.util.Map;

public class Elado {
    private Map<String, Integer> arak;
    private AlkudozasiStrategia alkudozasiStrategia;

    public Elado(){
        this.arak = new HashMap<>();
        this.alkudozasiStrategia = new SimpleAlkudozasiStrategia();
    }

    public Elado(AlkudozasiStrategia alkudozasiStrategia){
        this.arak = new HashMap<>();
        this.alkudozasiStrategia = alkudozasiStrategia;
    }

    public void setAr(String termek, int ar){
        arak.put(termek, ar);
    }

    public int getAr(String termek){
        return arak.getOrDefault(termek, 0);
    }

    public int alkudni(String termek, int mennyiseg, double kedvezmeny){
        int ar = getAr(termek);
        return alkudozasiStrategia.alkudni(ar,mennyiseg, kedvezmeny);
    }
}
