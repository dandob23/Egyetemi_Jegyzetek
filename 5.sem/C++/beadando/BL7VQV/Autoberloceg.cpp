#include "Autoberloceg.hpp"

//jármû hozzáadása az autók listájához
void AutoberloCeg::jarmuHozzaadas(Jarmu* jarmu) {
    jarmuvek.push_back(jarmu);
}

//részletek kiírása és a költség kiszámításának leírása
void AutoberloCeg::jarmuListaKiirasa() const {
    for (const auto& jarmu : jarmuvek) {
        jarmu -> reszletekKiirasa();
        std::cout << "Becsult kolcsonzesi dij: " << jarmu ->koltsegSzamitas() << std::endl;
    }
}


//rendszám alapján keresés
Jarmu* AutoberloCeg::keresesRendszamAlapjan(const std::string& rendszam) const {
    for(auto jarmu : jarmuvek) {
            if(jarmu->getRendszam() == rendszam){
                std::cout <<"A jarmu letezik: ( " << rendszam << " )." << std::endl;
                return jarmu;
            }
    }
    std::cout <<"\n"<<"Nincs ilyen rendszam a listaban: ( " << rendszam << " )." << std::endl;
    return nullptr; // ha nincs ilyen rendszám
}



//rendszám alapján költség számolás
double AutoberloCeg::koltsegSzamitasRendszamAlapjan(const std::string& rendszam) const {
    Jarmu* keresettJarmu = keresesRendszamAlapjan(rendszam);
    if(keresettJarmu) {
        double koltseg = keresettJarmu->koltsegSzamitas();
        std::cout <<"\n"<<"Koltseg a rendszam alapjan ( " << rendszam << " ): " << koltseg << std::endl;
        return koltseg;
    }
    std::cout <<"\n"<<"Nincs ilyen rendszam a listaban: ( " << rendszam << " )." << std::endl;
    return 0.0;
}

//rendszám alapján törlés az autok vector-ból
void AutoberloCeg::jarmuTorlese(const std::string& rendszam){
    auto iter=std::remove_if(jarmuvek.begin(), jarmuvek.end(),
        [rendszam](Jarmu* jarmu) {
            return jarmu->getRendszam() == rendszam;
        });

    jarmuvek.erase(iter, jarmuvek.end());
}



