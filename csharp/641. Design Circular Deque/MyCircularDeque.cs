namespace _641._Design_Circular_Deque;

public class MyCircularDeque
{
    private int[] array;
    private int frontIndex;
    private int backIndex;
    public int Count { get; private set; } = 0;
    private int capacity;
    public MyCircularDeque(int k)
    {
        capacity = k;
        array = new int[k];
        frontIndex = 0;
        backIndex = capacity - 1;
    }

    public bool InsertFront(int value)
    {
        if (IsFull()) return false;

        frontIndex = (frontIndex - 1 + capacity) % capacity;
        array[frontIndex] = value;
        Count++;

        return true;
    }

    public bool InsertLast(int value)
    {
        if (IsFull()) return false;

        backIndex = (backIndex + 1) % capacity;
        array[backIndex] = value;
        Count++;

        return true;
    }

    public bool DeleteFront()
    {
        if (IsEmpty()) return false;
        frontIndex = (frontIndex + 1) % capacity;
        Count--;
        return true;
    }

    public bool DeleteLast()
    {
        if (IsEmpty()) return false;
        backIndex = (backIndex - 1 + capacity) % capacity;
        Count--;
        return true;
    }

    public int GetFront()
    {
        if (IsEmpty()) return -1;
        return array[frontIndex];
    }

    public int GetRear()
    {
        if (IsEmpty()) return -1;
        return array[backIndex];
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
