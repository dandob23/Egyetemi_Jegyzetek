/*
#include "JarmuMuveletek.hpp"
#include "Autoberloceg.hpp" // a jármûvek típusa miatt
#include <iostream>
using namespace std;

void JarmuMuveletek::jarmuMuveletek(){
    string rendszam;
    cout<<"Kerem adja meg a rendszamot: ";
    cin>>rendszam;

    Jarmu* keresettJarmu = keresesRendszamAlapjan(rendszam);

    if(keresettJarmu){
        cout<<"Jarmu megtalalva: "<<rendszam << endl;
        cout<<"Valasszon muveletet: \n";
        cout<< "1. Arajanlat\n2. Kiadas\n3. Visszavetel\n4. Torles\n";
        int muvelet;
        cin>>muvelet;

        switch(muvelet){
        case 1:
            arajanlat(keresettJarmu);
            break;

        case 2:
            kiadas(keresettJarmu);
            break;

        case 3:
            visszavetel(keresettJarmu);
            break;

        case 4:
            torles(keresettJarmu);
            break;

        default:
            cout<<"Ervenytelen muvelet!"<<endl;
            break;
        }
    }else{
        cout<<"Nincs ilyen rendszamu jarmu az adatbazisban!" <<endl;
    }
}

void JarmuMuveletek::arajanlat(Jarmu* jarmu){
    const double szazalek = 0.9;
    double ar = jarmu->getAr();//----
    double kedvezmenyAr = ar*szazalek;
    cout<<"Jarmu ara: "<<ar<<endl;
    cout<<"Arajanlatunk: (10%)"<<endl;
    cout<<"Igy az uj ar: "<<kedvezmenyAr<<endl;
}

void JarmuMuveletek::kiadas(Jarmu* jarmu){
    double ar = jarmu->alapAr;
    bool kiadva = jarmu->kiadas;
    if(jarmu->getKiadas()){
        cout << "A " <<jarmu ->getRendszam() << " rendszamu jarmu mar ki van adva" <<endl;
    } else {
        jarmu->adatokBeallitasa(ar, kiadva);
        cout<< "Jarmu kiadva! Uj adatok:\n";
        jarmu->adatokKiirasa();
        jarmu->setKiadas(true);
    }
}

void JarmuMuveletek::visszavetel(Jarmu* jarmu){
    if(!jarmu->getKiadas()){
        cout<<"A "<<jarmu->getRendszam() << " rendszamu jarmu nincs kiadva!"<<endl;
    } else{
        cout<<"Jarmu "<<jarmu->getRendszam() << " visszavetve!" << endl;
        jarmu->setKiadas(false);
    }
}

void JarmuMuveletek::torles(Jarmu* jarmu){
    auto torlendo = find(jarmuvek.begin(), jarmuvek.end(), jarmu);
    if (torlendo != jarmuvek.end()){
        jarmuvek.erase(torlendo);
        cout<<"Jarmu "<<jarmu->getRendszam() << " torolve!" <<endl;
        delete jarmu;
    }
}
*/
