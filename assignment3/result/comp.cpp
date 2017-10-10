//
//
//#include <iostream>
//#include <cstring>
//
//using namespace std;
//
//
//template<typename T>
//class Comp {
//public:
// static   bool lesser(T &v1, T &v2) {
//        return v1 < v2;
//    }
//};
//
//template<>
//class Comp<const char *> {
//public:
//    static bool lesser(const char *v1, const char *v2) {
//        return strcmp(v1, v2) < 0;
//    }
//};
//
//template<typename T>
//class Comp<T *> {
//public:
//    static bool lesser(T *v1, T *v2) {
//        return *v1 < *v2;
//    }
//};
//
//template<typename T>
//class Comp<T(*)()>{
//public:
//   static bool lesser(T(fun()), T(fun2())){
//        return fun()<fun2();
//    }
//};
//
//
//////////// TESTING
//int a5(){
//	return 1;
//}
//int b5(){
//	return 2;
//}
//
//int main(){
//	int a1 = 1, b1 = 2;
//	double a2 = 1.124, b2= 1.123;
//	int* a3 = &a1, *b3 = &b1;
//	char a4[]="abcd", b4[]="abc";
//	cout<<Comp<int>::lesser(a1,b1)<<endl;
//	cout<<Comp<double>::lesser(a2,b2)<<endl;
//	cout<<Comp<int*>::lesser(a3,b3)<<endl;
//	cout<<Comp<const char*>::lesser(a4,b4)<<endl;
//	cout<<Comp<int(*)()>::lesser(a5,b5)<<endl;
//}
//
//
//
//
