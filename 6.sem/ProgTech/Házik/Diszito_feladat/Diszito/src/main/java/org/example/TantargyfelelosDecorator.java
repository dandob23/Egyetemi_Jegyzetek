package org.example;

public class TantargyfelelosDecorator implements Oktato{
    private Oktato oktato;

    public TantargyfelelosDecorator(Oktato oktato){
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
        return "Tantárgyfelelős döntése: "+dontes;
    }
}
