#pragma once
#define BUSZ_HPP
#include "Jarmu.hpp"
#include <iostream>
#include <string>

using namespace std;

class Busz : public Jarmu {
private:
    double megtettKilometer;
    int megtettNap;
    int szallitottSzemelyek;
    double kmEgysegAr;
    double napiEgysegAr;
    double szemelyBiztositasDija;
    string rendszam;

public:
    Busz(double kmAr, double napiAr, double biztositasDij);
    double koltsegSzamitas() const override;
    void reszletekKiirasa() const override;
    void adatokBeallitasa(double km, int nap, int szemelyek);
    virtual void setRendszam(const string&);
    virtual string getRendszam() const;
};
