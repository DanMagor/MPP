/*
Write an implementation of class Array that uses the idea of the class Range to
allow for arbitrary indexing ranges. The template for class Array should accept
the following parameters:
1. Type of objects in Array
2. Lower bound for the index, i.e. the minimum valid value of index
3. Upper bound for the index, i.e. the maximum valid value of index

The values of upper and lower bounds are assumed to be valid and no
additional checks are required.

You need to overload the operator [], so that it accepts any integer value as
an index and performs boundary checks. Should the index be out of boundary,
throw the std::runtime_error exception.

Additional methods to be implemented:
1. size() returns number of elements
2. getLB() returns lower bound
3. getUB() returns upper bound

For testing purposes try:
  Array<int,-5,5> a;
  a[-4] = 3;
*/

#include <stdexcept>
template<typename T, T LB, T RB>
class Array {
    int size_;
    T left_boundary;
    T right_boundary;
    T* array;
public:
    Array(){
        size_ = RB-LB+1;
        left_boundary = LB;
        right_boundary =RB;
        array = new T[size_];
    }
    T&operator[](int i){
        if (i<left_boundary || i>right_boundary) throw std::runtime_error("Relevant message");
        return array[i];
    }
    int size(){
        return size_;
    }

    T getLB(){
        return left_boundary;
    }

    T getUB(){
        return right_boundary;
    }

    ~Array(){
        delete []array;
    }
};