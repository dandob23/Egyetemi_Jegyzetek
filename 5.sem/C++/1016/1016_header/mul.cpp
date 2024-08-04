#include "calc.hpp"

int mul(const int a, const int b)
{
    int retval = 0;
        for(int i=0; i<b; ++i)
        {
            retval = add(retval, a);
        }
        return retval;

}
