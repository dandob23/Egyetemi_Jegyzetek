package org.example;

public class OktatoImpl implements Oktato{
    private String nev;
    private int oraszam;

    public OktatoImpl(String nev, int oraszam){
        this.nev = nev;
        this.oraszam = oraszam;
    }

    @Override
    public String getNev(){
        return nev;
    }

    @Override
    public int getOraszam(){
        return oraszam;
    }

    @Override
    public String DontestHoz(Tantargy tantargy, String dontes){
        return dontes;
    }
}
