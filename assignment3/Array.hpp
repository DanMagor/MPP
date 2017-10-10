/*
In this excersize you need to write a class that implements a Array
for generic types. The requirements for the class template are as follows:
  0. This file should not contain main()
  1. There are two parameters given to the template as an argument
  2. The first parameter is the type of Array
  3. The second parameter is optional and determines the stack size
  4. The name of the class should be precisely "Array"
  5. The current filename should remain "Array.hpp"
  6. The entire code for the template should be in the current file

The following methods should be implemented to interact with the Stack
object from outside:
1. Constructor that initializes the Array object. This
    constructor does not accept any argument. Memory allocation
    should be perfromed using malloc
2. Destructor for the object. Free allocated memory in this destructor.
3. resize(int value) resizes the Array to the size of type*value. The
    resonable way to resize the array is to allocate new part of memory,
    copy the data, and free the old memory
4. getSize() return the integer number of elements type that the Array
    can store
5. The elements of your Array should be accessible using [], i.e. a[0].
    Overload the operator that is needed for that. Out of boundary check
    should be performed. If the index is out of bounds, throw out_of_range
    exception.
6. Do not use any libraries other than ones listed below

!!!!IMPORTANT!!!!
Failure to follow any of these requirements will lead to the
compilation failure by the grader, and this excersize will receive 0 score.
*/
#include <iostream>

#define DEFAULT_SIZE 10
template <typename T, int N = DEFAULT_SIZE>
class Array
{
    T *array;
    int size;
public:
    Array(){
        array = (T*)malloc(sizeof(T)*N);
        size = N;
    }
    ~Array()
    {
        if (array != nullptr)
		delete(array);
    }
    
    T& operator[](int i)
    {
      
        if (i<0 || i>size-1) throw std::out_of_range("Out of Range");
        return array[i];
    }



    int getSize()
    {
        return size;
    }

    void resize(int value)
    {
        T *temp = array;
        array = malloc(sizeof(T[value]));
        int oldSize = size;
        size = value;
        for(int i=0; i<size; i++) array[i] = temp[i];
        if (oldSize < size)
        {
            for (int i=oldSize;i<size;i++) array[i] = T(); 
        }
        delete(temp);
        

    }
};