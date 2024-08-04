#include "menu.hpp"
#include <iostream>
#include "address.hpp"
#include "house.hpp"
#include "flat.hpp"
using namespace std;

void Menu::exec()
{
    cout << "Real Estate Management V1.0" << endl;

    bool isRunning = true;
    int selectionMainMenu;
    while (isRunning)
    {
        cout << endl;
        cout << "1: New House" << endl << "2: New Flat" << endl << "3: List" << endl << "0: Exit" << endl;
        cout << "Selection: ";
        cin >> selectionMainMenu;

        switch (selectionMainMenu)
        {
        case 1:
            newHouse();
            break;

        case 2:
            newFlat();
            break;

        case 3:
            ListProperties();
            break;

        case 0:
            isRunning = false;
            break;

        default:
            cout << "Wrong input..." << endl;
            break;
        }
    }
}


void Menu::newHouse()
{
    int num;
    string street, settlement;
    int internalArea, landArea;

    cout<<"Adding new house..." << endl << "Location? " << endl;
    cout << "Number: ";
    cin >> num;

    cout << "Street: ";
    cin >> street;

    cout << "Settlement: ";
    cin>> settlement;

    Address addr(num, street, settlement);
    cout << addr;

    cout << "Inner are: ";
    cin >> internalArea;

    cout << "Land area: ";
    cin >> landArea;

    storage_m.push_back(new House(addr, internalArea, landArea));

}
void Menu::newFlat()
{
    int num;
    string street, settlement;
    int internalArea;

    cout<<"Adding new flat..." << endl << "Location? " << endl;
    cout << "Number: ";
    cin >> num;

    cout << "Street: ";
    cin >> street;

    cout << "Settlement: ";
    cin>> settlement;

    Address addr(num, street, settlement);
    cout << addr;

    cout << "Inner are: ";
    cin >> internalArea;


    storage_m.push_back(new Flat(addr, internalArea));
}
void Menu::ListProperties()
{
    int landc,inc;
    cout << "cost of ..." << endl << "Land: ";
    cin >> landc;
    cout << "Internal: ";
    cin>> inc;
    for(Property *p : storage_m)
        {
            cout << p-> address() << " Market value: " << p -> calculateValue(inc, landc);
        }
}

Menu::~Menu()
{
    for(Property *p : storage_m)
        delete p;
}
