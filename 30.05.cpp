#include <iostream>
#include <string>
#include <vector>

using namespace std;

class Subscriber {
private:
    string* fullName;
    string homePhone;
    string workPhone;
    string mobilePhone;
    string additionalInfo;

public:
    Subscriber(const string& name, const string& home, const string& work, const string& mobile, const string& additional)
        : fullName(new string(name)), homePhone(home), workPhone(work), mobilePhone(mobile), additionalInfo(additional) {}

    ~Subscriber() {
        delete fullName;
    }

    string getFullName() const { return *fullName; }
    string getHomePhone() const { return homePhone; }
    string getWorkPhone() const { return workPhone; }
    string getMobilePhone() const { return mobilePhone; }
    string getAdditionalInfo() const { return additionalInfo; }
};

class PhoneBook {
private:
    vector<Subscriber*> subscribers;

public:
    void addSubscriber(const string& name, const string& home, const string& work, const string& mobile, const string& additional) {
        Subscriber* newSubscriber = new Subscriber(name, home, work, mobile, additional);
        subscribers.push_back(newSubscriber);
    }

    void deleteSubscriber(const string& name) {
        for (auto it = subscribers.begin(); it != subscribers.end(); ++it) {
            if ((*it)->getFullName() == name) {
                delete *it;
                subscribers.erase(it);
                break;
            }
        }
    }

    Subscriber* findSubscriber(const string& name) {
        for (Subscriber* sub : subscribers) {
            if (sub->getFullName() == name) {
                return sub;
            }
        }
        return nullptr;
    }

    void showAllSubscribers() {
        for (Subscriber* sub : subscribers) {
            cout << "Full Name: " << sub->getFullName() << endl;
            cout << "Home Phone: " << sub->getHomePhone() << endl;
            cout << "Work Phone: " << sub->getWorkPhone() << endl;
            cout << "Mobile Phone: " << sub->getMobilePhone() << endl;
            cout << "Additional Info: " << sub->getAdditionalInfo() << endl;
            cout << endl;
        }
    }
};

int main() {
    PhoneBook phoneBook;

    phoneBook.addSubscriber("Jozef Bakinskity", "4832734", "994502426449", "994512426449", "Legenda");
    phoneBook.addSubscriber("Jane Smith", "40545349", "994242443243", "9942111054", "Colega");

    phoneBook.showAllSubscribers();

    Subscriber* foundSubscriber = phoneBook.findSubscriber("John Doe");
    if (foundSubscriber) {
        cout << "Subscriber found!" << endl;
        cout << "Full Name: " << foundSubscriber->getFullName() << endl;
        cout << "Home Phone: " << foundSubscriber->getHomePhone() << endl;
        cout << "Work Phone: " << foundSubscriber->getWorkPhone() << endl;
        cout << "Mobile Phone: " << foundSubscriber->getMobilePhone() << endl;
        cout << "Additional Info: " << foundSubscriber->getAdditionalInfo() << endl;
    } else {
        cout << "Subscriber not found!" << endl;
    }

    phoneBook.deleteSubscriber("Jane Smith");

    phoneBook.showAllSubscribers();

    return 0;
}
