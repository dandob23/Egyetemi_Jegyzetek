#pragma once
#define AUTOBERLOCEG_HPP
#include "Jarmu.hpp"
#include <iostream>
#include <string>
#include <vector>

class AutoberloCeg {
private:
    std::vector<Jarmu*> jarmuvek;

public:
    Jarmu* keresesRendszamAlapjan(const std::string& rendszam) const;
    double koltsegSzamitasRendszamAlapjan(const std::string& rendszam) const;
    void jarmuHozzaadas(Jarmu* jarmu);
    void jarmuListaKiirasa() const;
    void jarmuMuveletek();
    void arajanlat(Jarmu* jarmu);
    void kiadas(Jarmu* jarmu);
    void visszavetel(Jarmu* jarmu);
    void torles(Jarmu* jarmu);
    void jarmuTorlese(const std::string& rendszam);
};
