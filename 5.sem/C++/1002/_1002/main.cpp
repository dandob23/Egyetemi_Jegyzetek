/*
jegyzet:

logikai oper�torok:
    &&  �s
    ||  vagy
    !   not
    ==  egyenl�
    !=  nem egyenl�

bitenk�nti oper�torok:
    &
    |
    ~  neg�l�s
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


    //hiba 3 ( signed �s unsinged �sszehasonl�t�s )
    signed int s = -1;
    unsigned int u = 1;
    if((int)u > (int)s)
        cout<< "1 nagyobb mint -1"<<endl;
    else
        cout<<"-1 nagyobb mint 1"<<endl;




    /*
    Kifejez�sek:
    |
    |-> visszat�r� �rt�k
    |
    |-> mell�khat�s

    Aritmetikai: + - * / %  (nincs mell�khat�s)
                 ++ --      (van mell�khat�s)
                 += -=      (van mell�khat�s)

    */
    return 0;
}
