#pragma once
#define MUNKAGEP_HPP
#include "Jarmu.hpp"
#include <iostream>
#include <string>

using namespace std;

class Munkagep : public Jarmu {
private:
    int munkaNap;
    double rakottTonna;
    double napEgysegAr;
    double tonnaEgysegAr;
    string rendszam;

public:
    Munkagep(double napAr, double tonnaAr);
    double koltsegSzamitas() const override;
    void reszletekKiirasa() const override;
    void adatokBeallitasa(int nap, double tonna);
    virtual void setRendszam(const string&);
    virtual string getRendszam() const;
};


