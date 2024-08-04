package main;

import java.util.ArrayList;
import java.util.List;

public class NagybaniPiac {
    private List<Elado> eladok;

    public NagybaniPiac(){
        this.eladok = new ArrayList<>();
    }

    public List<Elado> getEladok(){
        return eladok;
    }

    public void addElado(Elado elado){
        this.eladok.add(elado);
    }
}
