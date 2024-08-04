#include "Munkagep.hpp"
#include <iostream>

Munkagep::Munkagep(double napAr, double tonnaAr) : napEgysegAr(napAr), tonnaEgysegAr(tonnaAr) {}

//munkag�p k�lts�g sz�m�t�sa
double Munkagep::koltsegSzamitas() const {
    return napEgysegAr * munkaNap + tonnaEgysegAr * rakottTonna;
}

void Munkagep::reszletekKiirasa() const {
    std::cout<<"\n"<<"Jarmu tipusa: Munkagep" << std::endl;
}

void Munkagep::adatokBeallitasa(int nap, double tonna) {
    munkaNap = nap;
    rakottTonna = tonna;
}

std::string Munkagep::getRendszam() const {
    return rendszam;
}

void Munkagep::setRendszam(const std::string& newRendszam) {
    rendszam = newRendszam;
}
