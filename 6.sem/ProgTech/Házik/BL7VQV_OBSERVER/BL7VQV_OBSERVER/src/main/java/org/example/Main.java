package org.example;

public class Main {
    public static void main(String[] args) {

        Gondosora gondosora = new Gondosora();


        Orvos orvos1 = new Orvos("Dr. House");
        Orvos orvos2 = new Orvos("Dr. Dolittle");
        Mentos mentos1 = new Mentos("Mentős 1", "123 Random Street");
        Mentos mentos2 = new Mentos("Mentős 2", "456 Main Street");
        IdosEmber idosEmber1 = new IdosEmber("Idős ember 1", "789 Elm Street");
        IdosEmber idosEmber2 = new IdosEmber("Idős ember 2", "951 London Street");

        gondosora.addListener(orvos1);
        gondosora.addListener(orvos2);
        gondosora.addListener(mentos1);
        gondosora.addListener(mentos2);
        gondosora.addListener(idosEmber1);
        gondosora.addListener(idosEmber2);


        gondosora.removeListener(idosEmber1);
        gondosora.removeListener(idosEmber2);

        gondosora.merni();
    }
}