using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> nodeToInsert = new LinkedListNode<int> (n);

        myLList.AddFirst(nodeToInsert);
        return nodeToInsert;
    }
}
