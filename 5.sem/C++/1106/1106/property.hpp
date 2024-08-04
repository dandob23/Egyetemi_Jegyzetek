#pragma once
#include <string>
#include "address.hpp"
using std::string;

class Property
{
public:
    Property(Address addr): address_m(addr) {}
    virtual ~Property() {}
    virtual int calculateValue(int costInternal, int costLand) =0;
    Address& address() {return address_m;}
private:
    Address address_m;
};
