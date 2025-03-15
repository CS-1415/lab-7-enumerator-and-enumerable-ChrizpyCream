namespace Lab06.Tests;

public class LinkedListStartingWithOneAtFrontTests
{
    DoublyLinkedList<int> TestList;
    [SetUp]
    public void Setup()
    {
        TestList = new DoublyLinkedList<int> (null,null, 0);
        TestList.AddFirst(6);
    }

    [Test]
    public void Test1()
    {
        TestList.AddLast(5);
        TestList.AddFirst(3);
        TestList.RemoveLast();
        TestList.RemoveFirst();
    }
}