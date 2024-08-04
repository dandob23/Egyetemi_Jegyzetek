/*
jegyzet:

std output:  cout << var;
std input:  cin >> var;
std error:  cerr << var;

#include <iostream>
névtér:  std

Literál:
 int A = 12;
         0x0F; 0x0f

 unsigned int A = 12U;
 long int B = 12L;
 char Letter = 'A';




*/


#include <iostream>

//using namespace std;
using std::cout;

int main()
{
    //nagyobb típus nagyobba: csonkolás
    unsigned int A;
    A=65535;  //0xffff

    char letter3 = 0x20;  //' '

    letter3 = A;

    cout << A <<':'<< (int)letter3 <<std::endl;

    /*
    char letter1 = 'A';
    char letter2 = -3;
    int B = letter1;
    cout << "Hello World"<<' '<< (int)letter3 << std::endl;
    */


    const int C = 8;
    // C = 10;


    //lebegõpontos
    const double PI = 3.14;
    const double AVO = 6.0e23;

    double area = 2*3.22*PI;
    cout << area << std::endl;


    float n = 2.32;

    // Alap operátorok
    //  + -  összeadás, kiadás
    //  *    szorzás
    //  /    osztás (egész vagy lebegõpontos)

    //Osztás:
    int D = 4, E = 3;

    double dF;
    dF = D / E;

    cout << "Egesz osztas" <<' '<< dF << std::endl;


    double dG;
    dG = (double)D / E;

    cout << "Lebegopontos osztas" <<' '<< dG << std::endl;


    //Szorzás:
    unsigned char uc1 = 0x80;
    unsigned char uc2 = 0x02;
    unsigned char uc3 = uc1*uc2;

    cout << "Egesz szorzas" <<' '<< (int)uc3 << std::endl;

    //Bool:
    bool flagA=true;
    bool flagB=false;
    bool flagC=flagA && flagB;

    cout << "Bool" <<' '<< flagC << std::endl;


    int H = 10;
    flagC = true && H;
    cout << "Bool && int" <<' '<< flagC << std::endl;

    return 0;
}
