//Christopher Hercules 3/13/25 Lab 07 Done
using System.Collections;

namespace Lab06;

// Interface defining a double-ended collection
public interface IDoubleEndedCollection<T>
{
    int Length { get; set; } // Property to track the length of the collection
    void AddLast(T value);  // Method to add an element to the end
    void AddFirst(T value); // Method to add an element to the beginning
    void RemoveFirst();     // Method to remove the first element
    void RemoveLast();      // Method to remove the last element
    void ReverseList();     // Method to reverse the list
}

// Class implementing a doubly linked list
public class DoublyLinkedList<T> : IDoubleEndedCollection<T>, IEnumerable<T>
{
    public DNode<T>? _head = null; // Reference to the head (first node)
    private DNode<T>? _tail = null; // Reference to the tail (last node)
    public int Length { get; set; } = 0; // Tracks the length of the list

    // Constructor initializing the linked list with given head, tail, and length
    public DoublyLinkedList(DNode<T>? _head, DNode<T>? _tail, int Length)
    {
        this._head = _head;
        this._tail = _tail;
        this.Length = Length;
    }

    // Adds a new node with the given value at the end of the list
    public void AddLast(T value)
    {
        DNode<T> dNode = new DNode<T>(value, null, null); // Create a new node
        
        if (_head == null) // If the list is empty
        {
            _head = dNode;
            _tail = dNode;
        }
        else // If list is not empty
        {
            _tail.Next = dNode; // Link current tail to new node
            dNode.Previous = _tail; // Link new node to current tail
            _tail = dNode; // Update tail reference
        }
        Length++; // Increment length
    }

    // Removes the last node from the list
    public void RemoveLast()
    {
        if (_tail == null) return; // If list is empty, do nothing
        
        if (_tail.Previous == null) // If only one node exists
        {
            _head = null;
            _tail = null;
        }
        else // More than one node exists
        {
            _tail = _tail.Previous; // Move tail reference back
            _tail.Next = null; // Disconnect last node
        }
        Length--; // Decrease length
    }

    // Adds a new node with the given value at the beginning of the list
    public void AddFirst(T value)
    {
        DNode<T> dNode = new DNode<T>(value, null, null); // Create a new node
        
        if (_head == null) // If the list is empty
        {
            _head = dNode;
            _tail = dNode;
        }
        else // If list is not empty
        {
            _head.Previous = dNode; // Link current head to new node
            dNode.Next = _head; // Link new node to current head
            _head = dNode; // Update head reference
        }
        Length++; // Increment length
    }

    // Removes the first node from the list
    public void RemoveFirst()
    {
        if (_head == null) return; // If list is empty, do nothing
        
        if (_head == _tail) // If only one node exists
        {
            _head = null;
            _tail = null;
        }
        else // More than one node exists
        {
            _head = _head.Next; // Move head reference forward
            _head.Previous = null; // Disconnect previous node
        }
        Length--; // Decrease length
    }

    // Reverses the linked list
    public void ReverseList()
    {
        DNode<T>? current = _tail; // Start from the tail
        DNode<T>? temp_head = null;
        DNode<T>? temp_tail = null;
        
        while (current != null)
        {
            DNode<T> dNode = new DNode<T>(current.Value, null, null); // Create new node with current value
            
            if (temp_head == null) // If new list is empty
            {
                temp_head = dNode;
                temp_tail = dNode;
            }
            else // If new list is not empty
            {
                temp_tail.Previous = dNode; // Link new node to tail
                dNode.Next = temp_tail; // Link tail to new node
                temp_tail = dNode; // Update tail reference
            }
            current = current.Previous; // Move to previous node
        }
        
        _head = temp_head; // Update head reference
        _tail = temp_tail; // Update tail reference
    }

    // Returns an enumerator to iterate over the list
    public IEnumerator<T> GetEnumerator()
    {
        return new LinkedListEnumerator<T>(this);
    }

    // Explicit interface implementation for IEnumerable
    IEnumerator IEnumerable.GetEnumerator()
    {
        return new LinkedListEnumerator<T>(this);
    }
}
