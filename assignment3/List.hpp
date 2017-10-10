/*
In this excersize you need to write a class that implements a List
for generic types. The requirements for the class template are as follows:
  0. This file should not contain main()
  1. There are two parameters given to the template as an argument
  2. The first parameter is the type of List
  3. The second parameter is optional and determines the stack size
  4. The name of the class should be precisely "List"
  5. The current filename should remain "List.hpp"
  6. The entire code for the template should be in the current file

The following methods should be implemented to interact with the Stack
object from outside:
1. Constructor that initializes the List object. This
    constructor does not accept any argument. Memory allocation
    should be perfromed using malloc
2. Destructor for the object. Free allocated memory in this destructor.
3. resize(int value) resizes the List to the size of type*value. The
    resonable way to resize the List is to allocate new part of memory,
    copy the data, and free the old memory
4. getSize() return the integer number of elements type that the List
    can store
5. The elements of your List should be accessible using [], i.e. a[0].
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
class List
{
    T *list;
    int size;
public:
    List(){
        list = (T*)malloc(sizeof(T)*N);
        size = N;
    }
    ~List()
    {
        if (list != nullptr)
		delete(list);
    }
    
    T& operator[](int i)
    {
      
        if (i<0 || i>size-1) throw std::out_of_range("Out of Range");
        return list[i];
    }



    int getSize()
    {
        return size;
    }

    void resize(int value)
    {
        T *temp = list;
        list = malloc(sizeof(T[value]));
        int oldSize = size;
        size = value;
        for(int i=0; i<size; i++) list[i] = temp[i];
        if (oldSize < size)
        {
            for (int i=oldSize;i<size;i++) list[i] = T(); 
        }
        delete(temp);
        

    }
};