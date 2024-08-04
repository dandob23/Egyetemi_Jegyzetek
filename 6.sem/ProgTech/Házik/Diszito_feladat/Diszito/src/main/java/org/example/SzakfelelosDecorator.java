package org.example;

public class SzakfelelosDecorator implements Oktato {
    private Oktato oktato;

    public SzakfelelosDecorator(Oktato oktato) {
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
        return "Szakfelelős döntése: " + dontes;
    }
}