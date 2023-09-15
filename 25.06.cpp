/*
#include <iostream>
#include <string>

using namespace std;

class Student {
public:
    Student(const string& name, int age, int studentId)
        : name(name), age(age), studentId(studentId) {}

    void display() {
        cout << "Name: " << name << "\n";
        cout << "Age: " << age << "\n";
        cout << "Student ID: " << studentId << "\n";
    }

private:
    string name;
    int age;
    int studentId;
};

class Aspirant : public Student {
public:
    Aspirant(const string& name, int age, int studentId, const string& researchTopic)
        : Student(name, age, studentId), researchTopic(researchTopic) {}

    void display() {
        Student::display();
        cout << "Research Topic: " << researchTopic << "\n";
    }

private:
    string researchTopic;
};

int main() {
    Student student("John Doe", 20, 12345);
    Aspirant aspirant("Alice Smith", 25, 54321, "Machine Learning");

    cout << "Student Information:\n";
    student.display();

    cout << "\nAspirant Information:\n";
    aspirant.display();

    return 0;
}
*/
/*
#include <iostream>
#include <string>

using namespace std;

class Passport {
public:
    Passport(const string& fullName, const string& passportNumber)
        : fullName(fullName), passportNumber(passportNumber) {}

    void display() {
        cout << "Full Name: " << fullName << "\n";
        cout << "Passport Number: " << passportNumber << "\n";
    }

private:
    string fullName;
    string passportNumber;
};

class ForeignPassport : public Passport {
public:
    ForeignPassport(const string& fullName, const string& passportNumber, const string& visaData)
        : Passport(fullName, passportNumber), visaData(visaData) {}

    void display() {
        Passport::display();
        cout << "Visa Data: " << visaData << "\n";
    }

private:
    string visaData;
};

int main() {
    Passport ukrainePassport("John Doe", "123456789");
    ForeignPassport foreignPassport("Alice Smith", "987654321", "USA Visa");

    cout << "Ukraine Passport Information:\n";
    ukrainePassport.display();

    cout << "\nForeign Passport Information:\n";
    foreignPassport.display();

    return 0;
}
*/
/*
#include <iostream>
#include <string>

using namespace std;

class Vehicle {
public:
    Vehicle(int passengers, int cargo) : passengers(passengers), cargo(cargo) {}

    virtual double calculateTime() const = 0;
    virtual double calculateCost() const = 0;

protected:
    int passengers;
    int cargo;
};

class Car : public Vehicle {
public:
    Car(int passengers, int cargo, double speed, double costPerMile)
        : Vehicle(passengers, cargo), speed(speed), costPerMile(costPerMile) {}

    double calculateTime() const override {
        return static_cast<double>(cargo) / speed;
    }

    double calculateCost() const override {
        return static_cast<double>(cargo) * costPerMile;
    }

private:
    double speed;
    double costPerMile;
};

class Bicycle : public Vehicle {
public:
    Bicycle(int passengers, int cargo, double speed)
        : Vehicle(passengers, cargo), speed(speed) {}

    double calculateTime() const override {
        return static_cast<double>(cargo) / speed;
    }

    double calculateCost() const override {
        return 0.0;
    }

private:
    double speed;
};

class Cart : public Vehicle {
public:
    Cart(int passengers, int cargo, double walkingSpeed)
        : Vehicle(passengers, cargo), walkingSpeed(walkingSpeed) {}

    double calculateTime() const override {
        return static_cast<double>(cargo) / walkingSpeed;
    }

    double calculateCost() const override {
        return 0.0;
    }

private:
    double walkingSpeed;
};

int main() {
    Car car(4, 100, 60.0, 0.05);
    Bicycle bicycle(1, 20, 15.0);
    Cart cart(2, 50, 5.0);

    cout << "Car:\n";
    cout << "Time: " << car.calculateTime() << " hours\n";
    cout << "Cost: $" << car.calculateCost() << "\n\n";

    cout << "Bicycle:\n";
    cout << "Time: " << bicycle.calculateTime() << " hours\n";
    cout << "Cost: $" << bicycle.calculateCost() << "\n\n";

    cout << "Cart:\n";
    cout << "Time: " << cart.calculateTime() << " hours\n";
    cout << "Cost: $" << cart.calculateCost() << "\n";

    return 0;
}
*/

