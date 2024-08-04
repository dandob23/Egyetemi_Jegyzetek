#include <iostream>
#include <vector>
#include <string>

#include "Szemelygepkocsi.hpp"
#include "Busz.hpp"
#include "Teherauto.hpp"
#include "Munkagep.hpp"
#include "Autoberloceg.hpp"
#include "JarmuMuveletek.hpp"

using namespace std;

int main()
{
    AutoberloCeg autoberlo;

    //néhány jármû hozzáadása
    Szemelygepkocsi* szemelyauto1 = new Szemelygepkocsi(10.5, 50.0);
    szemelyauto1->adatokBeallitasa(100.0, 5);
    szemelyauto1->setRendszam("ABC123");
    autoberlo.jarmuHozzaadas(szemelyauto1);

    Szemelygepkocsi* szemelyauto2 = new Szemelygepkocsi(9.3, 48.66);
    szemelyauto2->adatokBeallitasa(150.0, 3);
    szemelyauto2->setRendszam("AGH163");
    autoberlo.jarmuHozzaadas(szemelyauto2);

    Busz* busz = new Busz (8.0, 40.0, 20.0);
    busz->adatokBeallitasa(200.0, 4, 30);
    busz->setRendszam("IGR762");
    autoberlo.jarmuHozzaadas(busz);

    Teherauto* teherauto = new Teherauto(12.0, 55.0, 15.0);
    teherauto->adatokBeallitasa(300.0, 6, 10.0);
    teherauto->setRendszam("PUL915");
    autoberlo.jarmuHozzaadas(teherauto);

    Munkagep* munkagep = new Munkagep(35.0, 25.0);
    munkagep->adatokBeallitasa(8, 3.0);
    munkagep->setRendszam("QWE678");
    autoberlo.jarmuHozzaadas(munkagep);


    //felhasználó által hozzáadás (A LISTA VEGEN LESZ)
    string rendszam;
    double alapAr;  // típustól függően lehet kmAr, vagy napiár
    int kapacitas; //típustól függően lehet napiár, vagy tonnaár
    char tipus;

    cout << "Adja meg a tipust (S - Szemelygepkocsi, B - Busz, T - Teherauto, M - Munkagep): ";
    cin>>tipus;

    cout << "Adja meg a rendszamot: ";
    cin>>rendszam;

    cout << "Szemelygepkocsi, Busz, Teherauto: kmAr"<<"\n"<< "Munkagep: napiar"<<"\n";
    cout << "Adja meg az alaparat: ";
    cin>>alapAr;

    cout << "Szemelygepkocsi, Busz: napiar"<<"\n"<<"Teherauto, Munkagep: tonnaar"<<"\n";
    cout << "Adja meg a megfelelo erteket: ";
    cin>>kapacitas;
    switch (tipus){
    case 'S':
        {
        double km;
        int nap;
        Szemelygepkocsi* switchauto = new Szemelygepkocsi(alapAr, kapacitas);
        cout << "Adja meg a megtett km-t: ";
        cin>>km;
        cout << "Adja meg a megkezdett napok szamat: ";
        cin>>nap;
        switchauto->adatokBeallitasa(km,nap);
        switchauto->setRendszam(rendszam);
        autoberlo.jarmuHozzaadas(switchauto);
        }
        break;

    case 'B':
        {
        double km;
        int nap;
        int szemelyek;
        Busz* switchbusz = new Busz(alapAr, kapacitas, 0.0);
        cout << "Adja meg a megtett km-t: ";
        cin>>km;
        cout << "Adja meg a megkezdett napok szamat: ";
        cin>>nap;
        cout << "Adja meg az osszes szallitott szemelyt: ";
        cin>>szemelyek;
        switchbusz->adatokBeallitasa(km, nap, szemelyek);
        switchbusz->setRendszam(rendszam);
        autoberlo.jarmuHozzaadas(switchbusz);
        }
        break;

    case 'T':
        {
        double km;
        int nap;
        double tonna;
        Teherauto* switchtehera = new Teherauto(alapAr, 0.0, kapacitas);
        cout << "Adja meg a megtett km-t: ";
        cin>>km;
        cout << "Adja meg a megkezdett napok szamat: ";
        cin>>nap;
        cout << "Adja meg az osszes szallitott tonnat: ";
        cin>>tonna;
        switchtehera->adatokBeallitasa(km, nap, tonna);
        switchtehera->setRendszam(rendszam);
        autoberlo.jarmuHozzaadas(switchtehera);
        }
        break;

    case 'M':
        {
        int nap;
        double tonna;
        Munkagep* switchmunka = new Munkagep(alapAr, kapacitas);
        cout << "Adja meg a megkezdett napok szamat: ";
        cin>>nap;
        cout << "Adja meg az osszes szallitott tonnat: ";
        cin>>tonna;
        switchmunka->adatokBeallitasa(nap, tonna);
        switchmunka->setRendszam(rendszam);
        autoberlo.jarmuHozzaadas(switchmunka);
        }
        break;

    default:
        cerr<<"Ismeretlen tipus!"<< endl;
        break;
    }


    //jelenlegi lista kiírása
    cout<<" ------------- A lista jelenleg: ------------- "<< endl;
    autoberlo.jarmuListaKiirasa();
    cout<<" --------------------------------------------- "<<"\n"<<endl;

    cout<<"\n"<<" ------------- Kereses rendszam alapjan: ------------- "<< endl;
    //keresés rendszám alapján
    autoberlo.keresesRendszamAlapjan("AGH163");//helyes rendszám
    autoberlo.keresesRendszamAlapjan("AAA111");//helytelen rendszám
    cout<<" ------------------------------------------------------------ "<<"\n"<<endl;

    cout<<"\n"<<" ------------- Koltseg szamitas rendszam alapjan: ------------- "<< endl;
    //költség rendszám alapján
    autoberlo.koltsegSzamitasRendszamAlapjan("ABC123"); //helyes rendszám
    autoberlo.koltsegSzamitasRendszamAlapjan("ZZZ999"); //helytelen rendszám
    cout<<" -------------------------------------------------------------------- "<<"\n"<<endl;

    cout<<"\n"<<" ------------- Jarmu torles rendszam alapjan: ------------- "<< endl;
    string torlendoRendszam;
    cout<<"Adja meg a torlendo autot: ";
    cin>>torlendoRendszam;

    autoberlo.jarmuTorlese(torlendoRendszam);
    cout<<"\n"<<" Az uj lista a torles utan... "<<"\n"<<endl;
    autoberlo.jarmuListaKiirasa();
    cout<<" -------------------------------------------------------------------- "<<"\n"<<endl;





    //muveletek
    /*
    int valasztas;

    cout<<"Valassz muveletet: "<<endl;
    cout<<"1. Arajanlat "<<endl;
    cout<<"2. Kiadas "<<endl;
    cout<<"3. Visszavetel "<<endl;
    cout<<"4. Torles "<<endl;
    cout<<"Valassz: "<<endl;
    cin>>valasztas;

    switch(valasztas){
    case 1:
        JarmuMuveletek::arajanlat();
        break;

    case 2:
        JarmuMuveletek::kiadas();
        break;

    case 3:
        JarmuMuveletek::visszavetel();
        break;

    case 4:
        JarmuMuveletek::torles();
        break;

    default:
        cout<< "Ervenytelen valasztas!" <<endl;
        break;
    }
    */
    return 0;
}
