#include "address.hpp"
#include <iostream>

using namespace std;

ostream& operator << (ostream &s, Address &a)
{
    s << a.number() << " " << a.street() << " " << a.settlement();
    return s;
}
