#include <iostream>
#include <string>

using namespace std;

struct Processor {
    string model;
    int cores;

    Processor(const string& model, int cores) : model(model), cores(cores) {}
};

class Computer {
private:
    string brand;
    string model;
    Processor processor;

public:
    Computer(const string& brand, const string& model, const string& processorModel, int processorCores)
        : brand(brand), model(model), processor(processorModel, processorCores) {}

    void displayInfo() const {
        cout << "Brand: " << brand << endl;
        cout << "Model: " << model << endl;
        cout << "Processor: " << processor.model << endl;
        cout << "Processor Cores: " << processor.cores << endl;
    }
};

int main() {
    Computer myComputer("SalamVidia", "AMD", "Intel i7", 8);
    myComputer.displayInfo();

    return 0;
}
