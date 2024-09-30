namespace _1381._Design_a_Stack_With_Increment_Operation;

public class CustomStack
{
    int[] array;
    public int Count = 0;
    public CustomStack(int maxSize)
    {
        array = new int[maxSize];
    }

    public void Push(int x)
    {
        if(Count < array.Length)
        {
            array[Count] = x;
            Count++;
        }
    }

    public int Pop()
    {
        if(Count == 0)
        {
            return -1;
        }
        return array[--Count];
    }

    public void Increment(int k, int val)
    {
        for(int i = 0; i < Math.Min(k, Count); i++)
        {
            array[i] += val;
        }
    }
}
