using System;

///<summary> Class for que opperations</summary>
class Queue<T>
{
  ///<summary> Set nodes for queue </summary>
	public class Node
	{
		public T value = default(T);
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

  ///<summary> Delete the last node on the Queue </summary>
	public T Dequeue()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		else
		{
			T value = head.value;
			head = head.next;
			count--;
			return value;
		}
	}

  ///<summary> Return the value of first node on the Queue </summary>
	public T Peek()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return default(T);
		}
		else
		{
			return head.value;
		}
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