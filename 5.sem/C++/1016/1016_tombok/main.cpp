#include <iostream>

using namespace std;

#define ARR_SIZE 6

const int ArrSize= 6;

void print1(const int *t, int s)
{
    for(int i = 0; i < s; ++i)
    {
        cout << t[i] << ", " << endl;
    }

    cout << endl;
}

void print2(const int t[s]) //tömbméret opcionális
{
    for(int i = 0; i < 10; ++i)
    {
        cout << t[i] << ", " << endl;
    }

    cout << endl;
}

const int Rows = 3;
const int Colums = 4;
void printMtx1 (const int a [Rows][Colums])
{
    for(int i = 0; i < Rows; ++i)
    {
        cout<<endl;
        for (int j = 0; j<Colums; ++j){
            cout<<a [i][j]<< ", "
        }
    }
}

int main()
{
    int arr[ARR_SIZE] = {1, 2, 3, 4};
    print1(arr,ARR_SIZE);
    print2(arr,í ARR_SIZE);

    int mtx [Rows][Colums] = {1,2,3,4,5,6,7,8,9,10,11,12}
    printMtx1(mtx)

    return 0;
}
