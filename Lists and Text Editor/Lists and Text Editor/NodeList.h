#pragma once
#include<string>
/*This class came from our textbook. I don't like the way the class has been designed. It made things much harder to understand
than it really is*/
typedef char Elem;				// list base element type
class NodeList {				// node-based list
private:
	
	struct Node 
	{  
		Elem elem; 
		Node* prev; 
		Node* next;
	}; 

public:
	class Iterator 
	{				// an iterator for the list
	public:
		Elem & operator*();			// reference to the element
		bool operator==(const Iterator& p) const;	// compare positions
		bool operator!=(const Iterator& p) const;
		Iterator& operator++();			// move to next position
		Iterator& operator--();			// move to previous position
		friend class NodeList;			// give NodeList access
	private:
		Node * v;					// pointer to the node
		Iterator(Node* u);			// create from node
	};

public:
	NodeList();					// default constructor
	int size() const;				// list size
	bool empty() const;				// is the list empty?
	Iterator begin() const;			// beginning position
	Iterator end() const;			// (just beyond) last position
	void insertFront(const Elem& e);		// insert at front
	void insertBack(const Elem& e);		// insert at rear
	void insert(const Iterator& p, const Elem& e); // insert e before p
	void eraseFront();				// remove first
	void eraseBack();				// remove last
	void erase(const Iterator& p);		// remove p

	int indexOf(Elem);
	Elem atIndex(int i);
		
										
private:					// data members
	int     n;					// number of items
	Node*   head;				// head-of-list sentinel
	Node*   tail;				// tail-of-list sentinel
};