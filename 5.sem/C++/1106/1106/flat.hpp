#pragma once
#include "address.hpp"
#include "property.hpp"

class Flat: public Property
{
public:
    Flat(Address a, int areaInternal):
        Property(a),
        areaInternal_m(areaInternal)
        {}
    int calculateValue(int costInternal, int costLand);
private:
    int areaInternal_m;
};
