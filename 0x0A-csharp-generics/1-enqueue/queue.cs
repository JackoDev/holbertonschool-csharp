using System;

///<summary> Class for que opperations</summary>
class Queue<T>
{
  ///<summary> Set nodes for queue </summary>
	public class Node
	{
		private T value = default(T);
		public Node next = null;

		public Node(T input)
		{
			value = input;
		}
	}

	public Node head;
	public Node tail;
	public int count;

	///<summary> Add a new node at the queue's end </summary>
	public void Enqueue(T value)
	{
		Node node = new Node(value);
		if (head == null)
		{
			head = node;
			tail = node;
		}
		else
		{
			tail.next = node;
			tail = node;
		}
		count++;
	}

	///<summary> Returns the number of nodes in the Queue </summary>
	public int Count()
	{
		return count;
	}

	///<summary> Check for the Queue's type </summary>
	///<return> Returns the Queue's type </return>
	public Type CheckType()
	{
		return typeof(T);
	}
}