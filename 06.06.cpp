#include <iostream>
using namespace std;

class Fraction {
private:
    int numerator;
    int denominator;

public:
    Fraction(int numerator = 0, int denominator = 1) {
        this->numerator = numerator;
        this->denominator = denominator;
    }

    Fraction operator+(const Fraction& other) const {
        int newNumerator = numerator * other.denominator + other.numerator * denominator;
        int newDenominator = denominator * other.denominator;
        return Fraction(newNumerator, newDenominator);
    }

    Fraction operator-(const Fraction& other) const {
        int newNumerator = numerator * other.denominator - other.numerator * denominator;
        int newDenominator = denominator * other.denominator;
        return Fraction(newNumerator, newDenominator);
    }

    Fraction operator*(const Fraction& other) const {
        int newNumerator = numerator * other.numerator;
        int newDenominator = denominator * other.denominator;
        return Fraction(newNumerator, newDenominator);
    }

    Fraction operator/(const Fraction& other) const {
        int newNumerator = numerator * other.denominator;
        int newDenominator = denominator * other.numerator;
        return Fraction(newNumerator, newDenominator);
    }

    bool operator==(const Fraction& other) const {
        return (numerator * other.denominator == other.numerator * denominator);
    }

    bool operator!=(const Fraction& other) const {
        return !(*this == other);
    }

    friend ostream& operator<<(ostream& os, const Fraction& fraction) {
        os << fraction.numerator << "/" << fraction.denominator;
        return os;
    }
};

class Student {
private:
    string name;
    int age;

public:
    Student(string name = "", int age = 0) {
        this->name = name;
        this->age = age;
    }

    bool operator>(const Student& other) const {
        return age > other.age;
    }

    bool operator<(const Student& other) const {
        return age < other.age;
    }

    bool operator==(const Student& other) const {
        return (name == other.name) && (age == other.age);
    }

    bool operator!=(const Student& other) const {
        return !(*this == other);
    }

    friend ostream& operator<<(ostream& os, const Student& student) {
        os << "Name: " << student.name << ", Age: " << student.age;
        return os;
    }

    friend istream& operator>>(istream& is, Student& student) {
        cout << "Enter name: ";
        is >> student.name;
        cout << "Enter age: ";
        is >> student.age;
        return is;
    }
};

class Classroom {
private:
    Student* students;
    int numStudents;

public:
    Classroom(int numStudents = 0) {
        this->numStudents = numStudents;
        students = new Student[numStudents];
    }

    ~Classroom() {
        delete[] students;
    }

    bool operator==(const Classroom& other) const {
        if (numStudents != other.numStudents) {
            return false;
        }

        for (int i = 0; i < numStudents; i++) {
            if (students[i] != other.students[i]) {
                return false;
            }
        }

        return true;
    }

    bool operator!=(const Classroom& other) const {
        return !(*this == other);
    }

    friend ostream& operator<<(ostream& os, const Classroom& classroom) {
        for (int i = 0; i < classroom.numStudents; i++) {
            os << classroom.students[i] << endl;
        }
        return os;
    }

    friend istream& operator>>(istream& is, Classroom& classroom) {
        for (int i = 0; i < classroom.numStudents; i++) {
            cout << "Enter details for Student " << i + 1 << ":" << endl;
            is >> classroom.students[i];
        }
        return is;
    }
};

int main() {
    Fraction f1(1, 2);
    Fraction f2(3, 4);
    Fraction f3 = f1 + f2;
    Fraction f4 = f1 - f2;
    Fraction f5 = f1 * f2;
    Fraction f6 = f1 / f2;

    cout << "f1 + f2 = " << f3 << endl;
    cout << "f1 - f2 = " << f4 << endl;
    cout << "f1 * f2 = " << f5 << endl;
    cout << "f1 / f2 = " << f6 << endl;
    cout << endl;

    Student s1("Jozef", 20);
    Student s2("BaxaNeBey", 22);
    Student s3("Famil", 18);

    cout << "s1 > s2: " << (s1 > s2) << endl;
    cout << "s1 < s2: " << (s1 < s2) << endl;
    cout << "s1 == s2: " << (s1 == s2) << endl;
    cout << "s1 != s2: " << (s1 != s2) << endl;
    cout << endl;

    Classroom c1(3);
    cout << "Enter details for Classroom c1:" << endl;
    cin >> c1;
    cout << "Classroom c1:" << endl;
    cout << c1;

    return 0;
}
