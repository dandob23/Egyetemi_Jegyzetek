#include "house.hpp"

int House::calculateValue(int costInternal, int costLand)
{
    return costInternal * areaInternal_m + costLand * areaLand_m;
}
