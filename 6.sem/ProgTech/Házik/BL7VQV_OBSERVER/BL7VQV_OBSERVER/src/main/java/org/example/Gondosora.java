package org.example;

import javax.xml.stream.XMLEventReader;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Gondosora {
    private Random random = new Random();
    private List<GondosoraListener> listeners = new ArrayList<>();
    private List<IdosEmber> idosEmberek = new ArrayList<>();
    public void addListener(GondosoraListener listener) {
        listeners.add(listener);
        if (listener instanceof IdosEmber){
            idosEmberek.add((IdosEmber) listener);
        }
    }

    public void removeListener(GondosoraListener listener) {
        listeners.remove(listener);
        if (listener instanceof IdosEmber){
            idosEmberek.remove((IdosEmber) listener);
        }
    }

    public void merni() {
        for (GondosoraListener listener : listeners) {
            if (listener instanceof Orvos || listener instanceof Mentos) {
                merniAlapertekeket(listener);
            } else if (listener instanceof IdosEmber) {
                List<MeresEredmeny> meresek = generateRandomMeresek();
                for (MeresEredmeny meres : meresek) {
                    listener.onMeresErtesites(meres);
                }
            }
        }
    }

    private void merniAlapertekeket(GondosoraListener listener){
        int vercukor = random.nextInt(300);
        int vernyomas = random.nextInt(200);
        int pulzus = random.nextInt(150);

        MeresEredmeny vercukor_eredmeny = new MeresEredmeny("Vércukor", vercukor);
        MeresEredmeny vernyomas_eredmeny = new MeresEredmeny("Vérnyomás", vernyomas);
        MeresEredmeny pulzus_eredmeny = new MeresEredmeny("Pulzus", pulzus);

        listener.onMeresErtesites(vercukor_eredmeny);
        listener.onMeresErtesites(vernyomas_eredmeny);
        listener.onMeresErtesites(pulzus_eredmeny);
    }

    private List<MeresEredmeny> generateRandomMeresek(){
        List<MeresEredmeny> meresek = new ArrayList<>();
        for (IdosEmber idosEmber : idosEmberek){
            int vercukor = random.nextInt(300);
            int vernyomas = random.nextInt(200);
            int pulzus = random.nextInt(150);

            MeresEredmeny vercukor_eredmeny = new MeresEredmeny("Vércukor", vercukor);
            MeresEredmeny vernyomas_eredmeny = new MeresEredmeny("Vérnyomás", vernyomas);
            MeresEredmeny pulzus_eredmeny = new MeresEredmeny("Pulzus", pulzus);

            meresek.add(vercukor_eredmeny);
            meresek.add(vernyomas_eredmeny);
            meresek.add(pulzus_eredmeny);
        }
        return meresek;
    }
}