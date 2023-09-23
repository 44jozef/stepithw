#include <iostream>
#include <string>

using namespace std;

class Student {
private:
    string fullName;
    string dateOfBirth;
    string contactPhoneNumber;
    string city;
    string country;
    string institutionName;
    string institutionCity;
    string institutionCountry;
    string groupNumber;

public:
    Student() {
        fullName = "";
        dateOfBirth = "";
        contactPhoneNumber = "";
        city = "";
        country = "";
        institutionName = "";
        institutionCity = "";
        institutionCountry = "";
        groupNumber = "";
    }

    string getFullName() const {
        return fullName;
    }

    string getDateOfBirth() const {
        return dateOfBirth;
    }

    string getContactPhoneNumber() const {
        return contactPhoneNumber;
    }

    string getCity() const {
        return city;
    }

    string getCountry() const {
        return country;
    }

    string getInstitutionName() const {
        return institutionName;
    }

    string getInstitutionCity() const {
        return institutionCity;
    }

    string getInstitutionCountry() const {
        return institutionCountry;
    }

    string getGroupNumber() const {
        return groupNumber;
    }

    void inputStudentData() {
        cout << "Enter Full Name: ";
        getline(cin, fullName);

        cout << "Enter Date of Birth: ";
        getline(cin, dateOfBirth);

        cout << "Enter Contact Phone Number: ";
        getline(cin, contactPhoneNumber);

        cout << "Enter City: ";
        getline(cin, city);

        cout << "Enter Country: ";
        getline(cin, country);

        cout << "Enter Educational Institution Name: ";
        getline(cin, institutionName);

        cout << "Enter Educational Institution City: ";
        getline(cin, institutionCity);

        cout << "Enter Educational Institution Country: ";
        getline(cin, institutionCountry);

        cout << "Enter Group Number: ";
        getline(cin, groupNumber);
    }
    
    void displayStudentData() const {
        cout << "Full Name: " << fullName << endl;
        cout << "Date of Birth: " << dateOfBirth << endl;
        cout << "Contact Phone Number: " << contactPhoneNumber << endl;
        cout << "City: " << city << endl;
        cout << "Country: " << country << endl;
        cout << "Educational Institution Name: " << institutionName << endl;
        cout << "Educational Institution City: " << institutionCity << endl;
        cout << "Educational Institution Country: " << institutionCountry << endl;
        cout << "Group Number: " << groupNumber << endl;
    }
};

int main() {
    Student student;

    cout << "Enter Student Information:" << endl;
    student.inputStudentData();

    cout << "\nStudent Information:" << endl;
    student.displayStudentData();

    return 0;
}
