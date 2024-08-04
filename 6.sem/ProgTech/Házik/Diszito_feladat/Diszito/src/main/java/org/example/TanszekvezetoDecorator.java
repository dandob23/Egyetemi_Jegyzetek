package org.example;

public class TanszekvezetoDecorator implements Oktato{
    private Oktato oktato;

    public TanszekvezetoDecorator(Oktato oktato){
        this.oktato = oktato;
    }
    @Override
    public String getNev() {
        return oktato.getNev();
    }

    @Override
    public int getOraszam() {
        return oktato.getOraszam();
    }

    @Override
    public String DontestHoz(Tantargy tantargy, String dontes) {
        return "Tanszékvezető döntése: "+dontes;
    }
}
