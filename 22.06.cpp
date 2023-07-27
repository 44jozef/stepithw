#include <iostream>
#include <string>

using namespace std;

class CPU {
private:
    string brand;
    int cores;

public:
    CPU(string brand, int cores) : brand(brand), cores(cores) {}
    CPU(const CPU& other) : brand(other.brand), cores(other.cores) {}

    void displayInfo() {
        cout << "CPU Brand: " << brand << ", Cores: " << cores << endl;
    }
};

class GPU {
private:
    string brand;
    int memory;

public:
    GPU(string brand, int memory) : brand(brand), memory(memory) {}
    GPU(const GPU& other) : brand(other.brand), memory(other.memory) {}

    void displayInfo() {
        cout << "GPU Brand: " << brand << ", Memory: " << memory << " GB" << endl;
    }
};

class RAM {
private:
    int capacity;

public:
    RAM(int capacity) : capacity(capacity) {}
    RAM(const RAM& other) : capacity(other.capacity) {}

    void displayInfo() {
        cout << "RAM Capacity: " << capacity << " GB" << endl;
    }
};

class Computer {
private:
    string model;
    CPU cpu;
    GPU gpu;
    RAM ram;

public:
    Computer(string model, const CPU& cpu, const GPU& gpu, const RAM& ram)
        : model(model), cpu(cpu), gpu(gpu), ram(ram) {}

    Computer(const Computer& other)
        : model(other.model), cpu(other.cpu), gpu(other.gpu), ram(other.ram) {}

    void displayInfo() {
        cout << "Computer Model: " << model << endl;
        cpu.displayInfo();
        gpu.displayInfo();
        ram.displayInfo();
    }
};

int main() {
    CPU cpu("Intel", 8);
    GPU gpu("Nvidia", 6);
    RAM ram(16);

    Computer computer1("Desktop 1", cpu, gpu, ram);
    Computer computer2 = computer1; 

    computer1.displayInfo();
    cout << "--------" << endl;
    computer2.displayInfo();

    return 0;
}
