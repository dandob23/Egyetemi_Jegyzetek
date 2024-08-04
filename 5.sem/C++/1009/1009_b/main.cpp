#include <iostream>

using namespace std;

int alma_g = 36;

int add(int a, int b)
{
    int c = a + b;
    return c;
}
void print (int a)
{
    cout << a << endl;
}

void step()
{
    static int stp;

    cout<<++stp<<endl;
}

int main()
{
    cout<< add (3, 5) << endl;
    cout<< "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-="<< endl;
    print(6);
    cout<< "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-="<< endl;
    cout<< alma_g<< endl;
    cout<< "=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-="<< endl;
    for(int i = 0; i < 10; ++i){
        step();
    }


    return 0;
}
