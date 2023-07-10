#include <iostream>
#include <queue>

using namespace std;

struct Node {
    int key;
    Node* left;
    Node* right;

    Node(int key) : key(key), left(nullptr), right(nullptr) {}
};

class BST {
private:
    Node* root;

    Node* insertNode(Node* root, int key) {
        if (root == nullptr) {
            return new Node(key);
        }

        if (key < root->key) {
            root->left = insertNode(root->left, key);
        } else if (key > root->key) {
            root->right = insertNode(root->right, key);
        }

        return root;
    }

    Node* findMinNode(Node* node) {
        while (node->left != nullptr) {
            node = node->left;
        }
        return node;
    }

    Node* deleteNode(Node* root, int key) {
        if (root == nullptr) {
            return nullptr;
        }

        if (key < root->key) {
            root->left = deleteNode(root->left, key);
        } else if (key > root->key) {
            root->right = deleteNode(root->right, key);
        } else {
            // Case 1: No child or 1 child
            if (root->left == nullptr) {
                Node* temp = root->right;
                delete root;
                return temp;
            } else if (root->right == nullptr) {
                Node* temp = root->left;
                delete root;
                return temp;
            }

            // Case 2: 2 children
            Node* successor = findMinNode(root->right);
            root->key = successor->key;
            root->right = deleteNode(root->right, successor->key);
        }

        return root;
    }
    void printTreeRecursive(Node* root, int level) {
        if (root == nullptr) {
            return;
        }
        printTreeRecursive(root->right, level + 1);
        for (int i = 0; i < level; i++) {
            cout << "    ";
        }
        cout << root->key << endl;
        printTreeRecursive(root->left, level + 1);
    }

public:
    BST() : root(nullptr) {}

    void insert(int key) {
        root = insertNode(root, key);
    }

    void remove(int key) {
        root = deleteNode(root, key);
    }

    void displayTree() {
        printTreeRecursive(root, 0);
    }
};

int main() {
    BST bst;
    bst.insert(50);
    bst.insert(30);
    bst.insert(20);
    bst.insert(40);
    bst.insert(70);
    bst.insert(60);
    bst.insert(80);
    cout << "Binary Search Tree:" << endl;
    bst.displayTree();
    bst.remove(30);
    bst.remove(70);
    cout << "Binary Search Tree after removal:" << endl;
    bst.displayTree();

    return 0;
}
