#include <iostream>

using namespace std;

int main()
{
    /*
    Pointer vagy mutató



    */


    int alma = 10;
    int korte = 20;

    int *iptr;

    iptr = &alma;

    cout<<*iptr<<endl;
    cout<<"----------"<<endl;
    ++ (*iptr); //alma-n hajtjuk vegre
    cout<< "alma: " <<alma<< ' ' <<"korte: " << korte <<endl;


    cout<<"----------"<<endl;
    iptr = &korte;
    ++ (*iptr); //korte-n hajtjuk vegre
    cout<< "alma: " <<alma<< ' ' <<"korte: " << korte <<endl;


    cout<<"----------"<<endl;
    //pointer aritmetika
    iptr = &korte;
    ++iptr; //magat az iptr-t noveljuk


    cout<<"----------"<<endl;
    ++ (*iptr); //korte-n hajtanank vegre, de a ++iptr miatt fentebb lépett az almara
    cout<< "alma: " <<alma<< ' ' <<"korte: " << korte <<endl;

    return 0;
}
