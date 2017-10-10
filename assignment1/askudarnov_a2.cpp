

#include <iostream>
#include <time.h>


// should have > operator defined.
template < typename T>
T Max(T a, T b)
{
	return a > b ? a : b;
}

class MyClass
{

	int valueOfClass;
public:
	MyClass::MyClass() :valueOfClass(0)
	{
	}

	MyClass::MyClass(int value)
	{
		valueOfClass = value;
	}

	bool MyClass::operator>(MyClass & other)
	{
		return valueOfClass > other.valueOfClass;
	}

	bool MyClass::operator<(MyClass & other)
	{
		return valueOfClass < other.valueOfClass;
	}

	void MyClass::operator+(MyClass& other)
	{
		valueOfClass += other.valueOfClass;
	}



	void MyClass::operator-(MyClass& other)
	{
		valueOfClass -= other.valueOfClass;
	}

	void MyClass::operator+=(MyClass & other)
	{
		valueOfClass += other.valueOfClass;
	}

	void MyClass::operator-=(MyClass & other)
	{
		valueOfClass -= other.valueOfClass;
	}



	void MyClass::operator+=(int other)
	{
		valueOfClass += other;
	}

	void MyClass::operator-=(int other)
	{
		valueOfClass -= other;
	}

	int MyClass::getValue()
	{
		return valueOfClass;
	}

	void MyClass::setValue(int value)
	{
		valueOfClass = value;
	}

	MyClass::~MyClass()
	{
	}

};

const int ARRAY_SIZE = 10;
// should have '<', '+', '-' operators defined.
template < typename T>
void allignArray(T* array, int size, T barrier) {
	for (int i = 0; i < size; i++) {
		if (array[i] < barrier) array[i] += 2;
		else if (array[i] > barrier) array[i] -= 2;
	}

}


int main()
{
	std::srand(time(NULL));

	std::cout << "Initial array: \n";
	MyClass* array = new MyClass[ARRAY_SIZE];
	for (int i = 0; i < ARRAY_SIZE; i++) {
		array[i] = MyClass(rand() % 10 + 1);
		std::cout << array[i].getValue() << " ";
	}
	int borderValue = rand() % 10 + 1;
	MyClass border(borderValue);
	std::cout << "\n border=" << borderValue << "\n";
	allignArray(array, ARRAY_SIZE, border);
	std::cout << "Result array: \n";
	for (int i = 0; i < ARRAY_SIZE; i++) {
		std::cout << array[i].getValue() << " ";
	}
	std::cout << "\n";
	system("PAUSE");
}



