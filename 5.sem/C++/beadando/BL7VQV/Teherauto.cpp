#include "Teherauto.hpp"
#include <iostream>

Teherauto::Teherauto(double kmAr, double napiAr, double tonnaAr) : kmEgysegAr(kmAr), napiEgysegAr(napiAr), tonnaEgysegAr(tonnaAr) {}

//teherautó költség számítása
double Teherauto::koltsegSzamitas() const {
    return kmEgysegAr * megtettKilometer + napiEgysegAr * megtettNap + tonnaEgysegAr * szallitottTonna;
}

void Teherauto::reszletekKiirasa() const {
    std::cout<<"\n"<<"Jarmu tipusa: Teherauto" << std::endl;
}

void Teherauto::adatokBeallitasa(double km, int nap, double tonna) {
    megtettKilometer = km;
    megtettNap = nap;
    szallitottTonna = tonna;
}

std::string Teherauto::getRendszam() const {
    return rendszam;
}

void Teherauto::setRendszam(const std::string& newRendszam) {
    rendszam = newRendszam;
}
