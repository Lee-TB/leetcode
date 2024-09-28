using static System.Net.Mime.MediaTypeNames;

namespace _641._Design_Circular_Deque;
public class Node
{
    public int Value { get; set; }
    public Node? Prev { get; set; }
    public Node? Next { get; set; }
}
public class MyCircularDequeLinkedList
{
    public int Count { get; private set; }
    private int capacity;
    private Node? front;
    private Node? back;

    public MyCircularDequeLinkedList(int k)
    {
        capacity = k;
        Count = 0;
    }

    public bool InsertFront(int value)
    {
        if (IsFull()) return false;

        if (front is null)
        {
            front = new Node()
            {
                Value = value,
                Prev = null,
                Next = null,
            };
            back = front;
        }
        else
        {
            Node newNode = new Node()
            {
                Value = value,
                Prev = null,
                Next = front,
            };
            front.Prev = newNode;
            front = newNode;
        }
        Count++;

        return true;
    }

    public bool InsertLast(int value)
    {
        if (IsFull()) return false;

        if (back is null)
        {
            back = new Node()
            {
                Value = value,
                Prev = null,
                Next = null,
            };
            front = back;
        }
        else
        {
            Node newNode = new Node()
            {
                Value = value,
                Prev = back,
                Next = null,
            };
            back.Next = newNode;
            back = newNode;
        }
        Count++;

        return true;
    }

    public bool DeleteFront()
    {
        if (IsEmpty()) return false;
        if (Count == 1)
        {
            front = null;
            back = null;            
        } else
        {
            front = front?.Next;
        }
        Count--;
        return true;
    }

    public bool DeleteLast()
    {
        if (IsEmpty()) return false;
        if (Count == 1)
        {
            front = null;
            back = null;
        }
        else
        {
            back = back?.Prev;            
        }
        Count--;
        return true;
    }

    public int GetFront()
    {
        if (IsEmpty()) return -1;
        return front.Value;
    }

    public int GetRear()
    {
        if (IsEmpty()) return -1;
        return back.Value;
    }

    public bool IsEmpty()
    {
        return Count == 0;
    }

    public bool IsFull()
    {
        return Count == capacity;
    }
}

/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * bool param_1 = obj.InsertFront(value);
 * bool param_2 = obj.InsertLast(value);
 * bool param_3 = obj.DeleteFront();
 * bool param_4 = obj.DeleteLast();
 * int param_5 = obj.GetFront();
 * int param_6 = obj.GetRear();
 * bool param_7 = obj.IsEmpty();
 * bool param_8 = obj.IsFull();
 */
