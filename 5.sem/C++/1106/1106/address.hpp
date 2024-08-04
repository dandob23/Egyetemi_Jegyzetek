#pragma once

#include  <string>
#include <iostream>

using std::string;
using std::ostream;

//class Address;
//ostream& operator << (ostream&, Address&);

class Address
{
public:
    Address(int number, string street, string settlement):
        number_m(number),
        street_m(street),
        settlement_m(settlement)
        {}
    /*
    {
        number_m = number;
        street_m = street;
        settlement_m = settlement;
    }
    */

    int number() {return number_m;}
    string street() {return street_m;}
    string settlement() {return settlement_m;}
private:
    int number_m;
    string street_m;
    string settlement_m;
};

ostream& operator << (ostream&, Address&);
