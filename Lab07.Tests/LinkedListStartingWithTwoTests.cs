using System.Diagnostics;

namespace Lab06.Tests;

public class LinkedListStartingWithTwoTests
{
    DoublyLinkedList<int> TestList;
    [SetUp]
    public void Setup()
    {
        TestList = new DoublyLinkedList<int> (null,null, 0);
        TestList.AddFirst(6);
        TestList.AddFirst(2);
    }

    [Test]
    public void Test1()
    {
        TestList.RemoveFirst();
        TestList.RemoveLast();
        Debug.Assert(TestList.Length == 0);
    }
}