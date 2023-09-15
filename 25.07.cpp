#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <stdexcept>
#include <regex>

using namespace std;


class TransportException : public exception {
public:
    TransportException(const string& msg) : message(msg) {}
    const char* what() const throw() {
        return message.c_str();
    }
private:
    string message;
};

class CarException : public TransportException {
public:
    CarException(const string& msg) : TransportException(msg) {}
};

class PlaneException : public TransportException {
public:
    PlaneException(const string& msg) : TransportException(msg) {}
};

class BoatException : public TransportException {
public:
    BoatException(const string& msg) : TransportException(msg) {}
};


class Transport {
public:
    Transport(const string& name, int capacity) : name(name), capacity(capacity) {}
    virtual ~Transport() {}
    virtual void display() const {
        cout << "Name: " << name << "\nCapacity: " << capacity << " passengers\n";
    }

    friend ostream& operator<<(ostream& os, const Transport& t) {
        os << t.name << " (Capacity: " << t.capacity << " passengers)";
        return os;
    }

    virtual bool operator==(const Transport& other) const {
        return name == other.name && capacity == other.capacity;
    }

    virtual bool operator!=(const Transport& other) const {
        return !(*this == other);
    }

    static bool validateString(const string& str) {
        regex pattern("^[A-Za-z0-9_]+$");
        return regex_match(str, pattern);
    }

protected:
    string name;
    int capacity;
};


class Car : public Transport {
public:
    Car(const string& name, int capacity, int speed) : Transport(name, capacity), speed(speed) {
        if (speed < 0 || speed > 250)
            throw CarException("Invalid car speed");
    }

    void display() const override {
        Transport::display();
        cout << "Speed: " << speed << " km/h\n";
    }

private:
    int speed;
};


class Plane : public Transport {
public:
    Plane(const string& name, int capacity, int maxAltitude) : Transport(name, capacity), maxAltitude(maxAltitude) {
        if (maxAltitude < 0 || maxAltitude > 40000)
            throw PlaneException("Invalid maximum altitude");
    }

    void display() const override {
        Transport::display();
        cout << "Max Altitude: " << maxAltitude << " feet\n";
    }

private:
    int maxAltitude;
};


class Boat : public Transport {
public:
    Boat(const string& name, int capacity, int maxSpeed) : Transport(name, capacity), maxSpeed(maxSpeed) {
        if (maxSpeed < 0 || maxSpeed > 100)
            throw BoatException("Invalid maximum speed");
    }

    void display() const override {
        Transport::display();
        cout << "Max Speed: " << maxSpeed << " knots\n";
    }

private:
    int maxSpeed;
};


void writeExceptionsToCSV(const vector<exception*>& exceptions) {
    ofstream file("exceptions.csv");
    file << "Exception Type,Message\n";
    for (const auto& ex : exceptions) {
        file << typeid(*ex).name() << "," << ex->what() << "\n";
    }
    file.close();
}

int main() {
    vector<exception*> exceptions;

    try {
        Car car("Sedan", 5, 120);
        Plane plane("Boeing 747", 300, 35000);
        Boat boat("Speedboat", 4, 70);

        Transport* transports[] = { &car, &plane, &boat };

        for (auto transport : transports) {
            if (!Transport::validateString(transport->name)) {
                exceptions.push_back(new TransportException("Invalid transport name"));
            }
            transport->display();
        }

       
        Car invalidCar("InvalidCar_123!", 5, -10);
        Plane invalidPlane("Invalid^Plane", 300, 45000);
        Boat invalidBoat("Invalid-Boat", 4, 110);

        exceptions.push_back(new CarException("Invalid car speed"));
        exceptions.push_back(new PlaneException("Invalid maximum altitude"));
        exceptions.push_back(new BoatException("Invalid maximum speed"));
    }
    catch (const exception& ex) {
        cerr << "Caught exception: " << ex.what() << endl;
        exceptions.push_back(new exception(ex));
    }

    
    writeExceptionsToCSV(exceptions);

    
    for (const auto& ex : exceptions) {
        delete ex;
    }

    return 0;
}
