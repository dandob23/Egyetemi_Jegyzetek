#pragma once
#include "address.hpp"
#include "property.hpp"

class House: public Property
{
public:
    House(Address a, int areaInternal, int areaLand):
        Property(a),
        areaInternal_m(areaInternal),
        areaLand_m(areaLand)
        {}
    int calculateValue(int costInternal, int costLand);
private:
    int areaInternal_m;
    int areaLand_m;
};
