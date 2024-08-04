/*
jegyzet:

logikai operátorok:
    &&  és
    ||  vagy
    !   not
    ==  egyenlõ
    !=  nem egyenlõ

bitenkénti operátorok:
    &
    |
    ~  negálás
    ^  xor

*/

#include <iostream>

using namespace std;

int main()
{
    //WARNING-RA FIGYELNI --> BUILD LOG/BUILD MESSAGES
    int a = 0xaa;
    int b = 0x55;
    cout << "a: " <<' '<< a << endl;
    cout << "b: " <<' '<< b << endl;
    cout << "------------" << endl;
    //hiba 1 ( && vagy & )
    cout << "a&&b: " << endl;
    cout << (a&&b) << endl;
    cout << "------------" << endl;
    cout << "a&b: " << endl;
    cout << (a&b) << endl;
    cout << "------------" << endl;
    cout << "------------" << endl;


    //hiba 2 ( == vagy = )
    if(a == 0xaa)
        cout<< "true" <<endl;
    else
        cout<<"false"<<endl;
    cout << "------------" << endl;
    cout << "------------" << endl;


    //hiba 3 ( signed és unsinged összehasonlítás )
    signed int s = -1;
    unsigned int u = 1;
    if((int)u > (int)s)
        cout<< "1 nagyobb mint -1"<<endl;
    else
        cout<<"-1 nagyobb mint 1"<<endl;




    /*
    Kifejezések:
    |
    |-> visszatérõ érték
    |
    |-> mellékhatás

    Aritmetikai: + - * / %  (nincs mellékhatás)
                 ++ --      (van mellékhatás)
                 += -=      (van mellékhatás)

    */
    return 0;
}
