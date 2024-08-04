#include "Szemelygepkocsi.hpp"
#include <iostream>

Szemelygepkocsi::Szemelygepkocsi(double kmAr, double napiAr) : kmEgysegAr(kmAr), napiEgysegAr(napiAr) {}

//személygépkocsi költség számítása
double Szemelygepkocsi::koltsegSzamitas() const {
    return kmEgysegAr * megtettKilometer + napiEgysegAr * megtettNap;
}

void Szemelygepkocsi::reszletekKiirasa() const {
    std::cout<<"\n"<<"Jarmu tipusa: Szemelygepkocsi" << std::endl;
}

void Szemelygepkocsi::adatokBeallitasa(double km, int nap) {
    megtettKilometer = km;
    megtettNap = nap;
}

void Szemelygepkocsi::setRendszam(const std::string& newRendszam) {
    rendszam = newRendszam;
}

std::string Szemelygepkocsi::getRendszam() const {
    return rendszam;
}
