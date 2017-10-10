#include <iostream>

using namespace std;

#include "Array.hpp"
#include "List.hpp"
#include "Stack.hpp"

int main() {
    Stack<int,Array> a;
    Stack<int,List> b;
    a.push(1);
    a.push(2);
    a.push(3);
    b.push(3);
    b.push(2);
    b.push(1);
    cout<<a.pop()<<" ";
    cout<<a.pop()<<" " ;
    cout<<a.pop()<<" " ;
    cout<<a.pop()<<" " ;
    cout<<a.pop()<<" " <<endl;
    Stack<int, List> c(b);
    cout<<c.pop()<<" ";
    cout<<c.pop()<<" ";
    cout<<c.pop()<<" ";
    cout<<c.pop()<<" ";
    cout<<c.pop()<<" ";

    return 0;
}



