#include <iostream>
#include "calc.hpp"
using namespace std;

/*
forditási lépések:
    0: precompiler
    1: fordító: modulonként
    2: linker

*/

int main()
{
    cout << add(3,4) << endl;
    cout << mul(3,4) << endl;

    return 0;
}
