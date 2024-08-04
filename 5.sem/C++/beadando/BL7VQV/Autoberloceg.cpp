#include "Autoberloceg.hpp"

//j�rm� hozz�ad�sa az aut�k list�j�hoz
void AutoberloCeg::jarmuHozzaadas(Jarmu* jarmu) {
    jarmuvek.push_back(jarmu);
}

//r�szletek ki�r�sa �s a k�lts�g kisz�m�t�s�nak le�r�sa
void AutoberloCeg::jarmuListaKiirasa() const {
    for (const auto& jarmu : jarmuvek) {
        jarmu -> reszletekKiirasa();
        std::cout << "Becsult kolcsonzesi dij: " << jarmu ->koltsegSzamitas() << std::endl;
    }
}


//rendsz�m alapj�n keres�s
Jarmu* AutoberloCeg::keresesRendszamAlapjan(const std::string& rendszam) const {
    for(auto jarmu : jarmuvek) {
            if(jarmu->getRendszam() == rendszam){
                std::cout <<"A jarmu letezik: ( " << rendszam << " )." << std::endl;
                return jarmu;
            }
    }
    std::cout <<"\n"<<"Nincs ilyen rendszam a listaban: ( " << rendszam << " )." << std::endl;
    return nullptr; // ha nincs ilyen rendsz�m
}



//rendsz�m alapj�n k�lts�g sz�mol�s
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

//rendsz�m alapj�n t�rl�s az autok vector-b�l
void AutoberloCeg::jarmuTorlese(const std::string& rendszam){
    auto iter=std::remove_if(jarmuvek.begin(), jarmuvek.end(),
        [rendszam](Jarmu* jarmu) {
            return jarmu->getRendszam() == rendszam;
        });

    jarmuvek.erase(iter, jarmuvek.end());
}



