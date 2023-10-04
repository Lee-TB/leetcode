/*  706. Design HashMap
 *  Design a HashMap without using any built-in hash table libraries.
 *  Implement the MyHashMap class:
 *  - MyHashMap() initializes the object with an empty map.
 *  - void put(int key, int value) inserts a (key, value) pair into the HashMap.
 *    If the key already exists in the map, update the corresponding value.
 *  - int get(int key) returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key.
 *  - void remove(key) removes the key and its corresponding value if the map contains the mapping for the key. */
namespace _706._Design_HashMap;

internal class Program
{
    static void Main(string[] args)
    {
        MyHashMap myHashMap = new MyHashMap();
        myHashMap.Put(1, 432); // The map is now [[1,1]]
        myHashMap.Put(2, 123); // The map is now [[1,1], [2,2]]
        myHashMap.Put(100, 523); // The map is now [[1,1], [2,2]]

        Console.WriteLine(myHashMap.Count);        

        myHashMap.Remove(1);
        myHashMap.Remove(0);
        Console.WriteLine(myHashMap[100]);
        Console.WriteLine(myHashMap.Count);
        Console.WriteLine("contains test");
        Console.WriteLine(myHashMap.Contains(100));
        Console.WriteLine(myHashMap.Contains(2));

        Console.WriteLine(myHashMap.Contains(1));
        Console.WriteLine(myHashMap.Contains(123));
    }

}

public class Node
{
    public int Key { get; set; }
    public int Value { get; set; }
    public Node Next { get; set; }
    public Node(int key = -1, int value = -1, Node next = null)
    {
        Key = key;
        Value = value;
        Next = next;
    }
}


public class MyHashMap
{
    private Node[] map;
    private int _count;
    public MyHashMap()
    {
        map = new Node[1000];
        _count = 0;
    }

    public int this[int key]
    {
        get {
            int index = Hash(key);
            Node current = map[index];
            while (current != null)
            {
                if (current.Key == key)
                {
                    return current.Value;
                }
                current = current.Next;
            }
            return -1;
        }
    }

    public int Count { get => _count; }

    private int Hash(int key) {
        return key % map.Length;
    }

    public void Put(int key, int value)
    {
        int index = Hash(key);
        Node current = map[index];

        while(current != null)
        {
            if(current.Key == key)
            {
                current.Value = value;
                _count--;
                return;
            }
            current = current.Next;
        }                
        _count++;
        map[index] = new Node(key, value, map[index]);
    }

    public int Get(int key) {
        int index = Hash(key);
        Node current = map[index];

        while (current != null)
        {
            if (current.Key == key)
            {                
                return current.Value;
            }
            current = current.Next;
        }

        return -1;
    }

    public void Remove(int key)
    {
        int index = Hash(key);
        Node current = map[index];
        Node previous = null;

        while (current != null)
        {
            if (current.Key == key)
            {
                if(previous != null)
                {
                    previous.Next = current.Next;
                } else
                {
                    map[index] = current.Next;
                }
                _count--;
                return;
            }
            previous = current.Next;
            current = current.Next;
        }
    }

    public bool Contains(int key)
    {
        int index = Hash(key);
        Node current = map[index];

        while(current != null)
        {
            if(current.Key == key)
            {
                return true;
            }
            current = current.Next;
        }

        return false;
    }
}