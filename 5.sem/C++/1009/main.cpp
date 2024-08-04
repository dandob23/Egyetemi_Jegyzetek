#include <iostream>
#include <string.h>

using namespace std;

int main()
{
    const char *text = "Hello ";
    const char *text2 = "World";
    //cout<< text3 << endl;
    //const char *text3 = text + text2;  //ERROR


    char buffer1[40] = "Hello ";
    char buffer2[] = "World ";
    char buffer3[40];
    //buffer3 = buffer1 + buffer2;

    strcat (buffer1, buffer2);
    strncat (buffer1, "!!!", 28);
    size_t len = strlen(buffer1);


    cout<<buffer1<< " " << len <<endl;

    string firstName = "Joe";
    string lastName = "Mama";

    string name = firstName + " " + lastName;

    cout<<name<<endl;

    return 0;
}
