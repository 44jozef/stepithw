// queue

/////////////
/*
#include <iostream>

using namespace std;

template<typename T>
class Queue {
private:
    struct Node {
        T data;
        Node* next;

        Node(const T& data) : data(data), next(nullptr) {}
    };

    Node* front;
    Node* rear;

public:
    Queue() : front(nullptr), rear(nullptr) {}

    ~Queue() {
        while (!isEmpty()) {
            pop();
        }
    }

    bool isEmpty() const {
        return front == nullptr;
    }

    void push(const T& data) {
        Node* newNode = new Node(data);
        if (isEmpty()) {
            front = rear = newNode;
        } else {
            rear->next = newNode;
            rear = newNode;
        }
    }

    void pop() {
        if (isEmpty()) {
            cout << "Queue is empty. Cannot pop an element." << endl;
            return;
        }

        Node* temp = front;
        front = front->next;
        delete temp;

        if (front == nullptr) {
            rear = nullptr;
        }
    }

    const T& peek() const {
        if (isEmpty()) {
            cout << "Queue is empty. Cannot peek an element." << endl;
            throw;
        }

        return front->data;
    }
};

int main() {
    Queue<int> queue;

    queue.push(10);
    queue.push(20);
    queue.push(30);

    cout << "Queue Front: " << queue.peek() << endl;

    queue.pop();

    cout << "Queue Front after pop: " << queue.peek() << endl;

    return 0;
}*/



// dequeue
/*
#include <iostream>

using namespace std;

template<typename T>
class DeQueue {
private:
    struct Node {
        T data;
        Node* next;

        Node(const T& data) : data(data), next(nullptr) {}
    };

    Node* front;
    Node* rear;

public:
    DeQueue() : front(nullptr), rear(nullptr) {}

    ~DeQueue() {
        while (!isEmpty()) {
            pop();
        }
    }

    bool isEmpty() const {
        return front == nullptr;
    }

    void push(const T& data) {
        Node* newNode = new Node(data);
        if (isEmpty()) {
            front = rear = newNode;
        } else {
            newNode->next = front;
            front = newNode;
        }
    }

    void pushBack(const T& data) {
        Node* newNode = new Node(data);
        if (isEmpty()) {
            front = rear = newNode;
        } else {
            rear->next = newNode;
            rear = newNode;
        }
    }

    void pop() {
        if (isEmpty()) {
            cout << "DeQueue is empty. Cannot pop an element." << endl;
            return;
        }

        Node* temp = front;
        front = front->next;
        delete temp;

        if (front == nullptr) {
            rear = nullptr;
        }
    }

    void popBack() {
        if (isEmpty()) {
            cout << "DeQueue is empty. Cannot pop an element." << endl;
            return;
        }

        if (front == rear) {
            delete front;
            front = rear = nullptr;
        } else {
            Node* current = front;
            while (current->next != rear) {
                current = current->next;
            }

            delete rear;
            rear = current;
            rear->next = nullptr;
        }
    }

    const T& peek() const {
        if (isEmpty()) {
            cout << "DeQueue is empty. Cannot peek an element." << endl;
            throw;
        }

        return front->data;
    }

    const T& peekBack() const {
        if (isEmpty()) {
            cout << "DeQueue is empty. Cannot peek an element." << endl;
            throw;
        }

        return rear->data;
    }
};

int main() {
    DeQueue<int> deQueue;

    deQueue.push(10);
    deQueue.push(20);
    deQueue.pushBack(30);

    cout << "DeQueue Front: " << deQueue.peek() << endl;
    cout << "DeQueue Back: " << deQueue.peekBack() << endl;

    deQueue.pop();
    deQueue.popBack();

    cout << "DeQueue Front after pop: " << deQueue.peek() << endl;
    cout << "DeQueue Back after pop: " << deQueue.peekBack() << endl;

    return 0;
}
*/ 