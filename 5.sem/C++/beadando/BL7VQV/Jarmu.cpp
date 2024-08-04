#include "Jarmu.hpp"
#include <iostream>

//Jarmu::Jarmu(const std::string& rendszam) : rendszam(rendszam), alapAr(0.0), kiadas(false){}

double Jarmu::getAr() const {
    return alapAr;
}

bool Jarmu::getKiadas() const {
    return kiadas;
}

void Jarmu::adatokBeallitasa(double ujAr, bool kiadva){
    alapAr = ujAr;
    kiadas = kiadva;
}

void Jarmu::adatokKiirasa() const {
    cout<<"Rendszam: "<<rendszam<<endl;
    cout<<"Ar: "<<alapAr<<endl;
    cout<<"Kiadva: "<<(kiadas ? "igen" : "nem")<<endl;
}

void Jarmu::setKiadas(bool kiadva) {
    kiadas = kiadva;
}

string Jarmu::getRendszam() const {
    return rendszam;
}
void Jarmu::setRendszam(const std::string& newRendszam) {
    rendszam = newRendszam;
}

double Jarmu::koltsegSzamitas() const {
    return 0.0;
}

void Jarmu::reszletekKiirasa() const {
    std::cout << "Alapertelmezett Jarmu" << std::endl;
}
