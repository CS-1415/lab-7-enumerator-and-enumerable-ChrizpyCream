using System.Collections;
using System.Transactions;

namespace Lab06;

public class LinkedListEnumerator<T> : IDisposable, IEnumerator<T>, IEnumerable<T>
{
    public DoublyLinkedList<T> list;
    public DNode<T> currentNode;
    public DNode<T> firstNode;
    public LinkedListEnumerator(DoublyLinkedList<T> first)
    {
        this.list = first;
        firstNode = first._head;
    }

    public T Current => currentNode == null ? default(T) : currentNode.Value;

    object? IEnumerator.Current => currentNode == null ? default(T) : currentNode.Value;

    public void Dispose()
    {
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new LinkedListEnumerator<T>(list);
    }

    public bool MoveNext()
    {
        if (currentNode == null)
        {
            currentNode = firstNode;
            return true;
        }
        else if (currentNode.Next != null)
        {
            currentNode = currentNode.Next;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}