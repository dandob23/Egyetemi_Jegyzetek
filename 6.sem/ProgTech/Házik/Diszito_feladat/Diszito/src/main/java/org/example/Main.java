package org.example;

public class Main {
    public static void main(String[] args) {
        Oktato oktato1 = new OktatoImpl("John Doe", 14);
        Oktato oktato2 = new OktatoImpl("Jane Doe", 12);
        Oktato oktato3 = new OktatoImpl("Jeff Doe", 10);


        oktato1 = new TantargyfelelosDecorator(oktato1);
        Tantargy tantargy = new Tantargy("Robotika");
        String dontes = oktato1.DontestHoz(tantargy, "Csak vizsga tárgy meghirdetése");

        oktato2 = new SzakfelelosDecorator(oktato2);
        Tantargy tantargy2 = new Tantargy("PTI");
        String dontes2 = oktato2.DontestHoz(tantargy2, "Magasabb kreditszám");

        oktato3 = new TanszekvezetoDecorator(oktato3);
        Tantargy tantargy3 = new Tantargy("Informatikai tanszék");
        String dontes3 = oktato3.DontestHoz(tantargy3, "Szünet");


        System.out.println("Döntés: "+ dontes);
        System.out.println("Döntés: "+ dontes2);
        System.out.println("Döntés: "+ dontes3);

    }
}