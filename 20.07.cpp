#include <iostream>
#include <vector>
#include <stdexcept>

using namespace std;

class OutOfRangeException : public exception {
public:
    const char* what() const throw() {
        return "Vector capacity exceeded.";
    }
};

class SimpleNumException : public exception {
public:
    const char* what() const throw() {
        return "Prime numbers are not allowed.";
    }
};

class MyVector {
public:
    MyVector(int maxCapacity) : maxCapacity(maxCapacity) {}

    void push_back(int value) {
        if (isPrime(value)) {
            throw SimpleNumException();
        }

        if (data.size() >= maxCapacity) {
            throw OutOfRangeException();
        }

        data.push_back(value);
    }

    void print() const {
        for (int num : data) {
            cout << num << " ";
        }
        cout << endl;
    }

private:
    vector<int> data;
    int maxCapacity;

    bool isPrime(int num) {
        if (num <= 1) {
            return false;
        }
        for (int i = 2; i * i <= num; ++i) {
            if (num % i == 0) {
                return true;
            }
        }
        return false;
    }
};

int main() {
    MyVector myVec(5);

    try {
        myVec.push_back(2);
        myVec.push_back(4);
        myVec.push_back(6);
        myVec.push_back(7);  
        myVec.push_back(8);
        myVec.push_back(10);
        myVec.push_back(12); 
    }
    catch (const exception& e) {
        cout << "Exception: " << e.what() << endl;
    }

    myVec.print();

    return 0;
}
