// assignment1.cpp: определ€ет точку входа дл€ консольного приложени€.
//

#include "stdafx.h"
#include <iostream>




// should have С>Т operator defined.
template < typename T>
T Max(T a, T b)
{
	return a > b ? a : b;
}

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



