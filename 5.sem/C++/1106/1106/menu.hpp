#pragma once

#include "property.hpp"
#include <vector>

using std::vector;

class Menu
{
public:
    ~Menu();
    void exec();

private:
    void newHouse();
    void newFlat();
    void ListProperties();
    vector<Property*> storage_m;
};
