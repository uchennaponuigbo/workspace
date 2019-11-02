
#include "NodeList.h"


NodeList::NodeList()
{
	n = 0;					// initially empty
	head = new Node;				// create sentinels
	tail = new Node;
	head->next = tail;			// have them point to each other
	tail->prev = head;
}

int NodeList::size() const 			// list size
{
	return n;
}

bool NodeList::empty() const 			// is the list empty?
{
	return (n == 0);
}

NodeList::Iterator NodeList::begin() const	// begin position is first item
{
	return Iterator(head->next);
}

NodeList::Iterator NodeList::end() const	// end position is just beyond last
{
	return Iterator(tail);
}

NodeList::Iterator::Iterator(Node* u)		// constructor from Node*
{
	v = u;
}


void NodeList::insert(const NodeList::Iterator& p, const Elem& e) // insert e before p
{
	Node* w = p.v;				// p's node
	Node* u = w->prev;				// p's predecessor
	Node* v = new Node;				// new node to insert
	v->elem = e;
	v->next = w;  w->prev = v;			// link in v before w
	v->prev = u;  u->next = v;			// link in v after u
	n++;
}

void NodeList::insertFront(const Elem& e)	// insert at front
{
	insert(begin(), e);
}

void NodeList::insertBack(const Elem& e)	// insert at rear
{
	insert(end(), e);
}

void NodeList::erase(const Iterator& p) // remove p
{	
	Node* v = p.v;				// node to remove
	Node* w = v->next;				// successor
	Node* u = v->prev;				// predecessor
	u->next = w;  w->prev = u;			// unlink p
	delete v;					// delete this node
	n--;					// one fewer element
}

void NodeList::eraseFront()			// remove first
{
	erase(begin());
}

void NodeList::eraseBack()			// remove last
{
	erase(--end());
}

Elem NodeList::atIndex(int i)
{ 
	/*if (i < 0 || i >= n)
		return;*/
	Iterator p = begin();
	for (int j = 0; j < i; j++)
		++p;
	return *p;
}

int NodeList::indexOf(Elem p)
{
	int j = 0;
	for (Iterator q = begin(); q != end(); ++q)
	{
		if (*q == p)
			return j;
		j++;
	}
	
	return 0;
 
}

//Iterators
Elem& NodeList::Iterator::operator*()		// reference to the element
{
	return v->elem;
}

bool NodeList::Iterator::operator==(const Iterator& p) const // compare positions
{
	return v == p.v;
}

bool NodeList::Iterator::operator!=(const Iterator& p) const
{
	return v != p.v;
}

NodeList::Iterator& NodeList::Iterator::operator++() // move to next position
{
	v = v->next; return *this;
}

NodeList::Iterator& NodeList::Iterator::operator--() // move to previous position
{
	v = v->prev; return *this;
}

//NodeList::~NodeList()
//{
//}
