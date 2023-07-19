#include <iostream>
#include <string>
using namespace std;


class Circle {
private:
	double radius;
public:
    Circle(double r) : radius(r) {}

    double getRadius() const {
        return radius;
    }

    bool operator==(const Circle& other) const {
        return radius == other.radius;
    }

    bool operator>(const Circle& other) const {
        return radius > other.radius;
    }
    Circle& operator+=(double value) {
        radius += value;
        return *this;
    }

    Circle& operator-=(double value) {
        radius -= value;
        return *this;
    }
};




int main() {
	setlocale(LC_ALL, "");
    Circle circle1(5.0);
    Circle circle2(3.0);
    if (circle1 == circle2) {
        cout << "Ðàäèóñû îêðóæíîñòåé ðàâíû";
    }
    else {
        cout << "Ðàäèóñû îêðóæíîñòåé íå ðàâíû!";
    }
}
