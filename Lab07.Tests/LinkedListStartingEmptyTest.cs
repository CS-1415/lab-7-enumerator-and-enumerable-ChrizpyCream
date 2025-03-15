using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework.Internal;

namespace Lab06.Tests;

public class LinkedListStartingEmpty
{
    public DoublyLinkedList<int> TestList;
    [SetUp]
    public void Setup()
    {
        TestList = new DoublyLinkedList<int> (null, null, 0);
    }

    [Test]
    public void Test1()
    {
        TestList.AddFirst(8);
        TestList.AddLast(3);
        Debug.Assert(TestList.Length == 2);
    }
}