#include <iostream>
using namespace std;

template <typename T>
class Vector {
private:
    T* elements;
    size_t capacity;
    size_t length;

public:
    Vector() : elements(nullptr), capacity(0), length(0) {}

    ~Vector() {
        delete[] elements;
    }

    void push_back(const T& element) {
        if (length >= capacity) {
            size_t newCapacity = (capacity == 0) ? 1 : capacity * 2;
            reserve(newCapacity);
        }
        elements[length++] = element;
    }

    void pop_back() {
        if (length > 0) {
            --length;
        }
    }

    size_t size() const {
        return length;
    }

    bool empty() const {
        return length == 0;
    }

    void clear() {
        length = 0;
    }

    T* begin() const {
        return elements;
    }

    T* end() const {
        return elements + length;
    }

    T& operator[](size_t index) {
        if (index >= length) {
            throw out_of_range("Index out of range");
        }
        return elements[index];
    }

    void insert(size_t index, const T& element) {
        if (index > length) {
            throw out_of_range("Index out of range");
        }
        if (length >= capacity) {
            size_t newCapacity = (capacity == 0) ? 1 : capacity * 2;
            reserve(newCapacity);
        }
        for (size_t i = length; i > index; --i) {
            elements[i] = elements[i - 1];
        }
        elements[index] = element;
        ++length;
    }

private:
    void reserve(size_t newCapacity) {
        T* newElements = new T[newCapacity];
        for (size_t i = 0; i < length; ++i) {
            newElements[i] = elements[i];
        }
        delete[] elements;
        elements = newElements;
        capacity = newCapacity;
    }
};

int main() {
    Vector<int> myVector;

    myVector.push_back(10);
    myVector.push_back(20);
    myVector.push_back(30);

    cout << "Vector size: " << myVector.size() << endl;

    for (int* it = myVector.begin(); it != myVector.end(); ++it) {
        cout << *it << " ";
    }
    cout << endl;

    myVector.pop_back();

    cout << "Vector size after pop_back: " << myVector.size() << endl;

    myVector.insert(1, 15);

    for (int* it = myVector.begin(); it != myVector.end(); ++it) {
        cout << *it << " ";
    }
    cout << std::endl;

    return 0;
}
