#include <iostream>
#include <string>
#include <regex>

using namespace std;

class User {
private:
    string username;
    string password;

public:
    User(string username, string password) : username(username), password(password) {}

    string getUsername() const {
        return username;
    }

    string getPassword() const {
        return password;
    }
};

bool isValidUsername(const string& username) {
    regex pattern("^[a-zA-Z0-9_]+$");
    return regex_match(username, pattern);
}

bool isValidPassword(const string& password) {
    regex pattern("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,}$");
    return regex_match(password, pattern);
}

void registerUser() {
    string username, password;
    cout << "Registration\n";
    do {
        cout << "Enter username (alphanumeric characters and underscore only): ";
        cin >> username;
    } while (!isValidUsername(username));

    do {
        cout << "Enter password (at least 8 characters with at least one uppercase, one lowercase, and one digit): ";
        cin >> password;
    } while (!isValidPassword(password));

    User newUser(username, password);
    cout << "Registration successful!\n";
}

void loginUser(const User& user) {
    string username, password;
    cout << "Login\n";
    cout << "Enter username: ";
    cin >> username;
    cout << "Enter password: ";
    cin >> password;

    if (username == user.getUsername() && password == user.getPassword()) {
        cout << "Login successful! Welcome, " << user.getUsername() << "!\n";
    } else {
        cout << "Login failed. Invalid credentials.\n";
    }
}

int main() {
    int choice;
    User user("testuser", "Test1234");

    do {
        cout << "Menu\n";
        cout << "1. Register\n";
        cout << "2. Login\n";
        cout << "3. Exit\n";
        cout << "Enter your choice: ";
        cin >> choice;

        try {
            if (choice == 1) {
                registerUser();
            } else if (choice == 2) {
                loginUser(user);
            } else if (choice == 3) {
                cout << "Goodbye!\n";
                break;
            } else {
                throw invalid_argument("Invalid choice. Please enter a valid option.");
            }
        } catch (const exception& e) {
            cout << "Error: " << e.what() << endl;
        }

    } while (true);

    return 0;
}
