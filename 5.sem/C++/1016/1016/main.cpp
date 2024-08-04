#include <iostream>

using namespace std;


void inc1(int a)
{
    ++a;
}

void inc2 (int *iptr)
{
    ++(*iptr);
}

void inc3(int &a)
{
    ++a;
}

void print(const int &r)
{
    int a = 3;
    cout<< "print: " << r <<endl;
    r = a; //hiba
    cout<< "print a: " << a << endl;
}

int main()
{
    //paraméter átadás


    int var1 = 1;
    inc1(var1);
    cout<<"var1: "<<var1<<endl;


    int var2 = 1;
    int *vptr = &var2;
    inc2(vptr);
    cout<<"var2: "<<var2<<endl;


    var2 = 1;
    inc2(&var2);
    cout<<"egyszerûbb var2: "<<var2<<endl;


    int var3 = 1;
    inc3(var3);
    cout<<"var3: "<<var3<<endl;


    print(var3);
    cout<<var3<<endl;
}
