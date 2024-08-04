#pragma once
#define SZEMELYGEPKOCSI_HPP
#include "Jarmu.hpp"
#include <iostream>
#include <string>

using namespace std;

class Szemelygepkocsi : public Jarmu {

private:

    double kmEgysegAr;
    double napiEgysegAr;
    double megtettKilometer;
    int megtettNap;
    string rendszam;

public:

    Szemelygepkocsi(double kmAr, double napiAr);
    double koltsegSzamitas() const override;
    void reszletekKiirasa() const override;
    void adatokBeallitasa(double km, int nap);
    virtual void setRendszam(const string&);
    virtual string getRendszam() const;
};
