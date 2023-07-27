#include <iostream>
#include <string>

using namespace std;

// Forward declaration of classes
class Character;
class Species;
class Human;
class Elf;
class Orc;
class PlayerType;
class Archer;
class Magician;
class Tank;

class Character {
protected:
    string name;
    char gender;

public:
    Character(string name, char gender) : name(name), gender(gender) {}
    virtual ~Character() {}

    virtual void changeName(string new_name) = 0;
    virtual void displayInfo() = 0;
};

class Species {
};

class Human : public Character {
public:
    Human(string name, char gender) : Character(name, gender) {}

    void changeName(string new_name) override {
        name = new_name;
    }

    void displayInfo() override {
        cout << "Name: " << name << ", Gender: " << gender << ", Species: Human\n";
    }
};

class Elf : public Character {
public:
    Elf(string name, char gender) : Character(name, gender) {}

    void changeName(string new_name) override {
        name = new_name;
    }

    void displayInfo() override {
        cout << "Name: " << name << ", Gender: " << gender << ", Species: Elf\n";
    }
};

class Orc : public Character {
public:
    Orc(string name, char gender) : Character(name, gender) {}

    void changeName(string new_name) override {
        name = new_name;
    }

    void displayInfo() override {
        cout << "Name: " << name << ", Gender: " << gender << ", Species: Orc\n";
    }
};


class PlayerType {
protected:
    int strength;
    int physicalAttack;
    int physicalDefense;
    int dexterity;

public:
    PlayerType(int strength, int physicalAttack, int physicalDefense, int dexterity)
        : strength(strength), physicalAttack(physicalAttack), physicalDefense(physicalDefense), dexterity(dexterity) {}

    virtual ~PlayerType() {}
};

class Archer : public PlayerType {
public:
    Archer() : PlayerType(10, 20, 10, 15) {}

    void bowAttack() {
        
    }
};

class Magician : public PlayerType {
public:
    Magician() : PlayerType(5, 30, 5, 20) {}

    void castSpell() {
        
    }
};

class Tank : public PlayerType {
public:
    Tank() : PlayerType(30, 10, 30, 5) {}

    void defend() {
        
    }
};

int main() {
    Human human("John", 'M');
    Elf elf("Elara", 'F');
    Orc orc("Grom", 'M');

    human.displayInfo();
    elf.displayInfo();
    orc.displayInfo();

    Archer archer;
    Magician magician;
    Tank tank;

    return 0;
}
