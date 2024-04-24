#include <iostream>
using namespace std;
class linkedList {
	struct node {
		int value;
		node* next;
	};
	enum error { success, underflow, out };
	node* head;
	node* tail;
	node* position;
	int size;
public:
	linkedList() {
		head = tail = position = 0;
		size = 0;
	}
	void addToFirst(int el) {
		node* newnode = new node;
		newnode->value = el;
		if (size == 0) {
			head = tail = newnode;
			newnode->next = 0;
		}
		else {
			newnode->next = head;
			head = newnode;
		}size++;
	}
	void addToLast(int el) {
		node* newnode = new node;
		newnode->value = el;
		if (size == 0) {
			head = tail = newnode;
			newnode->next = 0;
		}
		else {
			tail->next = newnode;
			newnode->next = 0;
			tail = newnode;
		}
		size++;
	}
	void addToPosition(int el, int position) {
		node* newnode = new node;
		node* p1 = head;
		if (size == 0) {
			addToFirst(el);
		}
		else if (position == size) {
			addToLast(el);
		}
		for (int i = 0; i < position - 1; i++) {
			p1 = p1->next;
		}
		node* p2 = p1 + 1;
		newnode->value = el;
		newnode->next = p2;
		size++;
	}
	/*the print function prints the result of each function*/
	void print() {
		node* p = head;
		while (p != NULL) {
			cout << "your list is: ";
			while (p != 0) {
				cout << p->value << " ";
				p = p->next;
			}
		}cout << endl;
	}
	void deleete(int el) {
		node* p1 = head;
		while (p1->value != el) {
			p1 = p1->next;
		}
		if (p1->value == el) {
			p1->next = NULL;
			delete p1;
		}
	}
	int maxx() {
		int max11;
		node* p1 = head;
		while (p1 != tail) {
			max11 = max(p1->value, p1->next->value);
			p1 = p1->next;
		}
		return max11;
	}
	int minn() {
		int min11 = 0;
		node* p1 = head;
		while (p1 != tail) {
			min11 = min(min11, p1->next->value);
			p1 = p1->next;
		}
		return min11;
	}
};