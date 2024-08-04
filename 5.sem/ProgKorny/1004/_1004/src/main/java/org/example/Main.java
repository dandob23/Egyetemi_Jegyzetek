package org.example;

import gepkocsik.*;

public class Main {
    public static void main(String[] args) throws Exception
    {
        Gepkocsi gk = new Gepkocsi("ABC-123", 2021, 300001, Allapot.MEGKIMELT);

        System.out.println(gk);
    }
}