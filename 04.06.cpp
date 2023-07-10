#include <iostream>
#include <string>

using namespace std;

class Processor {
protected:
    string model;
    int cores;

public:
    Processor(const string& model, int cores) : model(model), cores(cores) {}

    virtual void displayInfo() const {
        cout << "Processor Model: " << model << endl;
        cout << "Processor Cores: " << cores << endl;
    }
};

class Computer : public Processor {
private:
    string brand;
    string model;

public:
    Computer(const string& brand, const string& model, const string& processorModel, int processorCores)
        : brand(brand), model(model), Processor(processorModel, processorCores) {}

    void displayInfo() const {
        cout << "Brand: " << brand << endl;
        cout << "Model: " << model << endl;
        Processor::displayInfo();
    }
};

int main() {
    Computer myComputer("SalamVidia", "AMD", "Intel i7", 8);
    myComputer.displayInfo();

    return 0;
}
