#pragma once
#define TEHERAUTO_HPP
#include "Jarmu.hpp"
#include <iostream>
#include <string>

using namespace std;

class Teherauto : public Jarmu {
private:
    double megtettKilometer;
    int megtettNap;
    double szallitottTonna;
    double kmEgysegAr;
    double napiEgysegAr;
    double tonnaEgysegAr;
    string rendszam;

public:
    Teherauto(double kmAr, double napiAr, double tonnaAr);
    double koltsegSzamitas() const override;
    void reszletekKiirasa() const override;
    void adatokBeallitasa(double km, int nap, double tonna);
    virtual void setRendszam(const string&);
    virtual string getRendszam() const;
};
