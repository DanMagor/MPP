#include <iostream>

using namespace std;

template<typename iter, typename T>
class Search {
public:
    iter operator()(iter first, iter beyond, T value) {
        iter p = first;
        while (p != beyond && *p != value) {
            p++;
        }
        return p;
    }
};


template<typename V>
class Node {
    V value;
    Node *next;
public:
    Node(V v) : value(v), next(nullptr) {}

    void add(Node *n) {
        Node temp(this->value);
        n->next = this->next;
        this->value = n->value;
        n->value = temp.value;
        this->next = n;

    }

    class iterator;

    friend class iterator;

    class iterator {
        Node *p;
    public:
        explicit iterator(Node *node) {
            p = node;
        }

        ~iterator() {
            p = nullptr;
        }

        iterator &operator=(const iterator &other) {
            p = other.p;
            return *this;
        }

        V &operator*() {
            return p->value;
        }

        iterator &operator++(int lol) {

            p = p->next;
            return *this;
        }

        bool operator!=(const iterator &other) {
            if (&other == nullptr) return true;
            return this->p != other.p;
        }

        iterator begin() {
            return iterator(p);
        }

        iterator end() {
            return iterator(nullptr);
        }
    };
};


int main() {


    cout << "Create a list with 1 object:"<< endl<<" Node<int> *list = new Node<int>(1)"<<endl<<endl;
    auto *list = new Node<int>(1);
    Search<Node<int>::iterator,int> find;
    cout << "Fill the list with elements from 2 to 10:"<< endl;
    for (int i = 2; i < 10; i++) {
        auto *temp = new Node<int>(i);
        list->add(temp);
    }
    cout<<"List contains:"<<endl;
    for (Node<int>::iterator p(list); p != p.end(); p++) {
        cout << *p<<" ";
    }
    cout<<endl<<"Let's try to find element equal 7: find(p.begin(),p.end(),7)"<<endl;

    Node<int>::iterator p(list);
     p = find(p.begin(),p.end(),7);
    cout<<"The address of founded element is: "<<&*p<<" the value is:"<<*p<<endl;


}
