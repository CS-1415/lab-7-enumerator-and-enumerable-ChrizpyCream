using System.Diagnostics;
using NUnit.Framework.Internal;

namespace Lab06.Tests;

public class LinkedListStartingWithThreeTests
{
    DoublyLinkedList<int> TestList;
    [SetUp]
    public void Setup()
    {
        TestList = new DoublyLinkedList<int> (null,null, 0);
        TestList.AddFirst(6);
        TestList.AddFirst(2);
        TestList.AddFirst(-9);
    }

    [Test]
    public void Test1()
    {
        TestList.ReverseList();
    }
}