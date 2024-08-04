package main;

public class SimpleAlkudozasiStrategia implements AlkudozasiStrategia{
    @Override
    public int alkudni(int ar, int mennyiseg, double kedvezmeny) {
        return (int)(ar * mennyiseg * (1-kedvezmeny));
    }
}
