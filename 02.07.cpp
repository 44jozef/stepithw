#include <iostream>

struct TreeNode {
    int key;
    TreeNode* left;
    TreeNode* right;
    TreeNode(int k) : key(k), left(nullptr), right(nullptr) {}
};


TreeNode* insert(TreeNode* root, int key) {
    if (root == nullptr) {
        return new TreeNode(key);
    }
    if (key < root->key) {
        root->left = insert(root->left, key);
    } else if (key > root->key) {
        root->right = insert(root->right, key);
    }
    return root;
}


TreeNode* findMin(TreeNode* node) {
    while (node->left != nullptr) {
        node = node->left;
    }
    return node;
}


TreeNode* deleteNode(TreeNode* root, int key) {
    if (root == nullptr) {
        return root;
    }

    if (key < root->key) {
        root->left = deleteNode(root->left, key);
    } else if (key > root->key) {
        root->right = deleteNode(root->right, key);
    } else {
        if (root->left == nullptr) {
            TreeNode* temp = root->right;
            delete root;
            return temp;
        } else if (root->right == nullptr) {
            TreeNode* temp = root->left;
            delete root;
            return temp;
        }

        TreeNode* temp = findMin(root->right);
        root->key = temp->key;
        root->right = deleteNode(root->right, temp->key);
    }
    return root;
}


TreeNode* editNode(TreeNode* root, int oldKey, int newKey) {

    root = deleteNode(root, oldKey);

    root = insert(root, newKey);
    return root;
}


void displayTree(TreeNode* root) {
    if (root != nullptr) {
        displayTree(root->left);
        std::cout << root->key << " ";
        displayTree(root->right);
    }
}

int main() {
    TreeNode* root = nullptr;
    root = insert(root, 50);
    root = insert(root, 30);
    root = insert(root, 20);
    root = insert(root, 40);
    root = insert(root, 70);
    root = insert(root, 60);
    root = insert(root, 80);

    std::cout << "In-order traversal of BST: ";
    displayTree(root);
    std::cout << std::endl;

    int deleteKey = 30;
    root = deleteNode(root, deleteKey);
    std::cout << "Deleted " << deleteKey << " from BST. In-order traversal: ";
    displayTree(root);
    std::cout << std::endl;

    int editOldKey = 40;
    int editNewKey = 45;
    root = editNode(root, editOldKey, editNewKey);
    std::cout << "Edited " << editOldKey << " to " << editNewKey << ". In-order traversal: ";
    displayTree(root);
    std::cout << std::endl;

    return 0;
}
