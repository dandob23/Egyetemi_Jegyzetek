#pragma once
#define JARMU_HPP
#include <algorithm>
#include <iostream>
#include <string>

using namespace std;

class Jarmu {

protected:
    string rendszam;

public:
    //Jarmu(const std::string& rendszam); //rendszam beallitasa
    double getAr() const;
    bool getKiadas() const;
    void adatokBeallitasa(double ar, bool kiadva);
    void adatokKiirasa() const;
    void setKiadas(bool kiadva);
    virtual double koltsegSzamitas() const = 0;
    virtual void reszletekKiirasa() const = 0;
    virtual string getRendszam() const = 0;
    virtual void setRendszam(const string& newRendszam);
    virtual ~Jarmu() {}
    double alapAr;
    bool kiadas;
};
