#include <iostream>
using namespace std;
template <typename P, typename Comparator >
class Search {
public:
    P operator()(P first, P beyond, Comparator comp){
        P p = beyond;
        P before = first - 1;
        while (p != before && !comp(*p)){
            p--;
        }
        return p;
    }
};


bool IsThree(int i){
    return  i == 3;
}

int main() {
    cout<<"Create an array with 100 objects (a[100])"<<endl;
    int a[100];
    for(auto &p:a){
        p = 1;
    }
    cout<<"Initialize all values of array as 1. a[i] = 1, for i = 0 to 99."<<endl;
    cout<<"Let's assign a[40] as 3. a[40] = 3"<<endl;
    a[40] = 3;
    cout<<"Address of a[40] is: "<<&a[40]<<endl;
    cout<<"Create function object 'find'"<<endl;
    cout<<"Call find(a,&a[100],IsThree), where IsThree is a function that return true if value is equal 3"<<endl;
    Search<int*,bool(int)> find;
    int *res = find(a,&a[100],IsThree);
    cout<<"returned value equal: "<<*res<<" the address is: "<<res<<endl;
    cout<<"We have found the same object with template functional object 'find' !";

}
