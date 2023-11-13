using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Node<T>
{
	public T Data { get; private set; }
	public Node<T>? Next { get; set; }
	public Node(T data)
	{
		Data = data;
	}
}

public class MyLinkedList<T> : IEnumerable<T>
{
	Node<T>? head;
	Node<T>? tail;
	int count = 0;

	public bool Is_Empty()
	{
		if (count == 0)
		{
			return true;
		}
		return false;
	}
	public void AddToHead(T data)
	{
		Node<T> node = new Node<T>(data);
		node.Next = head;
		head = node;
		if (count == 0)
		{
			tail = head;
		}
	}

	public bool RemoveFromHead()
	{
		if (head == null)
		{
			return false;
		}
		if (head == tail)
		{
			head = null;
			tail = null;
		}
		else
		{
			head = head!.Next;
		}
		return true;
	}

	public T GetHead()
	{
		return head.Data;
	}

	public T GetTail()
	{
		return tail.Data;
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		Node<T>? current = head;
		while (current != null)
		{
			yield return current.Data;
			current = current.Next;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<T>)this).GetEnumerator();
	}
}