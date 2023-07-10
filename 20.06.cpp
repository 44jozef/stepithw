#include <iostream>
#include <string>

using namespace std;

class Processor {
private:
    string model;
    int cores;

public:
    Processor(const string& model, int cores) : model(model), cores(cores) {}

    void displayInfo() const {
        cout << "Processor Model: " << model << endl;
        cout << "Processor Cores: " << cores << endl;
    }
};

class Computer {
private:
    Processor processor;
    string brand;
    string model;

public:
    Computer(const string& brand, const string& model, const string& processorModel, int processorCores)
        : brand(brand), model(model), processor(processorModel, processorCores) {}

    void displayInfo() const {
        cout << "Brand: " << brand << endl;
        cout << "Model: " << model << endl;
        processor.displayInfo();
    }
};

class Homework {
private:
    string description;
    Computer computer;

public:
    Homework(const string& description, const Computer& computer)
        : description(description), computer(computer) {}

    void displayInfo() const {
        cout << "Description: " << description << endl;
        computer.displayInfo();
    }
};

int main() {
    Processor processor("Intel i7", 8);
    Computer computer("Dell", "Anaconda", processor);
    Homework homework("Math Assignment", computer);

    homework.displayInfo();

    return 0;
}
