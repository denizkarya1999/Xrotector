//Mohamed Muhsin
#include <iostream>
#include <string>

class UserSession {
private:
 
    UserSession() {}

    std::string username;
    std::string password;
    std::string email;

    static UserSession* instance;

public:
    // Delete the copy constructor and assignment operator
    UserSession(const UserSession&) = delete;
    UserSession& operator=(const UserSession&) = delete;

    // Static method to get the instance of the class
    static UserSession* getInstance() {
        if (instance == nullptr) {
            instance = new UserSession();
        }
        return instance;
    }

    // Method to login
    bool Login(const std::string& username, const std::string& password) {
        // Logic for login
        this->username = username;
        this->password = password;
        std::cout << username << " logged in successfully." << std::endl;
        return true; // Assuming login is always successful for demonstration
    }

    // Method to simulate sign-up or login
    bool signUpLogin(const std::string& username, const std::string& password, const std::string& email) {
        // Logic for sign-up or login
        this->username = username;
        this->password = password;
        this->email = email;
        std::cout << username << " signed up and logged in successfully." << std::endl;
        return true; // Assuming sign-up/login is always successful for demonstration
    }

    // Method for validation
    bool validation(const std::string& data) {
        // Logic for validation goes here 
        std::cout << "Data validated." << std::endl;
        return true; // Assuming validation is always successful for demonstration
    }

    // Method to print the current user information (for demonstration purposes)
    void print() {
        std::cout << "User: " << username << ", Email: " << email << std::endl;
    }
};

// Initialize the static instance pointer to nullptr
UserSession* UserSession::instance = nullptr;

// Demonstration of the Singleton pattern usage
int main() {
    UserSession* session = UserSession::getInstance();
    session->Login("JohnDoe", "password123");
    session->signUpLogin("JaneDoe", "password123", "jane@example.com");
    session->validation("Some important data");
    session->print();

    return 0;
}
