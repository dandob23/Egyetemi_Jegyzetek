package test;

import main.Elado;
import main.NagybaniPiac;
import main.SimpleAlkudozasiStrategia;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class NagybaniPiacTest {
    @Test
    public void testAddElado(){
        NagybaniPiac piac = new NagybaniPiac();
        assertEquals(0, piac.getEladok().size());

        Elado elado = new Elado();
        piac.addElado(elado);
        assertEquals(1, piac.getEladok().size());
    }

    @Test
    public void testSetAndGetAr(){
        Elado elado = new Elado();
        elado.setAr("alma", 400);
        elado.setAr("repa", 300);
        assertEquals(400, elado.getAr("alma"));
        assertEquals(300, elado.getAr("repa"));
    }

    @Test
    public void testAlkudozasiStrategia(){
        Elado elado = new Elado(new SimpleAlkudozasiStrategia());
        elado.setAr("alma", 400);
        int ar = elado.alkudni("alma", 10, 0.1);
        assertEquals(3600, ar);
    }

}
