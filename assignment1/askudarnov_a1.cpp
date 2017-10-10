


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


int main()
{
	int a = 5, b = 3;
	double c = 4.5, d = 5.7;
	MyClass* e = new MyClass(67);
	MyClass* f = new MyClass(45);
	std::cout << "a=" << a << " b=" << b;
	std::cout << "\nMax = " << Max(a, b);
	std::cout << "\nc=" << c << " d=" << d;
	std::cout << "\nMax = " << Max(c, d);
	std::cout << "\ne=" << e << " f=" << f;
	std::cout << "\ne value=" << e->getValue() << " f value=" << f->getValue();
	std::cout << "\nMax = " << Max(e, f) << " value=" << Max(e, f)->getValue() << "\n";
	system("PAUSE");
}




