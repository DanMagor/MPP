/*
Come up with several examples of using Range template. Demonstrate the use of
the functionality. Provide readable output.
*/
#include <iostream>
#include "Range.h"

int main() {
    std::cout<<"Range<int,0,5> a(4)"<<std::endl;
    Range<int,0,5> a(4), b(1);
    std::cout << "a + b = " << (a+b).getVal() << std::endl;
    std::cout << "++a = " << (++a).getVal() << std::endl;

/*

    bool isALess;
    std::cout<<"a+b="<< (a+b).getVal()<<std::endl;
    std::cout<<"a value before a++ : "<<a.getVal()<<std::endl;
    a++;
    std::cout<<"a value after a++ : "<<a.getVal()<<std::endl;

    std::cout<<"b value before --b : "<<b.getVal()<<std::endl;
    --b;
    std::cout<<"b value after --b : "<<b.getVal()<<std::endl;

    std::cout<<"b value after b-=4 : "<<b.getVal()<<std::endl;
    isALess = a<b;
    std::cout<< "Is A less: "<< isALess<<std::endl;

    (long)b;
    Range<int,1,10> db(9);
    std::cout<<"db value before long(db): "<<db.getVal()<<std::endl;
    (long)db;
    std::cout<<"db value after long(db) : "<<db.getVal()<<std::endl;
*/

    return 0;
}