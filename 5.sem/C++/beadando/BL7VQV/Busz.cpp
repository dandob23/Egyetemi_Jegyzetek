#include "Busz.hpp"
#include <iostream>

Busz::Busz(double kmAr, double napiAr, double biztositasDij) : kmEgysegAr(kmAr), napiEgysegAr(napiAr), szemelyBiztositasDija(biztositasDij) {}

//Busz költség számítása
double Busz::koltsegSzamitas() const {
    return kmEgysegAr * megtettKilometer + napiEgysegAr * megtettNap + szemelyBiztositasDija * szallitottSzemelyek;
}

void Busz::reszletekKiirasa() const {
    std::cout<<"\n"<<"Jarmu tipusa: Busz" << std::endl;
}

void Busz::adatokBeallitasa(double km, int nap, int szemelyek) {
    megtettKilometer = km;
    megtettNap = nap;
    szallitottSzemelyek = szemelyek;
}

std::string Busz::getRendszam() const {
    return rendszam;
}

void Busz::setRendszam(const std::string& newRendszam) {
    rendszam = newRendszam;
}
